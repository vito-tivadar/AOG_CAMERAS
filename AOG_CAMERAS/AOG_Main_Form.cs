/*
 * POST BUILD EVENT TO COPY FILES TO /lib SUBFOLDER
 ROBOCOPY "$(TargetDir) " "$(TargetDir)lib\ " /XF *.exe *.config *.manifest *.json *.pdb /XD lib ref settings /E /IS /MOVE
if %errorlevel% leq 4 exit 0 else exit %errorlevel%
 */

using System.Collections.ObjectModel;
using System.Collections.Generic;
using AForge.Video.DirectShow;
using AForge.Video;
using System.Windows.Forms;

//using System;
using System.Diagnostics;
using AOG_CAMERAS.UserControls;
using Newtonsoft.Json;



namespace AOG_CAMERAS
{
    public partial class AOG_CAMERAS : Form
    {
        // create settings object
        AOGSettings settings = new AOGSettings(Path.GetFullPath("settings"), "settings.json");
        ComboBoxController comboboxController = new ComboBoxController();

        // struct needed for detecting usb devices
        private struct DEV_BROADCAST_HDR
        {
            internal UInt32 dbch_size;
            internal UInt32 dbch_devicetype;
            internal UInt32 dbch_reserved;
        };

        public Collection<string> profiles = new Collection<string>();
        public Collection<VideoCaptureDevice> connected_cams = new Collection<VideoCaptureDevice>();

        internal Collection<Camera> detectedCameras = new Collection<Camera>();




        public AOG_CAMERAS()
        {
            InitializeComponent();
            UsbNotification.RegisterUsbDeviceNotification(this.Handle);

            DetectUSBCameras();
            
            if(settings.GetProfiles().Count != 0)
            { 
                foreach(Profile profile in settings.GetProfiles())
                {
                    profileDropDownMenu.Items.Add(profile.name);
                }
            }

            tabControl.SelectTab(1);

            #region TEST CODE






            #endregion
        }

        #region methods
        // detect if device was added or removed
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == UsbNotification.WmDevicechange)
            {
                switch ((int)m.WParam)
                {
                    case UsbNotification.DbtDeviceremovecomplete:
                        //Trace.WriteLine("Device removed!");
                    break;
                
                    case UsbNotification.DbtDevicearrival:
                            DetectUSBCameras();
                    break;
                }
            }
        }

        private void DetectUSBCameras()
        {
            detectedCameras.Clear();
            // detect all camera devices
            FilterInfoCollection ScannedCameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo cameraDevice in ScannedCameras)
            {
                VideoCaptureDevice cam = new VideoCaptureDevice(cameraDevice.MonikerString);
                string camName = cameraDevice.Name; // get camera name
                cam.NewFrame += new NewFrameEventHandler((object sender, NewFrameEventArgs eventArgs) =>
                {
                    Bitmap bitmap = eventArgs.Frame;
                    // process the frame (add filters...) 

                });
                // Trace.WriteLine(JsonConvert.SerializeObject(cam));
                Camera camera = new Camera(camName, cam);

                detectedCameras.Add(camera);
            }
            Trace.WriteLine("detected: " + detectedCameras.Count);
            comboboxController.updateAllCameras(detectedCameras);
        }
        #endregion

        #region Form Events
        //RUN ON APP START
        private void AOG_CAMERAS_Load(object sender, EventArgs e)
        {
            // read settings
        }

        // RUN ON APP EXIT
        private void AOG_CAMERAS_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        // RUN ON FOCUS GET
        private void AOG_CAMERAS_Enter(object sender, EventArgs e)
        {
            //enable cameras/player
        }

        //RUN ON FOCUS LOST
        private void AOG_CAMERAS_Leave(object sender, EventArgs e)
        {
            //disable cameras/player
        }

        private void addProfile_button_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tab_settings;

            if (tabControl.Visible == false) tabControl.Show();

            int profile_count = settings.GetProfiles().Count + 1;
            string profile_name = "New Profile(" + profile_count.ToString() + ")";

            profileNameTextBox.Text = profile_name;

            Profile newProfile = new Profile(profile_name);

            settings.AddProfile(newProfile);


        }

        private void profileDropDownMenu_DropDownClosed(object sender, EventArgs e)
        {
            menuStrip1.Focus();
        }

        // rename profile
        private void profileNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void saveProfile_button_Click(object sender, EventArgs e)
        {
            settings.Save();
        }

        private void addCamera_button_Click(object sender, EventArgs e)
        {
            CameraSettingsPanel panel = new CameraSettingsPanel(comboboxController);
            panel.Dock = DockStyle.Fill;
            if(camerasPanelSettings.Controls.Count <= 4) camerasPanelSettings.Controls.Add(panel);
            //comboboxController.AddCameraSettingsPanel(panel);
            //camerasPanelSettings.SetRowSpan(panel, 2);

            //camerasPanelSettings.SetRowSpan()
        }

        #endregion

        private void camerasPanelSettings_ControlAdded(object sender, ControlEventArgs e)
        {
            if (camerasPanelSettings.Controls.Count == 4) addCamera_button.Enabled = false;
        }
    }
}


/*
 * 
 * 
        //collection to store scanned input devices
        public bool playerFocused = false;
        public int[] playerFocusedOldPosition = new int[] { };

        // lists for created cameras and camera stream players
        public List<VideoCaptureDevice> cameras = new List<VideoCaptureDevice>();
        public List<AForge.Controls.VideoSourcePlayer> players = new List<AForge.Controls.VideoSourcePlayer>();
        public List<int[]> playerPosition = new List<int[]>();



 
            // detect all camera devices
            LoaclWebCamsCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            // create camera for each input device
            int camera_i = 0;
            foreach (FilterInfo camera in LoaclWebCamsCollection)
            {
                VideoCaptureDevice cam = new VideoCaptureDevice(camera.MonikerString);
                // Trace.WriteLine(camera.Name); // get camera name
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
                if (camera_i == 1) camera_divider.Controls.Add(newPlayer, 1, 0); playerPosition.Add(new int[] { 1, 0 });
                if (camera_i == 2) camera_divider.Controls.Add(newPlayer, 0, 1); playerPosition.Add(new int[] { 0, 1 });
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
                // camera.GetCameraProperty(CameraControlProperty.Exposure, out value, out ctrlFlags);


                Trace.WriteLine(camera);
            }
        }

        private void button_camera_settings_Click(object sender, EventArgs e)
        {
            foreach (VideoCaptureDevice camera in cameras)
            {
                // camera.DisplayPropertyPage(IntPtr.Zero);
                //Trace.WriteLine(camera.CheckIfCrossbarAvailable()); //check if 1 line bellow is allowed to use
                // camera.DisplayCrossbarPropertyPage(IntPtr.Zero);
                Trace.WriteLine(camera);
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
 
 */