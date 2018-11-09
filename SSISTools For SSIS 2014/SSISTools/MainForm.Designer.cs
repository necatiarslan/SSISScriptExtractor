namespace SSISTools
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ShowOnlyScriptTasksCheckBox = new System.Windows.Forms.CheckBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colTask = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIsScriptTask = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colConnection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SaveFileToNearCheckBox = new System.Windows.Forms.CheckBox();
            this.btnPreviewSql = new System.Windows.Forms.Button();
            this.btnSaveScriptFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPaclageFileSelect = new System.Windows.Forms.Button();
            this.txtSsisPackageFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SaveAllFilesToNearCheckBox = new System.Windows.Forms.CheckBox();
            this.btnDestFolderSelect = new System.Windows.Forms.Button();
            this.txtDestFolder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPackageListScriptSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lstPackageList = new System.Windows.Forms.ListBox();
            this.btnSourcePathSelect = new System.Windows.Forms.Button();
            this.txtSourceFolder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 633);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ShowOnlyScriptTasksCheckBox);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.SaveFileToNearCheckBox);
            this.tabPage1.Controls.Add(this.btnPreviewSql);
            this.tabPage1.Controls.Add(this.btnSaveScriptFile);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnPaclageFileSelect);
            this.tabPage1.Controls.Add(this.txtSsisPackageFile);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 607);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Script Extract";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ShowOnlyScriptTasksCheckBox
            // 
            this.ShowOnlyScriptTasksCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ShowOnlyScriptTasksCheckBox.AutoSize = true;
            this.ShowOnlyScriptTasksCheckBox.Checked = true;
            this.ShowOnlyScriptTasksCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowOnlyScriptTasksCheckBox.Location = new System.Drawing.Point(396, 582);
            this.ShowOnlyScriptTasksCheckBox.Name = "ShowOnlyScriptTasksCheckBox";
            this.ShowOnlyScriptTasksCheckBox.Size = new System.Drawing.Size(139, 17);
            this.ShowOnlyScriptTasksCheckBox.TabIndex = 9;
            this.ShowOnlyScriptTasksCheckBox.Text = "Show Only Script Tasks";
            this.ShowOnlyScriptTasksCheckBox.UseVisualStyleBackColor = true;
            this.ShowOnlyScriptTasksCheckBox.CheckedChanged += new System.EventHandler(this.ShowOnlyScriptTasksCheckBox_CheckedChanged);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTask,
            this.colIsScriptTask,
            this.colConnection});
            this.listView1.Location = new System.Drawing.Point(100, 142);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(661, 405);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick_1);
            // 
            // colTask
            // 
            this.colTask.Text = "Task";
            this.colTask.Width = 265;
            // 
            // colIsScriptTask
            // 
            this.colIsScriptTask.Text = "Script Task";
            this.colIsScriptTask.Width = 141;
            // 
            // colConnection
            // 
            this.colConnection.Text = "Connection";
            this.colConnection.Width = 151;
            // 
            // SaveFileToNearCheckBox
            // 
            this.SaveFileToNearCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveFileToNearCheckBox.AutoSize = true;
            this.SaveFileToNearCheckBox.Checked = true;
            this.SaveFileToNearCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SaveFileToNearCheckBox.Location = new System.Drawing.Point(396, 559);
            this.SaveFileToNearCheckBox.Name = "SaveFileToNearCheckBox";
            this.SaveFileToNearCheckBox.Size = new System.Drawing.Size(158, 17);
            this.SaveFileToNearCheckBox.TabIndex = 7;
            this.SaveFileToNearCheckBox.Text = "Save File To Near Package";
            this.SaveFileToNearCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnPreviewSql
            // 
            this.btnPreviewSql.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPreviewSql.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPreviewSql.ForeColor = System.Drawing.Color.Crimson;
            this.btnPreviewSql.Location = new System.Drawing.Point(248, 553);
            this.btnPreviewSql.Name = "btnPreviewSql";
            this.btnPreviewSql.Size = new System.Drawing.Size(142, 48);
            this.btnPreviewSql.TabIndex = 6;
            this.btnPreviewSql.Text = "Preview Script";
            this.btnPreviewSql.UseVisualStyleBackColor = true;
            this.btnPreviewSql.Click += new System.EventHandler(this.btnPreviewSql_Click);
            // 
            // btnSaveScriptFile
            // 
            this.btnSaveScriptFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveScriptFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaveScriptFile.ForeColor = System.Drawing.Color.Crimson;
            this.btnSaveScriptFile.Location = new System.Drawing.Point(100, 553);
            this.btnSaveScriptFile.Name = "btnSaveScriptFile";
            this.btnSaveScriptFile.Size = new System.Drawing.Size(142, 48);
            this.btnSaveScriptFile.TabIndex = 5;
            this.btnSaveScriptFile.Text = "Save Script";
            this.btnSaveScriptFile.UseVisualStyleBackColor = true;
            this.btnSaveScriptFile.Click += new System.EventHandler(this.btnSaveScriptFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Script Tasks";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnPaclageFileSelect
            // 
            this.btnPaclageFileSelect.Location = new System.Drawing.Point(100, 101);
            this.btnPaclageFileSelect.Name = "btnPaclageFileSelect";
            this.btnPaclageFileSelect.Size = new System.Drawing.Size(92, 23);
            this.btnPaclageFileSelect.TabIndex = 2;
            this.btnPaclageFileSelect.Text = "Package Select";
            this.btnPaclageFileSelect.UseVisualStyleBackColor = true;
            this.btnPaclageFileSelect.Click += new System.EventHandler(this.btnPaclageFileSelect_Click);
            // 
            // txtSsisPackageFile
            // 
            this.txtSsisPackageFile.AllowDrop = true;
            this.txtSsisPackageFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSsisPackageFile.Location = new System.Drawing.Point(100, 16);
            this.txtSsisPackageFile.Multiline = true;
            this.txtSsisPackageFile.Name = "txtSsisPackageFile";
            this.txtSsisPackageFile.ReadOnly = true;
            this.txtSsisPackageFile.Size = new System.Drawing.Size(661, 79);
            this.txtSsisPackageFile.TabIndex = 1;
            this.txtSsisPackageFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtSsisPackageFile_DragDrop);
            this.txtSsisPackageFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtSsisPackageFile_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SSIS Package";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SaveAllFilesToNearCheckBox);
            this.tabPage2.Controls.Add(this.btnDestFolderSelect);
            this.tabPage2.Controls.Add(this.txtDestFolder);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btnPackageListScriptSave);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.lstPackageList);
            this.tabPage2.Controls.Add(this.btnSourcePathSelect);
            this.tabPage2.Controls.Add(this.txtSourceFolder);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 607);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Folder Search";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SaveAllFilesToNearCheckBox
            // 
            this.SaveAllFilesToNearCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveAllFilesToNearCheckBox.AutoSize = true;
            this.SaveAllFilesToNearCheckBox.Location = new System.Drawing.Point(100, 524);
            this.SaveAllFilesToNearCheckBox.Name = "SaveAllFilesToNearCheckBox";
            this.SaveAllFilesToNearCheckBox.Size = new System.Drawing.Size(349, 17);
            this.SaveAllFilesToNearCheckBox.TabIndex = 12;
            this.SaveAllFilesToNearCheckBox.Text = "Save Files To Near Packages         (else save all files to Dest Folder)\r\n";
            this.SaveAllFilesToNearCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnDestFolderSelect
            // 
            this.btnDestFolderSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDestFolderSelect.Location = new System.Drawing.Point(658, 496);
            this.btnDestFolderSelect.Name = "btnDestFolderSelect";
            this.btnDestFolderSelect.Size = new System.Drawing.Size(103, 23);
            this.btnDestFolderSelect.TabIndex = 11;
            this.btnDestFolderSelect.Text = "Folder Select";
            this.btnDestFolderSelect.UseVisualStyleBackColor = true;
            this.btnDestFolderSelect.Click += new System.EventHandler(this.btnDestFolderSelect_Click);
            // 
            // txtDestFolder
            // 
            this.txtDestFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestFolder.Location = new System.Drawing.Point(100, 498);
            this.txtDestFolder.Name = "txtDestFolder";
            this.txtDestFolder.ReadOnly = true;
            this.txtDestFolder.Size = new System.Drawing.Size(552, 20);
            this.txtDestFolder.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 501);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dest Folder";
            // 
            // btnPackageListScriptSave
            // 
            this.btnPackageListScriptSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPackageListScriptSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPackageListScriptSave.ForeColor = System.Drawing.Color.Crimson;
            this.btnPackageListScriptSave.Location = new System.Drawing.Point(100, 553);
            this.btnPackageListScriptSave.Name = "btnPackageListScriptSave";
            this.btnPackageListScriptSave.Size = new System.Drawing.Size(142, 48);
            this.btnPackageListScriptSave.TabIndex = 8;
            this.btnPackageListScriptSave.Text = "Save Script";
            this.btnPackageListScriptSave.UseVisualStyleBackColor = true;
            this.btnPackageListScriptSave.Click += new System.EventHandler(this.btnPackageListScriptSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Packages";
            // 
            // lstPackageList
            // 
            this.lstPackageList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPackageList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstPackageList.FormattingEnabled = true;
            this.lstPackageList.ItemHeight = 20;
            this.lstPackageList.Location = new System.Drawing.Point(100, 71);
            this.lstPackageList.Name = "lstPackageList";
            this.lstPackageList.Size = new System.Drawing.Size(661, 424);
            this.lstPackageList.TabIndex = 6;
            this.lstPackageList.DoubleClick += new System.EventHandler(this.lstPackageList_DoubleClick);
            // 
            // btnSourcePathSelect
            // 
            this.btnSourcePathSelect.Location = new System.Drawing.Point(100, 42);
            this.btnSourcePathSelect.Name = "btnSourcePathSelect";
            this.btnSourcePathSelect.Size = new System.Drawing.Size(103, 23);
            this.btnSourcePathSelect.TabIndex = 5;
            this.btnSourcePathSelect.Text = "Folder Select";
            this.btnSourcePathSelect.UseVisualStyleBackColor = true;
            this.btnSourcePathSelect.Click += new System.EventHandler(this.btnPathSelect_Click);
            // 
            // txtSourceFolder
            // 
            this.txtSourceFolder.AllowDrop = true;
            this.txtSourceFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourceFolder.Location = new System.Drawing.Point(100, 16);
            this.txtSourceFolder.Name = "txtSourceFolder";
            this.txtSourceFolder.ReadOnly = true;
            this.txtSourceFolder.Size = new System.Drawing.Size(661, 20);
            this.txtSourceFolder.TabIndex = 4;
            this.txtSourceFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtSourceFolder_DragDrop);
            this.txtSourceFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtSourceFolder_DragEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Folder";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 657);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "SSIS Script Extractor For SSIS 2014";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSaveScriptFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPaclageFileSelect;
        private System.Windows.Forms.TextBox txtSsisPackageFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSourcePathSelect;
        private System.Windows.Forms.TextBox txtSourceFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDestFolderSelect;
        private System.Windows.Forms.TextBox txtDestFolder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPackageListScriptSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstPackageList;
        private System.Windows.Forms.Button btnPreviewSql;
        private System.Windows.Forms.CheckBox SaveFileToNearCheckBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colTask;
        private System.Windows.Forms.ColumnHeader colIsScriptTask;
        private System.Windows.Forms.ColumnHeader colConnection;
        private System.Windows.Forms.CheckBox ShowOnlyScriptTasksCheckBox;
        private System.Windows.Forms.CheckBox SaveAllFilesToNearCheckBox;
    }
}

