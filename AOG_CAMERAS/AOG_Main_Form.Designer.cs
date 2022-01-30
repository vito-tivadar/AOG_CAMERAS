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
            this.camera_divider.ColumnCount = 2;
            this.camera_divider.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.camera_divider.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.camera_divider.Location = new System.Drawing.Point(6, 8);
            this.camera_divider.Name = "camera_divider";
            this.camera_divider.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.camera_divider.RowCount = 2;
            this.camera_divider.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.camera_divider.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.camera_divider.Size = new System.Drawing.Size(1351, 673);
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
            this.tabControl.Size = new System.Drawing.Size(1391, 695);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 1;
            // 
            // tab_camera
            // 
            this.tab_camera.AllowDrop = true;
            this.tab_camera.Controls.Add(this.camera_divider);
            this.tab_camera.Location = new System.Drawing.Point(24, 4);
            this.tab_camera.Name = "tab_camera";
            this.tab_camera.Padding = new System.Windows.Forms.Padding(3);
            this.tab_camera.Size = new System.Drawing.Size(1363, 687);
            this.tab_camera.TabIndex = 0;
            this.tab_camera.Text = "Camera Stream";
            this.tab_camera.UseVisualStyleBackColor = true;
            // 
            // tab_settings
            // 
            this.tab_settings.Location = new System.Drawing.Point(24, 4);
            this.tab_settings.Name = "tab_settings";
            this.tab_settings.Padding = new System.Windows.Forms.Padding(3);
            this.tab_settings.Size = new System.Drawing.Size(1363, 687);
            this.tab_settings.TabIndex = 1;
            this.tab_settings.Text = "Settings";
            this.tab_settings.UseVisualStyleBackColor = true;
            // 
            // AOG_CAMERAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 691);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AOG_CAMERAS";
            this.Text = "AOG CAMERA STREAM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl.ResumeLayout(false);
            this.tab_camera.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel camera_divider;
        private TabControl tabControl;
        private TabPage tab_camera;
        private TabPage tab_settings;
    }
}