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
            this.label4 = new System.Windows.Forms.Label();
            this.genWinCheck = new System.Windows.Forms.CheckBox();
            this.genLinuxCheck = new System.Windows.Forms.CheckBox();
            this.genMacCheck = new System.Windows.Forms.CheckBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.genWebGLCheck = new System.Windows.Forms.CheckBox();
            this.genCustomCheck = new System.Windows.Forms.CheckBox();
            this.genAndroidCheck = new System.Windows.Forms.CheckBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip.SuspendLayout();
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "What should be be generated?";
            // 
            // genWinCheck
            // 
            this.genWinCheck.AutoSize = true;
            this.genWinCheck.Location = new System.Drawing.Point(38, 141);
            this.genWinCheck.Name = "genWinCheck";
            this.genWinCheck.Size = new System.Drawing.Size(70, 17);
            this.genWinCheck.TabIndex = 7;
            this.genWinCheck.Text = "Windows";
            this.genWinCheck.UseVisualStyleBackColor = true;
            // 
            // genLinuxCheck
            // 
            this.genLinuxCheck.AutoSize = true;
            this.genLinuxCheck.Location = new System.Drawing.Point(38, 164);
            this.genLinuxCheck.Name = "genLinuxCheck";
            this.genLinuxCheck.Size = new System.Drawing.Size(51, 17);
            this.genLinuxCheck.TabIndex = 8;
            this.genLinuxCheck.Text = "Linux";
            this.genLinuxCheck.UseVisualStyleBackColor = true;
            // 
            // genMacCheck
            // 
            this.genMacCheck.AutoSize = true;
            this.genMacCheck.Location = new System.Drawing.Point(38, 187);
            this.genMacCheck.Name = "genMacCheck";
            this.genMacCheck.Size = new System.Drawing.Size(48, 17);
            this.genMacCheck.TabIndex = 9;
            this.genMacCheck.Text = "OSX";
            this.genMacCheck.UseVisualStyleBackColor = true;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(231, 282);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 10;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // genWebGLCheck
            // 
            this.genWebGLCheck.AutoSize = true;
            this.genWebGLCheck.Location = new System.Drawing.Point(38, 210);
            this.genWebGLCheck.Name = "genWebGLCheck";
            this.genWebGLCheck.Size = new System.Drawing.Size(63, 17);
            this.genWebGLCheck.TabIndex = 11;
            this.genWebGLCheck.Text = "WebGL";
            this.genWebGLCheck.UseVisualStyleBackColor = true;
            // 
            // genCustomCheck
            // 
            this.genCustomCheck.AutoSize = true;
            this.genCustomCheck.Enabled = false;
            this.genCustomCheck.Location = new System.Drawing.Point(38, 256);
            this.genCustomCheck.Name = "genCustomCheck";
            this.genCustomCheck.Size = new System.Drawing.Size(92, 17);
            this.genCustomCheck.TabIndex = 12;
            this.genCustomCheck.Text = "Other/Custom";
            this.genCustomCheck.UseVisualStyleBackColor = true;
            // 
            // genAndroidCheck
            // 
            this.genAndroidCheck.AutoSize = true;
            this.genAndroidCheck.Location = new System.Drawing.Point(38, 233);
            this.genAndroidCheck.Name = "genAndroidCheck";
            this.genAndroidCheck.Size = new System.Drawing.Size(62, 17);
            this.genAndroidCheck.TabIndex = 13;
            this.genAndroidCheck.Text = "Android";
            this.genAndroidCheck.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 308);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(314, 22);
            this.statusStrip.TabIndex = 14;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusStripLabel
            // 
            this.statusStripLabel.Name = "statusStripLabel";
            this.statusStripLabel.Size = new System.Drawing.Size(66, 17);
            this.statusStripLabel.Text = "statusLabel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 330);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.genAndroidCheck);
            this.Controls.Add(this.genCustomCheck);
            this.Controls.Add(this.genWebGLCheck);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.genMacCheck);
            this.Controls.Add(this.genLinuxCheck);
            this.Controls.Add(this.genWinCheck);
            this.Controls.Add(this.label4);
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
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox genWinCheck;
        private System.Windows.Forms.CheckBox genLinuxCheck;
        private System.Windows.Forms.CheckBox genMacCheck;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.CheckBox genWebGLCheck;
        private System.Windows.Forms.CheckBox genCustomCheck;
        private System.Windows.Forms.CheckBox genAndroidCheck;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLabel;
    }
}

