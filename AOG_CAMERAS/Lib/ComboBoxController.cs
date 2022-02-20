using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;
using System.Diagnostics;

namespace AOG_CAMERAS
{
    internal class ComboBoxController
    {
        private Collection<Camera> allCameras;
        private List<Camera> avaliableCameras;
        

        public ComboBoxController()
        {
            allCameras = new Collection<Camera>();
            avaliableCameras = new List<Camera>();
        }

        public void updateAllCameras(Collection<Camera> cameras)
        {
            this.allCameras.Clear();
            this.allCameras = cameras;
        }

        public void updateComboxList(ComboBox combobox)
        {

        }

        public void onComboboxUpdated(object sender, EventArgs e)
        {
            ComboBox combobox = sender as ComboBox;
            Trace.WriteLine(combobox.Text);
        }

        public void ComboboxUpdated()
        {

        }
    }
}
