
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
            this.SuspendLayout();
            // 
            // chooseScriptsFolder
            // 
            this.chooseScriptsFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chooseScriptsFolder.ForeColor = System.Drawing.Color.White;
            this.chooseScriptsFolder.Location = new System.Drawing.Point(285, 267);
            this.chooseScriptsFolder.Name = "chooseScriptsFolder";
            this.chooseScriptsFolder.Size = new System.Drawing.Size(140, 31);
            this.chooseScriptsFolder.TabIndex = 0;
            this.chooseScriptsFolder.Text = "Choose Scripts Folder";
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
            this.Log.Size = new System.Drawing.Size(644, 187);
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
            this.LanguageComboBox.Location = new System.Drawing.Point(285, 232);
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
            this.clearLogBox.Size = new System.Drawing.Size(129, 19);
            this.clearLogBox.TabIndex = 6;
            this.clearLogBox.Text = "Clear Log On Count";
            this.clearLogBox.UseVisualStyleBackColor = false;
            // 
            // extentionInputField
            // 
            this.extentionInputField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.extentionInputField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.extentionInputField.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.extentionInputField.ForeColor = System.Drawing.Color.White;
            this.extentionInputField.Location = new System.Drawing.Point(151, 236);
            this.extentionInputField.Name = "extentionInputField";
            this.extentionInputField.Size = new System.Drawing.Size(128, 23);
            this.extentionInputField.TabIndex = 7;
            this.extentionInputField.Enter += new System.EventHandler(this.extentionInputField_Enter);
            this.extentionInputField.Leave += new System.EventHandler(this.extentionInputField_Leave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(660, 305);
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
    }
}

