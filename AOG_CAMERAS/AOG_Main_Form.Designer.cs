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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addProfile_button = new System.Windows.Forms.ToolStripMenuItem();
            this.profileDropDownMenu = new System.Windows.Forms.ToolStripComboBox();
            this.profileNameTextBox = new System.Windows.Forms.TextBox();
            this.camerasGridPanel = new System.Windows.Forms.TableLayoutPanel();
            this.deleteProfile_button = new System.Windows.Forms.Label();
            this.saveProfile_button = new System.Windows.Forms.Label();
            this.addCamera_button = new System.Windows.Forms.Label();
            this.combineVertically_button = new System.Windows.Forms.Label();
            this.cameraSelectCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // profileNameTextBox
            // 
            this.profileNameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.profileNameTextBox.Location = new System.Drawing.Point(9, 45);
            this.profileNameTextBox.Name = "profileNameTextBox";
            this.profileNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.profileNameTextBox.Size = new System.Drawing.Size(360, 23);
            this.profileNameTextBox.TabIndex = 0;
            this.profileNameTextBox.TextChanged += new System.EventHandler(this.profileNameTextBox_TextChanged);
            // 
            // camerasGridPanel
            // 
            this.camerasGridPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.camerasGridPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.camerasGridPanel.ColumnCount = 2;
            this.camerasGridPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.camerasGridPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.camerasGridPanel.Location = new System.Drawing.Point(9, 77);
            this.camerasGridPanel.Margin = new System.Windows.Forms.Padding(0);
            this.camerasGridPanel.Name = "camerasGridPanel";
            this.camerasGridPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.camerasGridPanel.RowCount = 2;
            this.camerasGridPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.camerasGridPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.camerasGridPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.camerasGridPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.camerasGridPanel.Size = new System.Drawing.Size(1346, 615);
            this.camerasGridPanel.TabIndex = 4;
            this.camerasGridPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.camerasPanelSettings_ControlAdded);
            // 
            // deleteProfile_button
            // 
            this.deleteProfile_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteProfile_button.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deleteProfile_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteProfile_button.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteProfile_button.Location = new System.Drawing.Point(9, 695);
            this.deleteProfile_button.Name = "deleteProfile_button";
            this.deleteProfile_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.deleteProfile_button.Size = new System.Drawing.Size(150, 35);
            this.deleteProfile_button.TabIndex = 6;
            this.deleteProfile_button.Text = "Delete Profile";
            this.deleteProfile_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveProfile_button
            // 
            this.saveProfile_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveProfile_button.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saveProfile_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveProfile_button.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveProfile_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveProfile_button.Location = new System.Drawing.Point(1205, 695);
            this.saveProfile_button.Name = "saveProfile_button";
            this.saveProfile_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.saveProfile_button.Size = new System.Drawing.Size(150, 35);
            this.saveProfile_button.TabIndex = 5;
            this.saveProfile_button.Text = "Save Profile";
            this.saveProfile_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveProfile_button.Click += new System.EventHandler(this.saveProfile_button_Click);
            // 
            // addCamera_button
            // 
            this.addCamera_button.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addCamera_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCamera_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addCamera_button.Location = new System.Drawing.Point(674, 45);
            this.addCamera_button.Name = "addCamera_button";
            this.addCamera_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addCamera_button.Size = new System.Drawing.Size(150, 23);
            this.addCamera_button.TabIndex = 7;
            this.addCamera_button.Text = "Add Camera";
            this.addCamera_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addCamera_button.Click += new System.EventHandler(this.addCamera_button_Click);
            // 
            // combineVertically_button
            // 
            this.combineVertically_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combineVertically_button.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.combineVertically_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combineVertically_button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.combineVertically_button.Location = new System.Drawing.Point(1205, 45);
            this.combineVertically_button.Name = "combineVertically_button";
            this.combineVertically_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.combineVertically_button.Size = new System.Drawing.Size(150, 25);
            this.combineVertically_button.TabIndex = 8;
            this.combineVertically_button.Text = "Combine Vertically";
            this.combineVertically_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.combineVertically_button.Click += new System.EventHandler(this.combineVertically_button_Click);
            // 
            // cameraSelectCombobox
            // 
            this.cameraSelectCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cameraSelectCombobox.FormattingEnabled = true;
            this.cameraSelectCombobox.Location = new System.Drawing.Point(375, 45);
            this.cameraSelectCombobox.Name = "cameraSelectCombobox";
            this.cameraSelectCombobox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cameraSelectCombobox.Size = new System.Drawing.Size(293, 23);
            this.cameraSelectCombobox.TabIndex = 10;
            this.cameraSelectCombobox.SelectedIndexChanged += new System.EventHandler(this.cameraSelectCombobox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Profile name :";
            // 
            // AOG_CAMERAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1364, 739);
            this.Controls.Add(this.saveProfile_button);
            this.Controls.Add(this.deleteProfile_button);
            this.Controls.Add(this.cameraSelectCombobox);
            this.Controls.Add(this.camerasGridPanel);
            this.Controls.Add(this.combineVertically_button);
            this.Controls.Add(this.addCamera_button);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.profileNameTextBox);
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ToolStripContainer toolStripContainer1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addProfile_button;
        private ToolStripComboBox profileDropDownMenu;
        private TextBox profileNameTextBox;
        private TableLayoutPanel camerasGridPanel;
        private Label deleteProfile_button;
        private Label saveProfile_button;
        private Label addCamera_button;
        private Label combineVertically_button;
        private ComboBox cameraSelectCombobox;
        private Label label1;
    }
}