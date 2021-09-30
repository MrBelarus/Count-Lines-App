using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CountLines_App
{
    public enum Languages
    {
        CSharp,
        Java,
        Python,
        CPlusPlus,
        JavaScript,
    }

    class CounterModule
    {
        private MainForm _mainForm;
        private List<FileInfo> _scriptFiles;
        private HashSet<string> _exclusionFolders;
        private HashSet<string> _exclusionFiles;
        private string _fileExtention = null;

        public int ExclusionsCount => _exclusionFolders.Count + _exclusionFiles.Count;
        public string[] ExclusionFolders
        {
            get
            {
                string[] result = new string[_exclusionFolders.Count];
                int i = 0;
                foreach (string exclusion in _exclusionFolders)
                {
                    result[i++] = exclusion;
                }
                return result;
            }
        }
        public string[] ExclusionFiles
        {
            get
            {
                string[] result = new string[_exclusionFiles.Count];
                int i = 0;
                foreach (string exclusion in _exclusionFiles)
                {
                    result[i++] = exclusion;
                }
                return result;
            }
        }

        private Languages _language;
        public Languages Language { get => _language; set => _language = value; }

        public CounterModule(MainForm mainForm)
        {
            _mainForm = mainForm;
            _scriptFiles = new List<FileInfo>();
            _exclusionFiles = new HashSet<string>();
            _exclusionFolders = new HashSet<string>();
        }

        public void CountLines(Languages language, string rootFolderPath)
        {
            if (_mainForm.ExtentionInputFieldValue != string.Empty)
            {
                _fileExtention = string.Concat("*", _mainForm.ExtentionInputFieldValue);
            }
            else
            {
                switch (language)
                {
                    case Languages.CSharp:
                        _fileExtention = "*.cs";
                        break;

                    case Languages.Java:
                        _fileExtention = "*.java";
                        break;

                    case Languages.Python:
                        _fileExtention = "*.py";
                        break;

                    case Languages.CPlusPlus:
                        _fileExtention = "*.cpp";
                        break;

                    case Languages.JavaScript:
                        _fileExtention = "*.js";
                        break;

                    default:
                        _mainForm.ShowMessageBox("Unsupported language!");
                        return;
                }
            }

            _mainForm.AppendLogInfo($"Search result: {Environment.NewLine}");
            _scriptFiles = new List<FileInfo>();

            FindScriptFiles(rootFolderPath, _fileExtention);

            if (_scriptFiles.Count == 0)
            {
                _mainForm.AppendLogInfo($"No {_fileExtention} files were found!{Environment.NewLine}");
                return;
            }

            int result = 0;

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"========{Environment.NewLine}**{_fileExtention} " +
                $"files**{Environment.NewLine}");

            foreach (FileInfo file in _scriptFiles)
            {
                result += File.ReadAllLines(file.FullName).Length;
                stringBuilder.Append(file.Name + Environment.NewLine);
            }

            stringBuilder.Append($"========{Environment.NewLine}" +
                $"Scripts Lines count = {result}{Environment.NewLine}");

            _mainForm.AppendLogInfo(stringBuilder.ToString());
            stringBuilder.Clear();
        }

        private void FindScriptFiles(string currentFolderPath, string extention = "*.cs")
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(currentFolderPath);

            if (_exclusionFolders.Contains(directoryInfo.FullName))
            {
                return;
            }

            foreach (FileInfo file in directoryInfo.GetFiles(extention))
            {
                if (!_exclusionFiles.Contains(file.FullName))
                {
                    _scriptFiles.Add(file);
                }
            }

            DirectoryInfo[] childDirectories = directoryInfo.GetDirectories();
            if (childDirectories.Length > 0)
            {
                foreach (DirectoryInfo directory in childDirectories)
                {
                    if (!_exclusionFolders.Contains(directory.FullName))
                    {
                        FindScriptFiles(directory.FullName, extention);
                    }
                }
            }
        }

        public string AddFilesExclusion(string fullPath)
        {
            if (_exclusionFiles.Add(fullPath))
            {
                return fullPath;
            }
            return null;
        }

        public string[] AddFilesExclusion(string[] scriptsFullPath)
        {
            List<string> successAddedScripts = new List<string>();
            for (int i = 0; i < scriptsFullPath.Length; i++)
            {
                if (_exclusionFiles.Add(scriptsFullPath[i]))
                {
                    successAddedScripts.Add(scriptsFullPath[i]);
                }
            }
            return successAddedScripts.ToArray();
        }

        public string RemoveScriptExclusion(string fullPath)
        {
            if (_exclusionFiles.Remove(fullPath))
            {
                return fullPath;
            }
            return null;
        }

        public string AddFolderExclusion(string fullPath)
        {
            if (_exclusionFolders.Add(fullPath))
            {
                return fullPath;
            }
            return null;
        }

        public string RemoveFolderExclusion(string fullPath)
        {
            if (_exclusionFolders.Remove(fullPath))
            {
                return fullPath;
            }
            return null;
        }

        public void RemoveAllExclusions()
        {
            _exclusionFolders.Clear();
            _exclusionFiles.Clear();
        }
    }
}
