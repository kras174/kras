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
            this.tbDirectoruField = new System.Windows.Forms.TextBox();
            this.btnChoseDirectory = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbDirectoruField
            // 
            this.tbDirectoruField.Location = new System.Drawing.Point(12, 12);
            this.tbDirectoruField.Name = "tbDirectoruField";
            this.tbDirectoruField.Size = new System.Drawing.Size(236, 20);
            this.tbDirectoruField.TabIndex = 0;
            // 
            // btnChoseDirectory
            // 
            this.btnChoseDirectory.Location = new System.Drawing.Point(253, 11);
            this.btnChoseDirectory.Name = "btnChoseDirectory";
            this.btnChoseDirectory.Size = new System.Drawing.Size(27, 23);
            this.btnChoseDirectory.TabIndex = 1;
            this.btnChoseDirectory.Text = "button1";
            this.btnChoseDirectory.UseVisualStyleBackColor = true;
            this.btnChoseDirectory.Click += new System.EventHandler(this.btnChoseDirectory_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "ReadDataFrpmFile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnChoseDirectory);
            this.Controls.Add(this.tbDirectoruField);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDirectoruField;
        private System.Windows.Forms.Button btnChoseDirectory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

