using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;
using System.Diagnostics;
using AOG_CAMERAS.UserControls;

using Newtonsoft.Json;


namespace AOG_CAMERAS
{
    internal class CamerasController
    {
        private Collection<CameraSettingsPanel> cameraPanels = new Collection<CameraSettingsPanel>();
        private Collection<Camera> allCameras;
        private Collection<Camera> unavaliableCameras;
        private TableLayoutPanel camerasGridPanel;
        public int numberOfCameras = 0;
        public bool overlayEnabled = true;

        public CamerasController()
        {
            allCameras = new Collection<Camera>();
            unavaliableCameras = new Collection<Camera>();
        }

        public void SetCamerasTableLayoutPanel(TableLayoutPanel panel)
        {
            this.camerasGridPanel = panel;
        }

        public void updateAllCameras(Collection<Camera> cameras)
        {
            this.allCameras.Clear();
            foreach (Camera camera in cameras)
            {
                allCameras.Add(camera);
                //Trace.WriteLine(camera.name);
            }
        }

        public void RemoveFromUnavaliableCameras(string cameraName)
        {
            if (unavaliableCameras.Any(c => c.name == cameraName))
            {
                Camera c = unavaliableCameras.First(c => c.name == cameraName);
                unavaliableCameras.Remove(c);
            }
        }
        
        public void AddToUnavaliableCameras(string cameraName)
        {
            if (allCameras.Any(c => c.name == cameraName))
            {
                Camera c = allCameras.First(c => c.name == cameraName);
                unavaliableCameras.Add(c);
            }
        }

        public void AddCameraSettingsPanel(CameraSettingsPanel panel)
        {
            cameraPanels.Add(panel);
        }

        public void RemoveCameraSettingsPanel(CameraSettingsPanel panel)
        {
            if(cameraPanels.Contains(panel)) cameraPanels.Remove(panel);
        }

        public void ClearCameraSettingsPanel()
        {
            numberOfCameras = 0;
            cameraPanels.Clear();
        }

        public Camera GetCamera(string cameraName)
        {
            return this.allCameras.First(c => c.name == cameraName);
        }

        public void ToggleOverlay()
        {
            if (overlayEnabled) overlayEnabled = false;
            else overlayEnabled = true;

            foreach (CameraSettingsPanel panel in cameraPanels)
            {
                panel.EnableOverlay(overlayEnabled);
            }
        }

        // expand vertically button
        public void expandVertically_button_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            b.Text = "Shrink Vertically";
            foreach(CameraSettingsPanel p in cameraPanels)
            {
                if (p.Contains(b)) this.camerasGridPanel.SetRowSpan(p, 2);
            }
            //numberOfCameras++;
        }

        public void expandHorizontally_button_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            b.Text = "Shrink Horizontally";
            foreach (CameraSettingsPanel p in cameraPanels)
            {
                if (p.Contains(b)) this.camerasGridPanel.SetColumnSpan(p, 2);
            }
        }
    }
}
