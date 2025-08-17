namespace CreateFileStructureFromDirListings
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_dirListingPath = new System.Windows.Forms.TextBox();
            this.label_dirListingPath = new System.Windows.Forms.Label();
            this.button_Create = new System.Windows.Forms.Button();
            this.label_fsPath = new System.Windows.Forms.Label();
            this.textBox_fsPath = new System.Windows.Forms.TextBox();
            this.checkBox_includeFiles = new System.Windows.Forms.CheckBox();
            this.checkBox_addFileSizeToName = new System.Windows.Forms.CheckBox();
            this.radioButton_fileSizeBeforeName = new System.Windows.Forms.RadioButton();
            this.radioButton_fileSizeAfterName = new System.Windows.Forms.RadioButton();
            this.groupBox_fileSize = new System.Windows.Forms.GroupBox();
            this.comboBox_sizeUnit = new System.Windows.Forms.ComboBox();
            this.label_sizeUnit = new System.Windows.Forms.Label();
            this.comboBox_invalidCharReplacement = new System.Windows.Forms.ComboBox();
            this.label_invalidCharReplacement = new System.Windows.Forms.Label();
            this.button_about = new System.Windows.Forms.Button();
            this.groupBox_fileSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_dirListingPath
            // 
            this.textBox_dirListingPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_dirListingPath.Location = new System.Drawing.Point(15, 25);
            this.textBox_dirListingPath.Name = "textBox_dirListingPath";
            this.textBox_dirListingPath.Size = new System.Drawing.Size(657, 20);
            this.textBox_dirListingPath.TabIndex = 0;
            // 
            // label_dirListingPath
            // 
            this.label_dirListingPath.AutoSize = true;
            this.label_dirListingPath.Location = new System.Drawing.Point(12, 9);
            this.label_dirListingPath.Name = "label_dirListingPath";
            this.label_dirListingPath.Size = new System.Drawing.Size(95, 13);
            this.label_dirListingPath.TabIndex = 1;
            this.label_dirListingPath.Text = "Path of dir listings: ";
            // 
            // button_Create
            // 
            this.button_Create.Location = new System.Drawing.Point(597, 226);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(75, 23);
            this.button_Create.TabIndex = 9;
            this.button_Create.Text = "Create";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // label_fsPath
            // 
            this.label_fsPath.AutoSize = true;
            this.label_fsPath.Location = new System.Drawing.Point(12, 58);
            this.label_fsPath.Name = "label_fsPath";
            this.label_fsPath.Size = new System.Drawing.Size(137, 13);
            this.label_fsPath.TabIndex = 1;
            this.label_fsPath.Text = "Path of output file structure:";
            // 
            // textBox_fsPath
            // 
            this.textBox_fsPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_fsPath.Location = new System.Drawing.Point(15, 74);
            this.textBox_fsPath.Name = "textBox_fsPath";
            this.textBox_fsPath.Size = new System.Drawing.Size(657, 20);
            this.textBox_fsPath.TabIndex = 1;
            // 
            // checkBox_includeFiles
            // 
            this.checkBox_includeFiles.AutoSize = true;
            this.checkBox_includeFiles.Checked = true;
            this.checkBox_includeFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_includeFiles.Location = new System.Drawing.Point(15, 114);
            this.checkBox_includeFiles.Name = "checkBox_includeFiles";
            this.checkBox_includeFiles.Size = new System.Drawing.Size(82, 17);
            this.checkBox_includeFiles.TabIndex = 2;
            this.checkBox_includeFiles.Text = "Include files";
            this.checkBox_includeFiles.UseVisualStyleBackColor = true;
            this.checkBox_includeFiles.CheckedChanged += new System.EventHandler(this.checkBox_includeFiles_CheckedChanged);
            // 
            // checkBox_addFileSizeToName
            // 
            this.checkBox_addFileSizeToName.AutoSize = true;
            this.checkBox_addFileSizeToName.Location = new System.Drawing.Point(6, 9);
            this.checkBox_addFileSizeToName.Name = "checkBox_addFileSizeToName";
            this.checkBox_addFileSizeToName.Size = new System.Drawing.Size(126, 17);
            this.checkBox_addFileSizeToName.TabIndex = 4;
            this.checkBox_addFileSizeToName.Text = "Add size to file name:";
            this.checkBox_addFileSizeToName.UseVisualStyleBackColor = true;
            this.checkBox_addFileSizeToName.CheckedChanged += new System.EventHandler(this.checkBox_addFileSizeToName_CheckedChanged);
            // 
            // radioButton_fileSizeBeforeName
            // 
            this.radioButton_fileSizeBeforeName.AutoSize = true;
            this.radioButton_fileSizeBeforeName.Enabled = false;
            this.radioButton_fileSizeBeforeName.Location = new System.Drawing.Point(6, 32);
            this.radioButton_fileSizeBeforeName.Name = "radioButton_fileSizeBeforeName";
            this.radioButton_fileSizeBeforeName.Size = new System.Drawing.Size(47, 17);
            this.radioButton_fileSizeBeforeName.TabIndex = 5;
            this.radioButton_fileSizeBeforeName.Text = "Start";
            this.radioButton_fileSizeBeforeName.UseVisualStyleBackColor = true;
            this.radioButton_fileSizeBeforeName.CheckedChanged += new System.EventHandler(this.radioButton_fileSizeBeforeName_CheckedChanged);
            // 
            // radioButton_fileSizeAfterName
            // 
            this.radioButton_fileSizeAfterName.AutoSize = true;
            this.radioButton_fileSizeAfterName.Checked = true;
            this.radioButton_fileSizeAfterName.Enabled = false;
            this.radioButton_fileSizeAfterName.Location = new System.Drawing.Point(6, 55);
            this.radioButton_fileSizeAfterName.Name = "radioButton_fileSizeAfterName";
            this.radioButton_fileSizeAfterName.Size = new System.Drawing.Size(44, 17);
            this.radioButton_fileSizeAfterName.TabIndex = 5;
            this.radioButton_fileSizeAfterName.TabStop = true;
            this.radioButton_fileSizeAfterName.Text = "End";
            this.radioButton_fileSizeAfterName.UseVisualStyleBackColor = true;
            this.radioButton_fileSizeAfterName.CheckedChanged += new System.EventHandler(this.radioButton_fileSizeAfterName_CheckedChanged);
            // 
            // groupBox_fileSize
            // 
            this.groupBox_fileSize.Controls.Add(this.checkBox_addFileSizeToName);
            this.groupBox_fileSize.Controls.Add(this.label_sizeUnit);
            this.groupBox_fileSize.Controls.Add(this.radioButton_fileSizeBeforeName);
            this.groupBox_fileSize.Controls.Add(this.radioButton_fileSizeAfterName);
            this.groupBox_fileSize.Controls.Add(this.comboBox_sizeUnit);
            this.groupBox_fileSize.Location = new System.Drawing.Point(103, 100);
            this.groupBox_fileSize.Name = "groupBox_fileSize";
            this.groupBox_fileSize.Size = new System.Drawing.Size(146, 136);
            this.groupBox_fileSize.TabIndex = 6;
            this.groupBox_fileSize.TabStop = false;
            // 
            // comboBox_sizeUnit
            // 
            this.comboBox_sizeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sizeUnit.Enabled = false;
            this.comboBox_sizeUnit.FormattingEnabled = true;
            this.comboBox_sizeUnit.Items.AddRange(new object[] {
            "bytes",
            "kB",
            "KiB"});
            this.comboBox_sizeUnit.Location = new System.Drawing.Point(5, 103);
            this.comboBox_sizeUnit.Name = "comboBox_sizeUnit";
            this.comboBox_sizeUnit.Size = new System.Drawing.Size(98, 21);
            this.comboBox_sizeUnit.TabIndex = 8;
            this.comboBox_sizeUnit.SelectedIndexChanged += new System.EventHandler(this.comboBox_sizeUnit_SelectedIndexChanged);
            // 
            // label_sizeUnit
            // 
            this.label_sizeUnit.AutoSize = true;
            this.label_sizeUnit.Enabled = false;
            this.label_sizeUnit.Location = new System.Drawing.Point(6, 84);
            this.label_sizeUnit.Name = "label_sizeUnit";
            this.label_sizeUnit.Size = new System.Drawing.Size(50, 13);
            this.label_sizeUnit.TabIndex = 9;
            this.label_sizeUnit.Text = "Size unit:";
            // 
            // comboBox_invalidCharReplacement
            // 
            this.comboBox_invalidCharReplacement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_invalidCharReplacement.FormattingEnabled = true;
            this.comboBox_invalidCharReplacement.Items.AddRange(new object[] {
            "#",
            "!",
            "$",
            "~",
            "_"});
            this.comboBox_invalidCharReplacement.Location = new System.Drawing.Point(258, 134);
            this.comboBox_invalidCharReplacement.Name = "comboBox_invalidCharReplacement";
            this.comboBox_invalidCharReplacement.Size = new System.Drawing.Size(98, 21);
            this.comboBox_invalidCharReplacement.TabIndex = 8;
            this.comboBox_invalidCharReplacement.SelectedIndexChanged += new System.EventHandler(this.comboBox_invalidCharReplacement_SelectedIndexChanged);
            // 
            // label_invalidCharReplacement
            // 
            this.label_invalidCharReplacement.AutoSize = true;
            this.label_invalidCharReplacement.Location = new System.Drawing.Point(255, 105);
            this.label_invalidCharReplacement.Name = "label_invalidCharReplacement";
            this.label_invalidCharReplacement.Size = new System.Drawing.Size(82, 26);
            this.label_invalidCharReplacement.TabIndex = 9;
            this.label_invalidCharReplacement.Text = "Replace invalid\r\ncharacters with:";
            // 
            // button_about
            // 
            this.button_about.Location = new System.Drawing.Point(516, 226);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(75, 23);
            this.button_about.TabIndex = 10;
            this.button_about.Text = "About...";
            this.button_about.UseVisualStyleBackColor = true;
            this.button_about.Click += new System.EventHandler(this.button_about_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button_Create;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 261);
            this.Controls.Add(this.button_about);
            this.Controls.Add(this.label_invalidCharReplacement);
            this.Controls.Add(this.comboBox_invalidCharReplacement);
            this.Controls.Add(this.groupBox_fileSize);
            this.Controls.Add(this.checkBox_includeFiles);
            this.Controls.Add(this.button_Create);
            this.Controls.Add(this.label_fsPath);
            this.Controls.Add(this.label_dirListingPath);
            this.Controls.Add(this.textBox_fsPath);
            this.Controls.Add(this.textBox_dirListingPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Structure Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_fileSize.ResumeLayout(false);
            this.groupBox_fileSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_dirListingPath;
        private System.Windows.Forms.Label label_dirListingPath;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.Label label_fsPath;
        private System.Windows.Forms.TextBox textBox_fsPath;
        private System.Windows.Forms.CheckBox checkBox_includeFiles;
        private System.Windows.Forms.CheckBox checkBox_addFileSizeToName;
        private System.Windows.Forms.RadioButton radioButton_fileSizeBeforeName;
        private System.Windows.Forms.RadioButton radioButton_fileSizeAfterName;
        private System.Windows.Forms.GroupBox groupBox_fileSize;
        private System.Windows.Forms.ComboBox comboBox_sizeUnit;
        private System.Windows.Forms.Label label_sizeUnit;
        private System.Windows.Forms.ComboBox comboBox_invalidCharReplacement;
        private System.Windows.Forms.Label label_invalidCharReplacement;
        private System.Windows.Forms.Button button_about;
    }
}

