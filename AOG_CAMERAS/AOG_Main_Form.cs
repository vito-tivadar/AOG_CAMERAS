using System.Collections.ObjectModel;
using System.Collections.Generic;
using AForge.Video.DirectShow;
using AForge.Video;

using System.Diagnostics;


namespace AOG_CAMERAS
{
    public partial class AOG_CAMERAS : Form
    {
        //collection to store scanned input devices
        public FilterInfoCollection LoaclWebCamsCollection;
        public FilterInfo LoaclWebCamsCollection2;
        public bool playerFocused = false;
        public int[] playerFocusedOldPosition = new int[] { };

        // lists for created cameras and camera strem players
        public List<VideoCaptureDevice> cameras = new List<VideoCaptureDevice>();
        public List<AForge.Controls.VideoSourcePlayer> players = new List<AForge.Controls.VideoSourcePlayer>();
        public List<int[]> playerPosition = new List<int[]>();

        public AOG_CAMERAS()
        {
            InitializeComponent();

            // detect all camera devices
            LoaclWebCamsCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            // create camera for each input device
            int camera_i = 0;
            foreach (FilterInfo camera in LoaclWebCamsCollection)
            {
                VideoCaptureDevice cam = new VideoCaptureDevice(camera.MonikerString);
                cam.NewFrame += new NewFrameEventHandler(video_NewFrame);

                //add video player for each camera
                AForge.Controls.VideoSourcePlayer newPlayer = new AForge.Controls.VideoSourcePlayer();
                newPlayer.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
                newPlayer.Padding = new System.Windows.Forms.Padding(0);
                newPlayer.Click += ChangeFocus;

                //add camera stream to video player
                newPlayer.VideoSource = cam;

                //add player to UI and determine row and column
                if (camera_i == 0) camera_divider.Controls.Add(newPlayer, 0, 0); playerPosition.Add(new int[] { 0, 0 });
                if (camera_i == 1) camera_divider.Controls.Add(newPlayer, 0, 1); playerPosition.Add(new int[] { 0, 1 });
                if (camera_i == 2) camera_divider.Controls.Add(newPlayer, 1, 0); playerPosition.Add(new int[] { 1, 0 });
                if (camera_i == 3) camera_divider.Controls.Add(newPlayer, 1, 1); playerPosition.Add(new int[] { 1, 1 });

                cameras.Add(cam);
                players.Add(newPlayer);
                camera_i++;
            }

            //start cameras
            foreach (VideoCaptureDevice camera in cameras)
            {
                camera.Start();
            }
        }

        // RUN ON EXIT
        private void AOG_CAMERAS_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Stop all cameras and video players
            foreach (VideoCaptureDevice camera in cameras)
            {
                camera.SignalToStop();
            }
            foreach (AForge.Controls.VideoSourcePlayer player in players)
            {
                player.SignalToStop();
            }
        }

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // get new frame
            Bitmap bitmap = eventArgs.Frame;
            
            // process the frame
        }

        private void button_cameras_stop_Click(object sender, EventArgs e)
        {
            foreach(AForge.Controls.VideoSourcePlayer player in players)
            {
                player.SignalToStop();
            }
        }

        private void button_cameras_start_Click(object sender, EventArgs e)
        {
            foreach (AForge.Controls.VideoSourcePlayer player in players)
            {
                player.Start();
            }
        }

        private void button_get_info_Click(object sender, EventArgs e)
        {
            foreach(VideoCaptureDevice camera in cameras)
            {
                int value = 0;
                CameraControlFlags ctrlFlags = new CameraControlFlags();

                // camera.SetCameraProperty(CameraControlProperty.Tilt, 20, CameraControlFlags.Manual);
                camera.GetCameraProperty(CameraControlProperty.Exposure, out value, out ctrlFlags);
                Trace.WriteLine(value);
            }
        }

        private void button_camera_settings_Click(object sender, EventArgs e)
        {
            foreach (VideoCaptureDevice camera in cameras)
            {
                // camera.DisplayPropertyPage(IntPtr.Zero);
                // Trace.WriteLine(camera.CheckIfCrossbarAvailable()); //check if 1 line bellow is allowed to use
                // camera.DisplayCrossbarPropertyPage(IntPtr.Zero);
                Trace.WriteLine(camera);
            }
        }


        private void ChangeFocus(object sender, EventArgs e) // AForge.Controls.VideoSourcePlayer video_player
        {
            if (!playerFocused)
            {
                focusOnPlayer(sender);
                playerFocused = true;
            }
            else
            {
                unfocusPlayer(sender);
                playerFocused = false;
            }

        }

        private void focusOnPlayer(object sender)
        {
            foreach (AForge.Controls.VideoSourcePlayer player in players)
            {
                if (sender != player)
                {
                    player.SignalToStop();
                    player.Hide();
                }
                else
                {
                    int player_pos = players.FindIndex(p => p == player);
                    playerFocusedOldPosition = playerPosition[player_pos];
                    camera_divider.Controls.Add(player, 0, 0);
                }
            }
            camera_divider.RowCount = 0;
            camera_divider.ColumnCount = 0;
        }
        
        private void unfocusPlayer(object sender)
        {

            foreach (AForge.Controls.VideoSourcePlayer player in players)
            {
                if (sender != player)
                {
                    player.Start();
                    player.Show();
                }
                else
                {
                    camera_divider.Controls.Add(player, playerFocusedOldPosition[0], playerFocusedOldPosition[1]); // add to old position
                    player.Start();
                }
                
            }
            // add rows/columns
        }
    }
}