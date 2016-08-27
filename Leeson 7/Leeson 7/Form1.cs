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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(@"E:\C# Lessons\N7\files\file.txt");

            string allData = string.Empty;

            if (!fi.Exists)
                fi.Create();

            using (var fileStream = fi.OpenRead())
            {
                byte[] buffer = new byte[2048];
                int i = 0;
                int n = 0;

                while ((n = fileStream.ReadByte()) > 0)
                {
                    buffer[i] = (byte)n;
                    i++;
                }

                allData = Encoding.UTF8.GetString(buffer);
            }

            MessageBox.Show(allData, "Файл прочитан!", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string data = "testData";

            using (var file = File.Create(@"E:\C# Lessons\N7\files\fileCreateTest.txt"))
            {
                byte[] buffer = Encoding.UTF8.GetBytes(data);
                file.Write(buffer, 0, buffer.Length);
            }
        }

        private void ChooseFile_button_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            openFileDialog1.InitialDirectory = @"E:\";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileContent = string.Empty;

                using (var fileStream = File.OpenRead(openFileDialog1.FileName))
                using (var sr = new StreamReader(fileStream))
                    fileContent = sr.ReadLine();

                MessageBox.Show(fileContent, "Файл прочитан!", MessageBoxButtons.OK);
                return;
            }
            MessageBox.Show("Файл невыбран!", "Файл невыбран!", MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
