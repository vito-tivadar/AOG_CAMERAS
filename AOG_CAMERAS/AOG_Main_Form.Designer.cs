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
            this.tab_settings = new System.Windows.Forms.TabPage();
            this.combineHorizontally_button = new System.Windows.Forms.Label();
            this.combineVertically_button = new System.Windows.Forms.Label();
            this.addCamera_button = new System.Windows.Forms.Label();
            this.saveProfile_button = new System.Windows.Forms.Label();
            this.deleteProfile_button = new System.Windows.Forms.Label();
            this.camerasPanelSettings = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.profileNameTextBox = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab_camera = new System.Windows.Forms.TabPage();
            this.camera_divider = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addProfile_button = new System.Windows.Forms.ToolStripMenuItem();
            this.profileDropDownMenu = new System.Windows.Forms.ToolStripComboBox();
            this.tab_settings.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tab_camera.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_settings
            // 
            this.tab_settings.BackColor = System.Drawing.SystemColors.Control;
            this.tab_settings.Controls.Add(this.combineHorizontally_button);
            this.tab_settings.Controls.Add(this.combineVertically_button);
            this.tab_settings.Controls.Add(this.addCamera_button);
            this.tab_settings.Controls.Add(this.saveProfile_button);
            this.tab_settings.Controls.Add(this.deleteProfile_button);
            this.tab_settings.Controls.Add(this.camerasPanelSettings);
            this.tab_settings.Controls.Add(this.label1);
            this.tab_settings.Controls.Add(this.profileNameTextBox);
            this.tab_settings.Location = new System.Drawing.Point(31, 4);
            this.tab_settings.Name = "tab_settings";
            this.tab_settings.Padding = new System.Windows.Forms.Padding(3);
            this.tab_settings.Size = new System.Drawing.Size(1329, 704);
            this.tab_settings.TabIndex = 1;
            this.tab_settings.Text = "Settings";
            // 
            // combineHorizontally_button
            // 
            this.combineHorizontally_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combineHorizontally_button.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.combineHorizontally_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combineHorizontally_button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.combineHorizontally_button.Location = new System.Drawing.Point(1171, 31);
            this.combineHorizontally_button.Name = "combineHorizontally_button";
            this.combineHorizontally_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.combineHorizontally_button.Size = new System.Drawing.Size(150, 25);
            this.combineHorizontally_button.TabIndex = 9;
            this.combineHorizontally_button.Text = "Combine Horizontally";
            this.combineHorizontally_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // combineVertically_button
            // 
            this.combineVertically_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combineVertically_button.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.combineVertically_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combineVertically_button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.combineVertically_button.Location = new System.Drawing.Point(1171, 3);
            this.combineVertically_button.Name = "combineVertically_button";
            this.combineVertically_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.combineVertically_button.Size = new System.Drawing.Size(150, 25);
            this.combineVertically_button.TabIndex = 8;
            this.combineVertically_button.Text = "Combine Vertically";
            this.combineVertically_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addCamera_button
            // 
            this.addCamera_button.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addCamera_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCamera_button.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addCamera_button.Location = new System.Drawing.Point(372, 27);
            this.addCamera_button.Name = "addCamera_button";
            this.addCamera_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addCamera_button.Size = new System.Drawing.Size(150, 29);
            this.addCamera_button.TabIndex = 7;
            this.addCamera_button.Text = "Add Camera";
            this.addCamera_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addCamera_button.Click += new System.EventHandler(this.addCamera_button_Click);
            // 
            // saveProfile_button
            // 
            this.saveProfile_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveProfile_button.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saveProfile_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveProfile_button.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveProfile_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveProfile_button.Location = new System.Drawing.Point(1171, 666);
            this.saveProfile_button.Name = "saveProfile_button";
            this.saveProfile_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.saveProfile_button.Size = new System.Drawing.Size(150, 35);
            this.saveProfile_button.TabIndex = 5;
            this.saveProfile_button.Text = "Save Profile";
            this.saveProfile_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveProfile_button.Click += new System.EventHandler(this.saveProfile_button_Click);
            // 
            // deleteProfile_button
            // 
            this.deleteProfile_button.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deleteProfile_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteProfile_button.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteProfile_button.Location = new System.Drawing.Point(6, 666);
            this.deleteProfile_button.Name = "deleteProfile_button";
            this.deleteProfile_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.deleteProfile_button.Size = new System.Drawing.Size(150, 35);
            this.deleteProfile_button.TabIndex = 6;
            this.deleteProfile_button.Text = "Delete Profile";
            this.deleteProfile_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteProfile_button.Click += new System.EventHandler(this.deleteProfile_button_Click);
            // 
            // camerasPanelSettings
            // 
            this.camerasPanelSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.camerasPanelSettings.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.camerasPanelSettings.ColumnCount = 2;
            this.camerasPanelSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.camerasPanelSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.camerasPanelSettings.Location = new System.Drawing.Point(6, 62);
            this.camerasPanelSettings.Margin = new System.Windows.Forms.Padding(0);
            this.camerasPanelSettings.Name = "camerasPanelSettings";
            this.camerasPanelSettings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.camerasPanelSettings.RowCount = 2;
            this.camerasPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.camerasPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.camerasPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.camerasPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.camerasPanelSettings.Size = new System.Drawing.Size(1315, 599);
            this.camerasPanelSettings.TabIndex = 4;
            this.camerasPanelSettings.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.camerasPanelSettings_ControlAdded);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Profile name :";
            // 
            // profileNameTextBox
            // 
            this.profileNameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.profileNameTextBox.Location = new System.Drawing.Point(6, 27);
            this.profileNameTextBox.Name = "profileNameTextBox";
            this.profileNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.profileNameTextBox.Size = new System.Drawing.Size(360, 29);
            this.profileNameTextBox.TabIndex = 0;
            this.profileNameTextBox.TextChanged += new System.EventHandler(this.profileNameTextBox_TextChanged);
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.CausesValidation = false;
            this.tabControl.Controls.Add(this.tab_camera);
            this.tabControl.Controls.Add(this.tab_settings);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl.HotTrack = true;
            this.tabControl.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tabControl.ItemSize = new System.Drawing.Size(135, 27);
            this.tabControl.Location = new System.Drawing.Point(0, 27);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1364, 712);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 1;
            // 
            // tab_camera
            // 
            this.tab_camera.AllowDrop = true;
            this.tab_camera.BackColor = System.Drawing.SystemColors.Control;
            this.tab_camera.Controls.Add(this.camera_divider);
            this.tab_camera.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tab_camera.Location = new System.Drawing.Point(31, 4);
            this.tab_camera.Name = "tab_camera";
            this.tab_camera.Padding = new System.Windows.Forms.Padding(3);
            this.tab_camera.Size = new System.Drawing.Size(1329, 704);
            this.tab_camera.TabIndex = 0;
            this.tab_camera.Text = "Camera  Stream";
            // 
            // camera_divider
            // 
            this.camera_divider.BackColor = System.Drawing.Color.Transparent;
            this.camera_divider.ColumnCount = 1;
            this.camera_divider.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.camera_divider.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.camera_divider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.camera_divider.ForeColor = System.Drawing.SystemColors.ControlText;
            this.camera_divider.Location = new System.Drawing.Point(3, 3);
            this.camera_divider.Name = "camera_divider";
            this.camera_divider.RowCount = 1;
            this.camera_divider.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.camera_divider.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.camera_divider.Size = new System.Drawing.Size(1323, 698);
            this.camera_divider.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProfile_button,
            this.profileDropDownMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1364, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addProfile_button
            // 
            this.addProfile_button.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.addProfile_button.Name = "addProfile_button";
            this.addProfile_button.Size = new System.Drawing.Size(78, 23);
            this.addProfile_button.Text = "Add Profile";
            this.addProfile_button.Click += new System.EventHandler(this.addProfile_button_Click);
            // 
            // profileDropDownMenu
            // 
            this.profileDropDownMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.profileDropDownMenu.BackColor = System.Drawing.SystemColors.Control;
            this.profileDropDownMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.profileDropDownMenu.DropDownWidth = 150;
            this.profileDropDownMenu.Margin = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.profileDropDownMenu.Name = "profileDropDownMenu";
            this.profileDropDownMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.profileDropDownMenu.Size = new System.Drawing.Size(250, 23);
            this.profileDropDownMenu.DropDownClosed += new System.EventHandler(this.profileDropDownMenu_DropDownClosed);
            // 
            // AOG_CAMERAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1364, 739);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.Location = new System.Drawing.Point(10, 10);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "AOG_CAMERAS";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AOG CAMERA STREAM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AOG_CAMERAS_FormClosing);
            this.Load += new System.EventHandler(this.AOG_CAMERAS_Load);
            this.Enter += new System.EventHandler(this.AOG_CAMERAS_Enter);
            this.Leave += new System.EventHandler(this.AOG_CAMERAS_Leave);
            this.tab_settings.ResumeLayout(false);
            this.tab_settings.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tab_camera.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ToolStripContainer toolStripContainer1;
        private TabPage tab_settings;
        private TabControl tabControl;
        private TabPage tab_camera;
        private TableLayoutPanel camera_divider;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addProfile_button;
        private ToolStripComboBox profileDropDownMenu;
        private TableLayoutPanel camerasPanelSettings;
        private Label label1;
        private TextBox profileNameTextBox;
        private Label saveProfile_button;
        private Label deleteProfile_button;
        private Label addCamera_button;
        private Label combineHorizontally_button;
        private Label combineVertically_button;
    }
}