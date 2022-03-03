namespace AOG_CAMERAS.UserControls
{
    partial class CameraSettingsPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.remove_button = new System.Windows.Forms.Button();
            this.cameraName_label = new System.Windows.Forms.Label();
            this.expandHorizontally_button = new System.Windows.Forms.Button();
            this.expandVertically_button = new System.Windows.Forms.Button();
            this.videoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.SuspendLayout();
            // 
            // remove_button
            // 
            this.remove_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.remove_button.Location = new System.Drawing.Point(369, 3);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(84, 32);
            this.remove_button.TabIndex = 0;
            this.remove_button.Text = "REMOVE";
            this.remove_button.UseVisualStyleBackColor = true;
            // 
            // cameraName_label
            // 
            this.cameraName_label.AutoSize = true;
            this.cameraName_label.Location = new System.Drawing.Point(3, 3);
            this.cameraName_label.Name = "cameraName_label";
            this.cameraName_label.Size = new System.Drawing.Size(104, 21);
            this.cameraName_label.TabIndex = 1;
            this.cameraName_label.Text = "camera name";
            // 
            // expandHorizontally_button
            // 
            this.expandHorizontally_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.expandHorizontally_button.Location = new System.Drawing.Point(258, 227);
            this.expandHorizontally_button.Name = "expandHorizontally_button";
            this.expandHorizontally_button.Size = new System.Drawing.Size(195, 30);
            this.expandHorizontally_button.TabIndex = 2;
            this.expandHorizontally_button.Text = "EXPAND HOTIZONTALLY";
            this.expandHorizontally_button.UseVisualStyleBackColor = true;
            this.expandHorizontally_button.Click += new System.EventHandler(this.controller.expandHorizontally_button_Click);
            // 
            // expandVertically_button
            // 
            this.expandVertically_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.expandVertically_button.Location = new System.Drawing.Point(3, 227);
            this.expandVertically_button.Name = "expandVertically_button";
            this.expandVertically_button.Size = new System.Drawing.Size(195, 30);
            this.expandVertically_button.TabIndex = 3;
            this.expandVertically_button.Text = "EXPAND VERTICALLY";
            this.expandVertically_button.UseVisualStyleBackColor = true;
            this.expandVertically_button.Click += new System.EventHandler(this.controller.expandVertically_button_Click);
            // 
            // videoSourcePlayer
            // 
            this.videoSourcePlayer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.videoSourcePlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoSourcePlayer.Location = new System.Drawing.Point(0, 0);
            this.videoSourcePlayer.Name = "videoSourcePlayer";
            this.videoSourcePlayer.Size = new System.Drawing.Size(456, 260);
            this.videoSourcePlayer.TabIndex = 5;
            this.videoSourcePlayer.Text = "videoSourcePlayer1";
            this.videoSourcePlayer.VideoSource = null;
            // 
            // CameraSettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.expandVertically_button);
            this.Controls.Add(this.expandHorizontally_button);
            this.Controls.Add(this.cameraName_label);
            this.Controls.Add(this.remove_button);
            this.Controls.Add(this.videoSourcePlayer);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(450, 260);
            this.Name = "CameraSettingsPanel";
            this.Size = new System.Drawing.Size(456, 260);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button remove_button;
        private Label cameraName_label;
        private Button expandHorizontally_button;
        private Button expandVertically_button;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer;
    }
}
