using System.Collections.ObjectModel;
using System.Collections.Generic;
using AForge.Video.DirectShow;
using AForge.Video;

using System.Diagnostics;


namespace AOG_CAMERAS
{
    public partial class Form1 : Form
    {
        public FilterInfoCollection LoaclWebCamsCollection;
        public List<VideoCaptureDevice> cameras = new List<VideoCaptureDevice>();
        public List<AForge.Controls.VideoSourcePlayer> players = new List<AForge.Controls.VideoSourcePlayer>();

        public Form1()
        {
            InitializeComponent();

            //ad video players to List
            players.Add(videoSourcePlayer1);
            players.Add(videoSourcePlayer2); 

            // detect all camera devices
            LoaclWebCamsCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);            

            foreach ( FilterInfo camera in LoaclWebCamsCollection)
            {
                cameras.Add( new VideoCaptureDevice(camera.MonikerString));
            }

            int camera_i = 0;
            foreach (VideoCaptureDevice camera in cameras)
            {
                camera.NewFrame += new NewFrameEventHandler(video_NewFrame);
                camera.Start();
                // add camera to video source player
                players[camera_i].VideoSource = camera;
                camera_i++;
            }
            camera_i = 0;

            

        }

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // get new frame
            Bitmap bitmap = eventArgs.Frame;
            
            // process the frame
        }
    }
}


/*
 


        public MainWindow()
        {
            InitializeComponent();
            
        }


        
 
 */