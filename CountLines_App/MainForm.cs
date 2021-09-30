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
        private const string extentionInputFieldPlaceholder = "Input extention here!";

        public MainForm()
        {
            InitializeComponent();

            counterModule = new CounterModule(this);

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
                MessageBox.Show("Please, choose scripts folder!");
                return;
            }

            if (clearLogBox.Checked) ClearLogInfo();

            counterModule.CountLines((Languages)LanguageComboBox.SelectedIndex, rootFolderPath);
        }

        public void ShowMessageBox(string info)
        {
            MessageBox.Show(info);
        }

        public void AppendLogInfo(string info)
        {
            Log.Text += info;
        }

        public void ClearLogInfo()
        {
            Log.Text = "";
        }

        private void extentionInputField_Enter(object sender, EventArgs e)
        {
            if (extentionInputField.Text == extentionInputFieldPlaceholder)
            {
                extentionInputField.Text = string.Empty;
                LanguageComboBox.Visible = false;
            }
        }

        private void extentionInputField_Leave(object sender, EventArgs e)
        {
            if (extentionInputField.Text == string.Empty)
            {
                extentionInputField.Text = extentionInputFieldPlaceholder;
                LanguageComboBox.Visible = true;
            }
        }
    }
}
