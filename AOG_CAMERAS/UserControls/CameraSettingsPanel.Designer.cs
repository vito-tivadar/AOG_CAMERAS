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
            this.previewCheckbox = new System.Windows.Forms.CheckBox();
            this.cameraSelectDropdown = new System.Windows.Forms.ComboBox();
            this.videoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.expandHorizontally_button = new System.Windows.Forms.Label();
            this.expandVertically_button = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // previewCheckbox
            // 
            this.previewCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.previewCheckbox.Appearance = System.Windows.Forms.Appearance.Button;
            this.previewCheckbox.Location = new System.Drawing.Point(334, 3);
            this.previewCheckbox.Name = "previewCheckbox";
            this.previewCheckbox.Size = new System.Drawing.Size(104, 30);
            this.previewCheckbox.TabIndex = 0;
            this.previewCheckbox.Text = "Preview";
            this.previewCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.previewCheckbox.UseVisualStyleBackColor = true;
            this.previewCheckbox.CheckedChanged += new System.EventHandler(this.previewCheckbox_CheckedChanged);
            // 
            // cameraSelectDropdown
            // 
            this.cameraSelectDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cameraSelectDropdown.FormattingEnabled = true;
            this.cameraSelectDropdown.Location = new System.Drawing.Point(3, 3);
            this.cameraSelectDropdown.MinimumSize = new System.Drawing.Size(325, 0);
            this.cameraSelectDropdown.Name = "cameraSelectDropdown";
            this.cameraSelectDropdown.Size = new System.Drawing.Size(325, 29);
            this.cameraSelectDropdown.TabIndex = 2;
            this.cameraSelectDropdown.SelectedIndexChanged += new System.EventHandler(this.controller.onComboboxUpdated);
            // 
            // videoSourcePlayer
            // 
            this.videoSourcePlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoSourcePlayer.Location = new System.Drawing.Point(3, 82);
            this.videoSourcePlayer.MinimumSize = new System.Drawing.Size(0, 200);
            this.videoSourcePlayer.Name = "videoSourcePlayer";
            this.videoSourcePlayer.Size = new System.Drawing.Size(435, 200);
            this.videoSourcePlayer.TabIndex = 1;
            this.videoSourcePlayer.VideoSource = null;
            // 
            // expandHorizontally_button
            // 
            this.expandHorizontally_button.BackColor = System.Drawing.SystemColors.Control;
            this.expandHorizontally_button.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expandHorizontally_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expandHorizontally_button.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.expandHorizontally_button.Location = new System.Drawing.Point(3, 0);
            this.expandHorizontally_button.Name = "expandHorizontally_button";
            this.expandHorizontally_button.Size = new System.Drawing.Size(211, 38);
            this.expandHorizontally_button.TabIndex = 5;
            this.expandHorizontally_button.Text = "Expand horizontally";
            this.expandHorizontally_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.expandHorizontally_button.Click += new System.EventHandler(this.expandHorizontally_button_Click);
            // 
            // expandVertically_button
            // 
            this.expandVertically_button.BackColor = System.Drawing.SystemColors.Control;
            this.expandVertically_button.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expandVertically_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expandVertically_button.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.expandVertically_button.Location = new System.Drawing.Point(220, 0);
            this.expandVertically_button.Name = "expandVertically_button";
            this.expandVertically_button.Size = new System.Drawing.Size(212, 38);
            this.expandVertically_button.TabIndex = 6;
            this.expandVertically_button.Text = "Expand vertically";
            this.expandVertically_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.expandVertically_button.Click += new System.EventHandler(this.expandVertically_button_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.expandHorizontally_button, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.expandVertically_button, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(435, 38);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // CameraSettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.cameraSelectDropdown);
            this.Controls.Add(this.videoSourcePlayer);
            this.Controls.Add(this.previewCheckbox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CameraSettingsPanel";
            this.Size = new System.Drawing.Size(441, 284);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox previewCheckbox;
        private ComboBox cameraSelectDropdown;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer;
        private Label expandHorizontally_button;
        private Label expandVertically_button;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
