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
    internal class ComboBoxController
    {
        private Collection<CameraSettingsPanel> cameraPanels = new Collection<CameraSettingsPanel>();
        private Collection<Camera> allCameras;
        private Collection<Camera> avaliableCameras;

        public ComboBoxController()
        {
            allCameras = new Collection<Camera>();
            avaliableCameras = new Collection<Camera>();
        }

        public void updateAllCameras(Collection<Camera> cameras, bool Initialize)
        {
            if (Initialize)
            {
                this.allCameras.Clear();
                this.avaliableCameras.Clear();

                foreach (Camera camera in cameras)
                {
                    allCameras.Add(camera);
                    avaliableCameras.Add(camera);
                }
            }
            else
            {
                this.allCameras.Clear();
                foreach (Camera camera in cameras)
                {
                    allCameras.Add(camera);
                }
            }
        }

        private void updateAvaliableCameras(Collection<Camera> cameras)
        {
            this.avaliableCameras.Clear();
            this.avaliableCameras = cameras;
        }

        public void updateComboxList(object sender, EventArgs e)
        {
            ComboBox combobox = sender as ComboBox;
            UpdateCurrentlyUsedCameras(combobox);
            combobox.Items.Clear();
            foreach (Camera camera in avaliableCameras)
            {
                combobox.Items.Add(camera.name);
            }
        }

        public void onComboboxUpdated(object sender, EventArgs e)
        {
            ComboBox combobox = sender as ComboBox;
            UpdateCurrentlyUsedCameras(combobox);
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
            cameraPanels.Clear();
        }

        public void UpdateCurrentlyUsedCameras(ComboBox combobox)
        {
            Trace.WriteLine("allCameras 1: " + allCameras.Count + "    " + "avaliableCameras 1: " + avaliableCameras.Count);
            avaliableCameras.Clear();
            foreach (CameraSettingsPanel panel in cameraPanels)
            {
                ComboBox cb = panel.GetCombobox() as ComboBox;

                foreach(Camera camera in allCameras)
                {
                    if(camera.name != cb.Text && !avaliableCameras.Contains(camera)) avaliableCameras.Add(camera);
                }
            }

        }
    }
}
