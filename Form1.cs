﻿using System;
using System.IO;
using System.Windows.Forms;

namespace BuildZipGenGUI
{
    public partial class Form1 : Form
    {
        string outputPath;
        string projectName;

        public Form1()
        {
            InitializeComponent();
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
    }
}
