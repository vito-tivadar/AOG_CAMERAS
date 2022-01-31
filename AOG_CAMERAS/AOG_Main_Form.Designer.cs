namespace AOG_CAMERAS
{
    partial class AOG_CAMERAS
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.camera_divider = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab_camera = new System.Windows.Forms.TabPage();
            this.button_camera_settings = new System.Windows.Forms.Button();
            this.button_get_info = new System.Windows.Forms.Button();
            this.button_cameras_start = new System.Windows.Forms.Button();
            this.button_cameras_stop = new System.Windows.Forms.Button();
            this.tab_settings = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tab_camera.SuspendLayout();
            this.SuspendLayout();
            // 
            // camera_divider
            // 
            this.camera_divider.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.camera_divider.ColumnCount = 1;
            this.camera_divider.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.camera_divider.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.camera_divider.Location = new System.Drawing.Point(3, 32);
            this.camera_divider.Name = "camera_divider";
            this.camera_divider.RowCount = 1;
            this.camera_divider.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.camera_divider.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.camera_divider.Size = new System.Drawing.Size(1053, 791);
            this.camera_divider.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl.AllowDrop = true;
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tab_camera);
            this.tabControl.Controls.Add(this.tab_settings);
            this.tabControl.HotTrack = true;
            this.tabControl.ItemSize = new System.Drawing.Size(100, 20);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1090, 837);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 1;
            // 
            // tab_camera
            // 
            this.tab_camera.AllowDrop = true;
            this.tab_camera.Controls.Add(this.button_camera_settings);
            this.tab_camera.Controls.Add(this.button_get_info);
            this.tab_camera.Controls.Add(this.button_cameras_start);
            this.tab_camera.Controls.Add(this.button_cameras_stop);
            this.tab_camera.Controls.Add(this.camera_divider);
            this.tab_camera.Location = new System.Drawing.Point(24, 4);
            this.tab_camera.Name = "tab_camera";
            this.tab_camera.Padding = new System.Windows.Forms.Padding(3);
            this.tab_camera.Size = new System.Drawing.Size(1062, 829);
            this.tab_camera.TabIndex = 0;
            this.tab_camera.Text = "Camera Stream";
            this.tab_camera.UseVisualStyleBackColor = true;
            // 
            // button_camera_settings
            // 
            this.button_camera_settings.Location = new System.Drawing.Point(407, 3);
            this.button_camera_settings.Name = "button_camera_settings";
            this.button_camera_settings.Size = new System.Drawing.Size(148, 23);
            this.button_camera_settings.TabIndex = 4;
            this.button_camera_settings.Text = "Open Camera Settings";
            this.button_camera_settings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_camera_settings.UseVisualStyleBackColor = true;
            this.button_camera_settings.Click += new System.EventHandler(this.button_camera_settings_Click);
            // 
            // button_get_info
            // 
            this.button_get_info.Location = new System.Drawing.Point(273, 3);
            this.button_get_info.Name = "button_get_info";
            this.button_get_info.Size = new System.Drawing.Size(128, 23);
            this.button_get_info.TabIndex = 3;
            this.button_get_info.Text = "Get Camera Info";
            this.button_get_info.UseVisualStyleBackColor = true;
            this.button_get_info.Click += new System.EventHandler(this.button_get_info_Click);
            // 
            // button_cameras_start
            // 
            this.button_cameras_start.Location = new System.Drawing.Point(139, 3);
            this.button_cameras_start.Name = "button_cameras_start";
            this.button_cameras_start.Size = new System.Drawing.Size(128, 23);
            this.button_cameras_start.TabIndex = 2;
            this.button_cameras_start.Text = "Start Cameras";
            this.button_cameras_start.UseVisualStyleBackColor = true;
            this.button_cameras_start.Click += new System.EventHandler(this.button_cameras_start_Click);
            // 
            // button_cameras_stop
            // 
            this.button_cameras_stop.Location = new System.Drawing.Point(6, 3);
            this.button_cameras_stop.Name = "button_cameras_stop";
            this.button_cameras_stop.Size = new System.Drawing.Size(128, 23);
            this.button_cameras_stop.TabIndex = 1;
            this.button_cameras_stop.Text = "Stop Cameras";
            this.button_cameras_stop.UseVisualStyleBackColor = true;
            this.button_cameras_stop.Click += new System.EventHandler(this.button_cameras_stop_Click);
            // 
            // tab_settings
            // 
            this.tab_settings.Location = new System.Drawing.Point(24, 4);
            this.tab_settings.Name = "tab_settings";
            this.tab_settings.Padding = new System.Windows.Forms.Padding(3);
            this.tab_settings.Size = new System.Drawing.Size(1062, 829);
            this.tab_settings.TabIndex = 1;
            this.tab_settings.Text = "Settings";
            this.tab_settings.UseVisualStyleBackColor = true;
            // 
            // AOG_CAMERAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 833);
            this.Controls.Add(this.tabControl);
            this.Name = "AOG_CAMERAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AOG CAMERA STREAM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AOG_CAMERAS_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.tab_camera.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel camera_divider;
        private TabControl tabControl;
        private TabPage tab_camera;
        private TabPage tab_settings;
        private Button button_cameras_start;
        private Button button_cameras_stop;
        private Button button_get_info;
        private Button button_camera_settings;
    }
}