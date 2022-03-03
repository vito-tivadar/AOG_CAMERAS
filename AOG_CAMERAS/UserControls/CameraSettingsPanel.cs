using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using Newtonsoft.Json;
using AForge.Video.DirectShow;
using AForge.Controls;


namespace AOG_CAMERAS.UserControls
{
    public partial class CameraSettingsPanel : UserControl
    {
        #region getter and setter

        private bool preview = false;
        private Collection<Camera> camerasCollection = new Collection<Camera>();
        internal Camera camera;
        internal string selectedCameraName = "";
        internal VideoCaptureDevice? currentCamera = null;
        private CamerasController controller;

        #endregion

        internal CameraSettingsPanel(CamerasController controller, Camera camera)
        {
            this.controller = controller;
            this.camera = camera;
            this.currentCamera = camera.cameraObject;

            controller.AddToUnavaliableCameras(this.camera.name);

            InitializeComponent();
            
            cameraName_label.Text = this.camera.name;
            videoSourcePlayer.VideoSource = this.currentCamera;
            videoSourcePlayer.Start();
            this.currentCamera.Start();
            EnableOverlay(controller.overlayEnabled);


            controller.AddCameraSettingsPanel(this);
        }

        public void EnableOverlay(bool isEnabled)
        {
            Collection<Control> controls = new Collection<Control>() { cameraName_label, expandHorizontally_button, expandVertically_button, remove_button };
            foreach (Control control in controls)
            {
                if(isEnabled) control.Show();
                else control.Hide();
            }
        }
        
        public VideoSourcePlayer GetVideoSourcePlayer()
        {
            return this.videoSourcePlayer;
        }
    }
}
