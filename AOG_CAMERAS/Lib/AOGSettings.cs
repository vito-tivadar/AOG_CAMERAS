using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;
using System.IO;
using AForge.Video.DirectShow;
using AForge.Video;
using Newtonsoft.Json;

using System.Diagnostics;

namespace AOG_CAMERAS
{

    internal class AOGSettings
    {
        private string settingsPath;
        private string fileName;
        private string fullPath;
        public Profile? lastSelectedProfile = null;
        public Collection<Profile> profilesCollection;

        public AOGSettings(string settingsPath, string fileName)
        {
            this.settingsPath = settingsPath;
            this.fileName = fileName;

            SetPath(this.settingsPath, this.fileName);

            // create directory if doesnt exist
            if (!Directory.Exists(this.settingsPath)) Directory.CreateDirectory(this.settingsPath);
            Read();
        }

        public void SetPath(string settingsPath, string fileName)
        {
            if (!settingsPath.EndsWith(Path.DirectorySeparatorChar))
            {
                settingsPath += Path.DirectorySeparatorChar;
                this.settingsPath = settingsPath;
            }

            if (!fileName.EndsWith(".json"))
            {
                fileName += ".json";
                this.fileName = fileName;
            }

            this.fullPath = settingsPath + fileName;
        }

        public string GetPath()
        {
            return this.fullPath;
        }

        public void Read()
        {
            if (File.Exists(this.fullPath))
            {
                string fileContent;
                using (StreamReader sr = new StreamReader(this.fullPath))
                {
                    fileContent = sr.ReadToEnd();
                    sr.Close();
                }
                this.profilesCollection = JsonConvert.DeserializeObject<Collection<Profile>>(fileContent);
                
                //find last selected profile
                foreach(Profile profile in this.profilesCollection)
                {
                    if (profile.selected) this.lastSelectedProfile = profile;
                }
            }
            else
            {
                this.profilesCollection = new Collection<Profile>();
                using (StreamWriter sw = File.CreateText(this.fullPath))
                {
                    sw.WriteLine(JsonConvert.SerializeObject(this.profilesCollection));
                    sw.Close();
                }
            }
        }

        public void Save()
        {
            using (StreamWriter sw = File.CreateText(this.fullPath))
            {
                sw.Write(JsonConvert.SerializeObject(this.profilesCollection, Formatting.Indented));
                sw.Close();
            }
        }

        public bool AddProfile(Profile profile)
        {
            foreach(Profile existingProfile in this.profilesCollection)
            {
                if (existingProfile.name == profile.name) return false;
            }
            profilesCollection.Add(profile);
            this.Save();
            return true;
        }

        public bool RemoveProfile(Profile profile)
        {
            if(this.profilesCollection.Contains(profile))
            {
                this.profilesCollection.Remove(profile);
                this.Save();
                return true;
            }
            else return false;
        }

        public bool UpdateProfile(Profile profile)
        {
            foreach(Profile existingProfile in this.profilesCollection)
            {
                if (existingProfile.name == profile.name)
                {
                    int position = this.profilesCollection.IndexOf(existingProfile);
                    this.profilesCollection.Remove(existingProfile);
                    this.profilesCollection.Insert(position, profile);
                    return true;
                }

            }
            return false;
        }

        public Collection<Profile> GetProfiles()
        {
            return this.profilesCollection;
        }
    }



    // PROFILE CLASS
    internal class Profile
    {
        public string name;
        public bool selected = false;
        public Collection<Camera> camerasCollection;

        public Profile(string name)
        {
            this.name = name;
            this.camerasCollection = new Collection<Camera>();
        }

        public bool AddCamera(Camera camera)
        {
            foreach (Camera existingCamera in this.camerasCollection)
            {
                if (existingCamera.name == camera.name) return false;
            }
            camerasCollection.Add(camera);
            return true;
        }

        public bool RemoveCamera(Camera camera)
        {
            if (this.camerasCollection.Contains(camera))
            {
                this.camerasCollection.Remove(camera);
                return true;
            }
            else return false;
        }

        public bool UpdateCamera(Camera camera)
        {
            foreach (Camera existingCamera in this.camerasCollection)
            {
                if (existingCamera.name == camera.name)
                {
                    int position = this.camerasCollection.IndexOf(existingCamera);
                    this.camerasCollection.Remove(existingCamera);
                    this.camerasCollection.Insert(position, camera);
                    return true;
                }

            }
            return false;
        }
    }

        

    // CAMERA CLASS
    internal class Camera
    {
        public string name;
        public int? row = null;
        public int? column = null;
        public int? height = null;
        public int? width = null;
        public VideoCaptureDevice cameraObject;


        public Camera(string name, VideoCaptureDevice cameraObject, int? row, int? column)
        {
            this.name = name;
            this.row = row;
            this.column = column;
            this.cameraObject = cameraObject;
        }
        
        public Camera(string name, VideoCaptureDevice cameraObject)
        {
            this.name = name;
            this.cameraObject = cameraObject;
        }

        public void SetPosition(int row, int column)
        {
            this.row = row;
            this.column = column;
        }
        
        public void SetSize(int height, int width)
        {
            this.height = height;
            this.width = width;
        }

        //public VideoCaptureDevice CameraFromMonkierString()
        //{
        //    VideoCaptureDevice camera = new VideoCaptureDevice(this.cameraObject);
        //    camera.NewFrame += new NewFrameEventHandler((object sender, NewFrameEventArgs eventArgs) => {
        //        Bitmap bitmap = eventArgs.Frame;
        //        // process the frame (add filters...) 

        //    });

        //    return camera;
        //}
    }
}
