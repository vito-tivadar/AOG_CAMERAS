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
        private Collection<Camera> unAvaliableCameras;

        public ComboBoxController()
        {
            allCameras = new Collection<Camera>();
            unAvaliableCameras = new Collection<Camera>();
        }

        public void updateAllCameras(Collection<Camera> cameras)
        {
            this.allCameras.Clear();
            foreach (Camera camera in cameras)
            {
                allCameras.Add(camera);
            }
        }

        private void updateAvaliableCameras(Collection<Camera> cameras)
        {
            this.unAvaliableCameras.Clear();
            this.unAvaliableCameras = cameras;
        }

        public void updateComboxList(object sender, EventArgs e)
        {
            ComboBox combobox = sender as ComboBox;
            UpdateCurrentlyUsedCameras(combobox);
            foreach (var item in combobox.Items)
            {
                if(item.ToString() != combobox.Text ) combobox.Items.Remove(item);
            }

            if (combobox.Items.Count > 1) combobox.Items.RemoveAt(1); 

            foreach (Camera camera in allCameras)
            {
                if(!unAvaliableCameras.Contains(camera)) combobox.Items.Add(camera.name);
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
            unAvaliableCameras.Clear();
            foreach (CameraSettingsPanel panel in cameraPanels)
            {
                ComboBox cb = panel.GetCombobox() as ComboBox;

                foreach(Camera camera in allCameras)
                {
                    if(camera.name == cb.Text && !unAvaliableCameras.Contains(camera)) unAvaliableCameras.Add(camera);
                }
            }

        }
    }
}
