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


namespace AOG_CAMERAS.UserControls
{
    public partial class CameraSettingsPanel : UserControl
    {
        #region getter and setter

        private string title;
        private string camera;
        private bool preview = false;
        private Collection<Camera> camerasCollection = new Collection<Camera>();
        private VideoCaptureDevice? currentCamera = null;
        private ComboBoxController controller;

        #endregion

        internal CameraSettingsPanel(ComboBoxController controller)
        {
            this.controller = controller;
            InitializeComponent();

            controller.AddCameraSettingsPanel(this);
        }

        private void previewCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            this.preview = previewCheckbox.Checked;
            this.Focus();

            if (preview)
            {
                foreach(Camera camera in this.camerasCollection)
                {
                    if(camera.name == cameraSelectDropdown.Text)
                    {
                        this.currentCamera = camera.cameraObject;
                        videoSourcePlayer.VideoSource = this.currentCamera;
                        if ( !this.currentCamera.IsRunning ) this.currentCamera.Start();

                        //cameraSelectDropdown.Items.Remove(camera.name);
                    }
                }
            }
            else if(videoSourcePlayer.VideoSource != null) this.currentCamera.SignalToStop();
        }

        public ComboBox GetCombobox()
        {
            return cameraSelectDropdown;
        }

        private void expandHorizontally_button_Click(object sender, EventArgs e)
        {

        }

        private void expandVertically_button_Click(object sender, EventArgs e)
        {

        }
    }
}
