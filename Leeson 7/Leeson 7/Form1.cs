using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leeson_7
{
    public partial class Form1 : Form
    {
        List<string> filePaths = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnChooseDir_Click(object sender, EventArgs e)
        {

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                lbAllFilesInDir.Items.Clear();
                tbChoosenFile.Clear();

                var dirPath = folderBrowserDialog1.SelectedPath;

                DirectoryInfo di = new DirectoryInfo(dirPath);

                FileInfo[] files;

                string[] fileTypeArr = { "*.txt", "*.rar", "*.mp4", "*.*" };
                string fileType = "*.txt";

                if (radioButton1.Checked) fileType = fileTypeArr[0];
                else if (radioButton2.Checked) fileType = fileTypeArr[1];
                else if (radioButton3.Checked) fileType = fileTypeArr[2];
                else if (radioButton4.Checked) fileType = fileTypeArr[3];

                if (cbInputFolders.Checked)
                    files = di.GetFiles(fileType, SearchOption.AllDirectories);
                else
                    files = di.GetFiles(fileType, SearchOption.TopDirectoryOnly);
                
                lbAllFilesInDir.Items.AddRange(files.Select(x => x.Name).ToArray());
                filePaths.AddRange(files.Select(x => x.FullName).ToArray());
                lbStatus.Text = "Директория просканирована! Файлы в списке.";
                return;
            }
            MessageBox.Show("Директория не выбрана!", "Директория не выбрана!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lbAllFilesInDir_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(filePaths[lbAllFilesInDir.SelectedIndex]);

            lbFilePath.Text = filePaths[lbAllFilesInDir.SelectedIndex];

            using (var fileStream = fi.OpenRead())
            using (var sr = new StreamReader(fileStream))
            {
                tbChoosenFile.Text = sr.ReadLine();
            }
        }
    }
}
