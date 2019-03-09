namespace BuildZipGenGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.folderLocText = new System.Windows.Forms.TextBox();
            this.folderLocBrowse = new System.Windows.Forms.Button();
            this.projectNameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Build Zip Generator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Folder location:";
            // 
            // folderLocText
            // 
            this.folderLocText.Location = new System.Drawing.Point(110, 80);
            this.folderLocText.Name = "folderLocText";
            this.folderLocText.Size = new System.Drawing.Size(158, 20);
            this.folderLocText.TabIndex = 2;
            // 
            // folderLocBrowse
            // 
            this.folderLocBrowse.Location = new System.Drawing.Point(274, 79);
            this.folderLocBrowse.Name = "folderLocBrowse";
            this.folderLocBrowse.Size = new System.Drawing.Size(21, 23);
            this.folderLocBrowse.TabIndex = 3;
            this.folderLocBrowse.Text = "..";
            this.folderLocBrowse.UseVisualStyleBackColor = true;
            this.folderLocBrowse.Click += new System.EventHandler(this.FolderLocBrowse_Click);
            // 
            // projectNameText
            // 
            this.projectNameText.Location = new System.Drawing.Point(110, 54);
            this.projectNameText.Name = "projectNameText";
            this.projectNameText.Size = new System.Drawing.Size(158, 20);
            this.projectNameText.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Project name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 361);
            this.Controls.Add(this.projectNameText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.folderLocBrowse);
            this.Controls.Add(this.folderLocText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Build Zip Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox folderLocText;
        private System.Windows.Forms.Button folderLocBrowse;
        private System.Windows.Forms.TextBox projectNameText;
        private System.Windows.Forms.Label label3;
    }
}

