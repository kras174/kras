namespace Leeson_7
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
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnReadSelectedFile = new System.Windows.Forms.Button();
            this.btnChooseDir = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lbStatus = new System.Windows.Forms.Label();
            this.cbInputFolders = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.lbAllFilesInDir = new System.Windows.Forms.ListBox();
            this.lbFilePath = new System.Windows.Forms.Label();
            this.tbChoosenFile = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "ReadDataFromFile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnReadSelectedFile
            // 
            this.btnReadSelectedFile.Location = new System.Drawing.Point(163, 314);
            this.btnReadSelectedFile.Name = "btnReadSelectedFile";
            this.btnReadSelectedFile.Size = new System.Drawing.Size(108, 23);
            this.btnReadSelectedFile.TabIndex = 6;
            this.btnReadSelectedFile.Text = "Read Selected File";
            this.btnReadSelectedFile.UseVisualStyleBackColor = true;
            // 
            // btnChooseDir
            // 
            this.btnChooseDir.Location = new System.Drawing.Point(158, 132);
            this.btnChooseDir.Name = "btnChooseDir";
            this.btnChooseDir.Size = new System.Drawing.Size(113, 23);
            this.btnChooseDir.TabIndex = 7;
            this.btnChooseDir.Text = "Choose Dir";
            this.btnChooseDir.UseVisualStyleBackColor = true;
            this.btnChooseDir.Click += new System.EventHandler(this.btnChooseDir_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "E:\\C# Lessons\\N7";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(11, 114);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(131, 13);
            this.lbStatus.TabIndex = 9;
            this.lbStatus.Text = "Директория не выбрана";
            // 
            // cbInputFolders
            // 
            this.cbInputFolders.AutoSize = true;
            this.cbInputFolders.Checked = true;
            this.cbInputFolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbInputFolders.Location = new System.Drawing.Point(15, 136);
            this.cbInputFolders.Name = "cbInputFolders";
            this.cbInputFolders.Size = new System.Drawing.Size(118, 17);
            this.cbInputFolders.TabIndex = 10;
            this.cbInputFolders.Text = "Вложенные папки";
            this.cbInputFolders.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 166);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(36, 17);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "txt";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(57, 166);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(37, 17);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.Text = "rar";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(100, 166);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(45, 17);
            this.radioButton3.TabIndex = 13;
            this.radioButton3.Text = "mp4";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(151, 166);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(60, 17);
            this.radioButton4.TabIndex = 14;
            this.radioButton4.Text = "All Files";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // lbAllFilesInDir
            // 
            this.lbAllFilesInDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAllFilesInDir.FormattingEnabled = true;
            this.lbAllFilesInDir.Location = new System.Drawing.Point(15, 15);
            this.lbAllFilesInDir.Name = "lbAllFilesInDir";
            this.lbAllFilesInDir.Size = new System.Drawing.Size(258, 95);
            this.lbAllFilesInDir.TabIndex = 15;
            this.lbAllFilesInDir.SelectedIndexChanged += new System.EventHandler(this.lbAllFilesInDir_SelectedIndexChanged);
            // 
            // lbFilePath
            // 
            this.lbFilePath.AutoSize = true;
            this.lbFilePath.Location = new System.Drawing.Point(12, 192);
            this.lbFilePath.Name = "lbFilePath";
            this.lbFilePath.Size = new System.Drawing.Size(0, 13);
            this.lbFilePath.TabIndex = 16;
            // 
            // tbChoosenFile
            // 
            this.tbChoosenFile.Location = new System.Drawing.Point(15, 212);
            this.tbChoosenFile.Multiline = true;
            this.tbChoosenFile.Name = "tbChoosenFile";
            this.tbChoosenFile.Size = new System.Drawing.Size(256, 91);
            this.tbChoosenFile.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 349);
            this.Controls.Add(this.tbChoosenFile);
            this.Controls.Add(this.lbFilePath);
            this.Controls.Add(this.lbAllFilesInDir);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.cbInputFolders);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btnChooseDir);
            this.Controls.Add(this.btnReadSelectedFile);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnReadSelectedFile;
        private System.Windows.Forms.Button btnChooseDir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.CheckBox cbInputFolders;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.ListBox lbAllFilesInDir;
        private System.Windows.Forms.Label lbFilePath;
        private System.Windows.Forms.TextBox tbChoosenFile;
    }
}

