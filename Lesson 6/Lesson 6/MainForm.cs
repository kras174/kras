using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_6
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            string[] cities = { "Сочи", "Москва", "Челябинск", "Курган", "Пермь", "Уфа", "Казань" };
            for (int i=0;i<=cities.Length-1;i++)
            {
                lvListRight.Items.Add(cities[i]);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string line = string.Empty;

            if (tbText.Text != "") line = tbText.Text;
            else MessageBox.Show("Текстовое поле не должно быть пустым!");

            lvListLeft.Items.Add(line);

            tbText.Clear();

        }

        private void btnFRTL_Click(object sender, EventArgs e)
        {
            if (lvListRight.SelectedItems.Count != 0)
            {
                var copyItem = lvListRight.SelectedItems[0];
                lvListRight.Items.Remove(copyItem);
                lvListLeft.Items.Add(copyItem);
            }
        }

        private void btnFLTR_Click(object sender, EventArgs e)
        {
            if (lvListLeft.SelectedItems.Count != 0)
            {
                var copyItem = lvListLeft.SelectedItems[0];
                lvListLeft.Items.Remove(copyItem);
                lvListRight.Items.Add(copyItem);
            }
        }

        private void btnAllFRTL_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvListRight.Items)
            {
                lvListLeft.Items.Add((ListViewItem)item.Clone());
            }
            //lvListLeft.Items.AddRange((from ListViewItem item in lvListRight.Items select (ListViewItem)item.Clone()).ToArray());
            //lvListLeft.Items.AddRange(lvListRight.Items.Cast<ListViewItem>().Select(i => i.Clone()).Cast<ListViewItem>().ToArray());
           lvListRight.Items.Clear();
        }

        private void btnAllFLTR_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvListLeft.Items)
            {
                lvListRight.Items.Add((ListViewItem)item.Clone());
            }

            lvListLeft.Items.Clear();
        }
    }
}
