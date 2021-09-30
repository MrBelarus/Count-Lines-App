using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountLines_App
{
    public partial class MainForm : Form
    {
        private string rootFolderPath = null;
        public string ExtentionInputFieldValue
        {
            get
            {
                return extentionInputField.Text == extentionInputFieldPlaceholder ? 
                    string.Empty : extentionInputField.Text;
            }
        }

        private CounterModule counterModule;
        private const string extentionInputFieldPlaceholder = "Input my extention!";
        private Point initExtInputFieldLocation;

        public MainForm()
        {
            InitializeComponent();

            counterModule = new CounterModule(this);

            initExtInputFieldLocation = extentionInputField.Location;
            extentionInputField_Leave(this, null);
        }

        private void Choose_Scripts_Folder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                rootFolderPath = folderBrowserDialog.SelectedPath;
                folderPathLabel.Text = rootFolderPath;
            }
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            if (rootFolderPath == null)
            {
                MessageBox.Show("Please, choose scripts root folder!");
                return;
            }

            counterModule.CountLines((Languages)LanguageComboBox.SelectedIndex, rootFolderPath);
        }

        public void ShowMessageBox(string info)
        {
            MessageBox.Show(info);
        }

        public void AppendLogInfo(string info)
        {
            if (clearLogBox.Checked) ClearLogInfo();

            if (Log.Text != "")
                Log.Text += Environment.NewLine;
            Log.Text += info;
        }

        public void ClearLogInfo()
        {
            Log.Text = "";
        }

        private void extentionInputField_Leave(object sender, EventArgs e)
        {
            if (extentionInputField.Text == string.Empty)
            {
                extentionInputField.Text = extentionInputFieldPlaceholder;
                extentionInputField.Location = initExtInputFieldLocation;
                LanguageComboBox.Visible = true;
            }
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            extentionInputField_Leave(this, e);
        }

        private void extentionInputField_Click(object sender, EventArgs e)
        {
            if (extentionInputField.Text == string.Empty)
            {
                extentionInputField_Leave(this, e);
                return;
            }

            if (extentionInputField.Text == extentionInputFieldPlaceholder)
            {
                extentionInputField.Text = string.Empty;
                extentionInputField.Location = new Point(LanguageComboBox.Location.X,
                                                         extentionInputField.Location.Y);
                LanguageComboBox.Visible = false;
            }
        }

        private void AddExclusionFolders_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string result = counterModule.AddFolderExclusion(folderBrowserDialog.SelectedPath);
                if (result == null)
                {
                    AppendLogInfo("Folder wasn't added! " +
                        $"{Environment.NewLine}It can be already in exclusions list or something went wrong");
                }
                else
                {
                    AppendLogInfo("Successfully added the following folder to exclusions: " +
                        $"{Environment.NewLine}{result}");
                }
            }
        }

        private void AddExclusionFiles_Click(object sender, EventArgs e)
        {
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] addedScripts = counterModule.AddFilesExclusion(openFileDialog.FileNames);
                if (addedScripts.Length == 0)
                {
                    AppendLogInfo("Files weren't added! " +
                        $"{Environment.NewLine}They can be already in exclusions list or something went wrong");
                }
                else
                {
                    StringBuilder info = new StringBuilder();
                    info.Append($"Successfully added the following files to exclusions: {Environment.NewLine}");
                    foreach (string script in addedScripts)
                    {
                        info.Append(script + $"{Environment.NewLine}");
                    }
                    AppendLogInfo(info.ToString());
                }
            }
            openFileDialog.Multiselect = false;
        }

        private void DeleteExclusions_Click(object sender, EventArgs e)
        {
            if (counterModule.ExclusionsCount > 0)
            {
                counterModule.RemoveAllExclusions();
                AppendLogInfo("All exclusions were removed successfully!");
            }
            else
            {
                AppendLogInfo("There is no exclusions!");
            }
        }

        private void DisplayExclusions_Click(object sender, EventArgs e)
        {
            if (counterModule.ExclusionsCount > 0)
            {
                string[] exclusionFiles = counterModule.ExclusionFiles;
                string[] exclusionFolders = counterModule.ExclusionFolders;

                StringBuilder stringBuilder = new StringBuilder();
                if (exclusionFiles.Length > 0)
                {
                    stringBuilder.Append($"Files exclusions: {Environment.NewLine}");
                    for (int i = 0; i < exclusionFiles.Length; i++)
                    {
                        stringBuilder.Append(exclusionFiles[i] + $"{Environment.NewLine}");
                    }
                }

                if (exclusionFolders.Length > 0)
                {
                    if (stringBuilder.Length > 0) stringBuilder.Append($"{Environment.NewLine}");
                    stringBuilder.Append($"Folder exclusions: {Environment.NewLine}");
                    for (int i = 0; i < exclusionFolders.Length; i++)
                    {
                        stringBuilder.Append(exclusionFolders[i] + $"{Environment.NewLine}");
                    }
                }

                AppendLogInfo(stringBuilder.ToString());
            }
            else
            {
                AppendLogInfo("There is no exclusions!");
            }
        }
    }
}
