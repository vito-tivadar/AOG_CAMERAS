using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AForge.Video.DirectShow;
using AForge.Controls;

namespace AOG_CAMERAS
{
    internal class StreamPlayer
    {
        public string deviceName { get; }
        public int playerPosition { get; set; }
        private VideoCaptureDevice camera;
        private VideoSourcePlayer video_player;

        public StreamPlayer(string name, VideoCaptureDevice camera)
        {
            this.deviceName = name;
            this.camera = camera;
            video_player = new VideoSourcePlayer();
        }

        public VideoCaptureDevice getCamera()
        {
            return this.camera;
        }

        public VideoSourcePlayer getPlayer()
        {
            return this.video_player;
        }

        public void startCamera(VideoCaptureDevice camera)
        {
            camera.Start();
        }

        public void stopCamera(VideoCaptureDevice camera)
        {
            camera.WaitForStop();
        }

        public void startPlayer(VideoCaptureDevice camera)
        {
            video_player.Start();
        }

        public void stopPlayer(VideoCaptureDevice camera)
        {
            video_player.WaitForStop();
        }


    }
}
