using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProgs
{
    public partial class MainForm : Form
    {
        int count = 0;
        Random rnd;

        public MainForm()
        {
            InitializeComponent();
            rnd = new Random();
            nudTo.Minimum = nudFrom.Value;
            nudFrom.Maximum = nudTo.Value;
        }   

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данное приложение разработано в целях обучения программированию на языке С#. Автор: Красильников А.В.", "О программе");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            count++;
            lblCount.Text = count.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            count--;
            lblCount.Text = count.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            count = 0;
            lblCount.Text = count.ToString();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            int n;
            n = rnd.Next(Convert.ToInt32(nudFrom.Value), Convert.ToInt32(nudTo.Value) + 1);
            if (cbRandom.Checked)
            {
                int i = 0;

                while (tbRandom.Text.IndexOf(n.ToString()) != -1)
                {
                    n = rnd.Next(Convert.ToInt32(nudFrom.Value), Convert.ToInt32(nudTo.Value) + 1);
                    i++;
                    if (i > nudTo.Maximum) break;
                }
                if (i <= nudTo.Maximum) tbRandom.AppendText(n + "\n");
            }
            else tbRandom.AppendText(n + "\n");
            lblRandom.Text = n.ToString();
        }



        private void nudFrom_ValueChanged_1(object sender, EventArgs e)
        {
            nudTo.Minimum = nudFrom.Value;
        }

        private void nudTo_ValueChanged(object sender, EventArgs e)
        {
            nudFrom.Maximum = nudTo.Value;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbRandom.Clear();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbRandom.Text);
        }

        private void tsmiDate_Click(object sender, EventArgs e)
        {
            rtbNotepad.AppendText(DateTime.Now.ToShortDateString());
        }

        private void tsmiTime_Click(object sender, EventArgs e)
        {
            rtbNotepad.AppendText(DateTime.Now.ToShortTimeString());
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            try
            {
                rtbNotepad.SaveFile("notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении!");
            }
        }

        private void loadNotepad ()
        {
            try
            {
                rtbNotepad.LoadFile("notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Ошибка при загрузке!");
            }
        }

        private void tsmiLoad_Click(object sender, EventArgs e)
        {
            loadNotepad();
        }

        private void tsmiClearNotepad_Click(object sender, EventArgs e)
        {
            rtbNotepad.Clear();
        }

        private void btnGetPassword_Click(object sender, EventArgs e)
        {
            if (clbPassword.CheckedItems.Count == 0) return;

            string password = "";
            string s = "";

            if (clbPassword.GetItemChecked(0)) s += "0123456789";
            if (clbPassword.GetItemChecked(1)) s += "abcdefghijklmnopqrstuvwxyz";
            if (clbPassword.GetItemChecked(2)) s += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (clbPassword.GetItemChecked(3)) s += "%*()#$^&~";

            for (int i=0;i<nudPassword.Value;i++)
            {
                password += s[rnd.Next(s.Length)];
            }

            tbPassword.Text = password;
            Clipboard.SetText(password);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            clbPassword.SetItemChecked(0, true);
        }
    }
}
