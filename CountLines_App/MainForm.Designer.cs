
namespace CountLines_App
{
    partial class MainForm
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
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.chooseScriptsFolder = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.TextBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.folderPathLabel = new System.Windows.Forms.Label();
            this.LanguageComboBox = new System.Windows.Forms.ComboBox();
            this.clearLogBox = new System.Windows.Forms.CheckBox();
            this.extentionInputField = new System.Windows.Forms.TextBox();
            this.AddExclusionFolders = new System.Windows.Forms.Button();
            this.AddExclusionScripts = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DisplayExclusions = new System.Windows.Forms.Button();
            this.DeleteExclusions = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chooseScriptsFolder
            // 
            this.chooseScriptsFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chooseScriptsFolder.ForeColor = System.Drawing.Color.White;
            this.chooseScriptsFolder.Location = new System.Drawing.Point(232, 267);
            this.chooseScriptsFolder.Name = "chooseScriptsFolder";
            this.chooseScriptsFolder.Size = new System.Drawing.Size(128, 31);
            this.chooseScriptsFolder.TabIndex = 0;
            this.chooseScriptsFolder.Text = "Scripts Root Folder";
            this.chooseScriptsFolder.UseVisualStyleBackColor = false;
            this.chooseScriptsFolder.Click += new System.EventHandler(this.Choose_Scripts_Folder_Click);
            // 
            // Log
            // 
            this.Log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Log.ForeColor = System.Drawing.Color.White;
            this.Log.Location = new System.Drawing.Point(4, 32);
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Log.Size = new System.Drawing.Size(620, 187);
            this.Log.TabIndex = 2;
            // 
            // RunButton
            // 
            this.RunButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RunButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RunButton.ForeColor = System.Drawing.Color.White;
            this.RunButton.Location = new System.Drawing.Point(4, 236);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(140, 57);
            this.RunButton.TabIndex = 3;
            this.RunButton.Text = "Count";
            this.RunButton.UseVisualStyleBackColor = false;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // folderPathLabel
            // 
            this.folderPathLabel.AutoSize = true;
            this.folderPathLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.folderPathLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.folderPathLabel.Location = new System.Drawing.Point(4, 9);
            this.folderPathLabel.Name = "folderPathLabel";
            this.folderPathLabel.Size = new System.Drawing.Size(136, 20);
            this.folderPathLabel.TabIndex = 4;
            this.folderPathLabel.Text = "No folder selected!";
            // 
            // LanguageComboBox
            // 
            this.LanguageComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LanguageComboBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LanguageComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.LanguageComboBox.Items.AddRange(new object[] {
            "C#",
            "Java",
            "Python",
            "C++",
            "JS"});
            this.LanguageComboBox.Location = new System.Drawing.Point(150, 233);
            this.LanguageComboBox.Name = "LanguageComboBox";
            this.LanguageComboBox.Size = new System.Drawing.Size(76, 28);
            this.LanguageComboBox.TabIndex = 5;
            this.LanguageComboBox.Text = "C#";
            // 
            // clearLogBox
            // 
            this.clearLogBox.AutoSize = true;
            this.clearLogBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.clearLogBox.Checked = true;
            this.clearLogBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.clearLogBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearLogBox.ForeColor = System.Drawing.Color.White;
            this.clearLogBox.Location = new System.Drawing.Point(150, 274);
            this.clearLogBox.Name = "clearLogBox";
            this.clearLogBox.Size = new System.Drawing.Size(75, 19);
            this.clearLogBox.TabIndex = 6;
            this.clearLogBox.Text = "Clear Log";
            this.clearLogBox.UseVisualStyleBackColor = false;
            // 
            // extentionInputField
            // 
            this.extentionInputField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.extentionInputField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.extentionInputField.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.extentionInputField.ForeColor = System.Drawing.Color.White;
            this.extentionInputField.Location = new System.Drawing.Point(232, 237);
            this.extentionInputField.Name = "extentionInputField";
            this.extentionInputField.Size = new System.Drawing.Size(128, 23);
            this.extentionInputField.TabIndex = 7;
            this.extentionInputField.Click += new System.EventHandler(this.extentionInputField_Click);
            // 
            // AddExclusionFolders
            // 
            this.AddExclusionFolders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddExclusionFolders.ForeColor = System.Drawing.Color.White;
            this.AddExclusionFolders.Location = new System.Drawing.Point(72, 33);
            this.AddExclusionFolders.Name = "AddExclusionFolders";
            this.AddExclusionFolders.Size = new System.Drawing.Size(66, 31);
            this.AddExclusionFolders.TabIndex = 8;
            this.AddExclusionFolders.Text = "Folders";
            this.AddExclusionFolders.UseVisualStyleBackColor = false;
            this.AddExclusionFolders.Click += new System.EventHandler(this.AddExclusionFolders_Click);
            // 
            // AddExclusionScripts
            // 
            this.AddExclusionScripts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddExclusionScripts.ForeColor = System.Drawing.Color.White;
            this.AddExclusionScripts.Location = new System.Drawing.Point(0, 33);
            this.AddExclusionScripts.Name = "AddExclusionScripts";
            this.AddExclusionScripts.Size = new System.Drawing.Size(66, 31);
            this.AddExclusionScripts.TabIndex = 9;
            this.AddExclusionScripts.Text = "Scripts";
            this.AddExclusionScripts.UseVisualStyleBackColor = false;
            this.AddExclusionScripts.Click += new System.EventHandler(this.AddExclusionFiles_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.DisplayExclusions);
            this.panel1.Controls.Add(this.DeleteExclusions);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AddExclusionScripts);
            this.panel1.Controls.Add(this.AddExclusionFolders);
            this.panel1.Location = new System.Drawing.Point(413, 233);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 65);
            this.panel1.TabIndex = 10;
            // 
            // DisplayExclusions
            // 
            this.DisplayExclusions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DisplayExclusions.ForeColor = System.Drawing.Color.White;
            this.DisplayExclusions.Location = new System.Drawing.Point(144, 0);
            this.DisplayExclusions.Name = "DisplayExclusions";
            this.DisplayExclusions.Size = new System.Drawing.Size(66, 31);
            this.DisplayExclusions.TabIndex = 12;
            this.DisplayExclusions.Text = "Display";
            this.DisplayExclusions.UseVisualStyleBackColor = false;
            this.DisplayExclusions.Click += new System.EventHandler(this.DisplayExclusions_Click);
            // 
            // DeleteExclusions
            // 
            this.DeleteExclusions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DeleteExclusions.ForeColor = System.Drawing.Color.White;
            this.DeleteExclusions.Location = new System.Drawing.Point(144, 33);
            this.DeleteExclusions.Name = "DeleteExclusions";
            this.DeleteExclusions.Size = new System.Drawing.Size(66, 31);
            this.DeleteExclusions.TabIndex = 11;
            this.DeleteExclusions.Text = "DeleteAll";
            this.DeleteExclusions.UseVisualStyleBackColor = false;
            this.DeleteExclusions.Click += new System.EventHandler(this.DeleteExclusions_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(0, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Exclusions!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(627, 305);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.extentionInputField);
            this.Controls.Add(this.clearLogBox);
            this.Controls.Add(this.LanguageComboBox);
            this.Controls.Add(this.folderPathLabel);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.chooseScriptsFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Count Lines App";
            this.Click += new System.EventHandler(this.MainForm_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button chooseScriptsFolder;
        private System.Windows.Forms.TextBox Log;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Label folderPathLabel;
        private System.Windows.Forms.ComboBox LanguageComboBox;
        private System.Windows.Forms.CheckBox clearLogBox;
        private System.Windows.Forms.TextBox extentionInputField;
        private System.Windows.Forms.Button AddExclusionFolders;
        private System.Windows.Forms.Button AddExclusionScripts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DisplayExclusions;
        private System.Windows.Forms.Button DeleteExclusions;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

