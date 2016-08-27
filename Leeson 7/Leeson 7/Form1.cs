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
                }

                allData = Encoding.UTF8.GetString(buffer);
            }

            MessageBox.Show(allData, "Файл прочитан!", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnChoseDirectory_Click(object sender, EventArgs e)
        {

        }
    }
}
