namespace Lesson_6
{
    partial class MainForm
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
            this.lvListLeft = new System.Windows.Forms.ListView();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvListRight = new System.Windows.Forms.ListView();
            this.btnFRTL = new System.Windows.Forms.Button();
            this.btnFLTR = new System.Windows.Forms.Button();
            this.btnAllFRTL = new System.Windows.Forms.Button();
            this.btnAllFLTR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvListLeft
            // 
            this.lvListLeft.Location = new System.Drawing.Point(12, 12);
            this.lvListLeft.MultiSelect = false;
            this.lvListLeft.Name = "lvListLeft";
            this.lvListLeft.Size = new System.Drawing.Size(140, 111);
            this.lvListLeft.TabIndex = 0;
            this.lvListLeft.UseCompatibleStateImageBehavior = false;
            this.lvListLeft.View = System.Windows.Forms.View.List;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(251, 158);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 57);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Записать";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(12, 147);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(221, 102);
            this.tbText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите текст";
            // 
            // lvListRight
            // 
            this.lvListRight.Location = new System.Drawing.Point(219, 12);
            this.lvListRight.MultiSelect = false;
            this.lvListRight.Name = "lvListRight";
            this.lvListRight.Size = new System.Drawing.Size(140, 111);
            this.lvListRight.TabIndex = 4;
            this.lvListRight.UseCompatibleStateImageBehavior = false;
            this.lvListRight.View = System.Windows.Forms.View.List;
            // 
            // btnFRTL
            // 
            this.btnFRTL.Location = new System.Drawing.Point(159, 13);
            this.btnFRTL.Name = "btnFRTL";
            this.btnFRTL.Size = new System.Drawing.Size(54, 23);
            this.btnFRTL.TabIndex = 5;
            this.btnFRTL.Text = "<";
            this.btnFRTL.UseVisualStyleBackColor = true;
            this.btnFRTL.Click += new System.EventHandler(this.btnFRTL_Click);
            // 
            // btnFLTR
            // 
            this.btnFLTR.Location = new System.Drawing.Point(158, 42);
            this.btnFLTR.Name = "btnFLTR";
            this.btnFLTR.Size = new System.Drawing.Size(54, 23);
            this.btnFLTR.TabIndex = 6;
            this.btnFLTR.Text = ">";
            this.btnFLTR.UseVisualStyleBackColor = true;
            this.btnFLTR.Click += new System.EventHandler(this.btnFLTR_Click);
            // 
            // btnAllFRTL
            // 
            this.btnAllFRTL.Location = new System.Drawing.Point(158, 71);
            this.btnAllFRTL.Name = "btnAllFRTL";
            this.btnAllFRTL.Size = new System.Drawing.Size(54, 23);
            this.btnAllFRTL.TabIndex = 7;
            this.btnAllFRTL.Text = "<<";
            this.btnAllFRTL.UseVisualStyleBackColor = true;
            this.btnAllFRTL.Click += new System.EventHandler(this.btnAllFRTL_Click);
            // 
            // btnAllFLTR
            // 
            this.btnAllFLTR.Location = new System.Drawing.Point(158, 100);
            this.btnAllFLTR.Name = "btnAllFLTR";
            this.btnAllFLTR.Size = new System.Drawing.Size(54, 23);
            this.btnAllFLTR.TabIndex = 8;
            this.btnAllFLTR.Text = ">>";
            this.btnAllFLTR.UseVisualStyleBackColor = true;
            this.btnAllFLTR.Click += new System.EventHandler(this.btnAllFLTR_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 261);
            this.Controls.Add(this.btnAllFLTR);
            this.Controls.Add(this.btnAllFRTL);
            this.Controls.Add(this.btnFLTR);
            this.Controls.Add(this.btnFRTL);
            this.Controls.Add(this.lvListRight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lvListLeft);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvListLeft;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvListRight;
        private System.Windows.Forms.Button btnFRTL;
        private System.Windows.Forms.Button btnFLTR;
        private System.Windows.Forms.Button btnAllFRTL;
        private System.Windows.Forms.Button btnAllFLTR;
    }
}

