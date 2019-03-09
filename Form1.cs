using System;
using System.IO;
using System.Windows.Forms;

namespace BuildZipGenGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
                return;
            }

            if (string.IsNullOrEmpty(folderLocText.Text))
            {
                MessageBox.Show("Folder location must be set!", "Error generating",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Directory.Exists(folderLocText.Text))
            {
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
        }
    }
}
