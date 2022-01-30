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
        
        // lists for created cameras and camera strem players
        public List<VideoCaptureDevice> cameras = new List<VideoCaptureDevice>();
        public List<AForge.Controls.VideoSourcePlayer> players = new List<AForge.Controls.VideoSourcePlayer>();

        public AOG_CAMERAS()
        {
            InitializeComponent();

            // detect all camera devices
            LoaclWebCamsCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            // create camera for each input device
            int camera_i = 0;
            foreach ( FilterInfo camera in LoaclWebCamsCollection)
            {
                VideoCaptureDevice cam = new VideoCaptureDevice(camera.MonikerString);
                cam.NewFrame += new NewFrameEventHandler(video_NewFrame);

                //add video player for each camera
                AForge.Controls.VideoSourcePlayer newPlayer = new AForge.Controls.VideoSourcePlayer();
                newPlayer.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
                newPlayer.Padding = new System.Windows.Forms.Padding(0);

                //add camera stream to video player
                newPlayer.VideoSource = cam;

                //add player to UI and determine row and column
                if (camera_i == 0) camera_divider.Controls.Add(newPlayer, 0, 0);
                if (camera_i == 1) camera_divider.Controls.Add(newPlayer, 0, 1);
                if (camera_i == 2) camera_divider.Controls.Add(newPlayer, 1, 0);
                if (camera_i == 3) camera_divider.Controls.Add(newPlayer, 1, 1);

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

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // get new frame
            Bitmap bitmap = eventArgs.Frame;
            
            // process the frame
        }

        private void button_cameras_stop_Click(object sender, EventArgs e)
        {
            foreach( VideoCaptureDevice camera in cameras)
            {
                camera.SignalToStop();
            }
        }

        private void button_cameras_start_Click(object sender, EventArgs e)
        {
            foreach (VideoCaptureDevice camera in cameras)
            {
                camera.Start();
            }
        }

        private void button_get_info_Click(object sender, EventArgs e)
        {
            foreach(VideoCaptureDevice camera in cameras)
            {
                int value = 0;
                CameraControlFlags ctrlFlags = new CameraControlFlags();

                // 
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
    }
}