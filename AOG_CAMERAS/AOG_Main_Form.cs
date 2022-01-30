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

                //newPlayer.Size = new Size(320, 180);
                //newPlayer.Location = new Point(camera_i * 320, 5);

                //add camera stream to video player
                newPlayer.VideoSource = cam;

                //add player to UI
                camera_divider.Controls.Add(newPlayer, camera_i, camera_i);
                //this.Controls.Add(newPlayer);

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
    }
}