using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using Essy.Tools.InputBox;

namespace BuildZipGenGUI
{
    public partial class Form1 : Form
    {
        string outputPath;
        string projectName;

        public List<string> customPlatforms;

        public Form1()
        {
            InitializeComponent();
            customPlatforms = new List<string>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            projectNameText.Select();
            SetStatus("", System.Drawing.Color.Black);
        }

        private void FolderLocBrowse_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    folderLocText.Text = fbd.SelectedPath;
                }
            }
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(projectNameText.Text))
            {
                MessageBox.Show("Project name must not be empty!", "Error generating",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetStatus("Project name not specified", System.Drawing.Color.Red);
                return;
            }

            projectName = projectNameText.Text;

            if (string.IsNullOrEmpty(folderLocText.Text))
            {
                MessageBox.Show("Folder location must be set!", "Error generating",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetStatus("Output location not specified", System.Drawing.Color.Red);
                return;
            }

            if (!Directory.Exists(folderLocText.Text))
            {
                SetStatus("Output location doesn't exist", System.Drawing.Color.Gold);
                DialogResult dr = MessageBox.Show("Output location does not exist. Generate?", "Error generating",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    Directory.CreateDirectory(folderLocText.Text);
                } else
                {
                    return;
                }
            }

            outputPath = folderLocText.Text;

            if (genWinCheck.Checked)
                Generate("Windows");
            if (genLinuxCheck.Checked)
                Generate("Linux");
            if (genMacCheck.Checked)
                Generate("OSX");
            if (genWebGLCheck.Checked)
                Generate("WebGL");
            if (genAndroidCheck.Checked)
                Generate("Android");
            if (genCustomCheck.Checked)
            {
                foreach (string item in customPlatforms)
                    Generate(item);
            }

            SetStatus("Finished generation", System.Drawing.Color.Green);
        }

        void Generate(string platform)
        {
            outputPath = folderLocText.Text;
            Directory.CreateDirectory(outputPath += "/" + platform + "/");
            outputPath = folderLocText.Text;
            StreamWriter file = File.CreateText(outputPath + "/" + platform + "/Build.ps1");
            file.WriteLine("del " + projectName + "-" + platform + ".zip");
            file.WriteLine("Compress-Archive -Path ./* -DestinationPath ./" + projectName + "-" + platform + ".zip");
            file.Flush();
            file.Close();
        }

        void SetStatus(string msg, System.Drawing.Color color)
        {
            statusStripLabel.ForeColor = color;
            statusStripLabel.Text = msg;
        }

        private void AddCustomPlatform_Click(object sender, EventArgs e)
        {
            string customPlatform = InputBox.ShowInputBox("Input custom platform");
            if (customPlatform == null)
                return;
            customPlatformBox.Items.Add(customPlatform);
            customPlatforms.Add(customPlatform);
        }

        private void RemoveCustomPlatform_Click(object sender, EventArgs e)
        {
            if (customPlatformBox.SelectedIndex == -1)
            {
                SetStatus("No item selected when trying to remove platform", System.Drawing.Color.Red);
                MessageBox.Show("No item selected", "Error removing item",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else
            {
                string itemValue = (string)customPlatformBox.Items[customPlatformBox.SelectedIndex];
                int selectedIndex = customPlatformBox.SelectedIndex;
                customPlatformBox.Items.RemoveAt(selectedIndex);
                customPlatforms.RemoveAt(selectedIndex);
                SetStatus("Removed item: " + itemValue, System.Drawing.Color.Gold);
            }
        }
    }
}
