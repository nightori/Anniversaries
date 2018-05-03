using System;
using System.Windows.Forms;

/*
    This program is dedicated to my dear dashadel-chan ^^
    LH — 03.05.2018 <3
*/

namespace Anniversaries
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonCompute_Click(object sender, EventArgs e)
        {
            DateTime bday = dateTimePicker.Value;
            DateTime now = DateTime.Now;
            if (DateTime.Compare(bday, now)>0)
            {
                MessageBox.Show("Вы ещё не родились! (проверьте системную дату)","Ошибка!");
                return;
            }
            int current = (DateTime.Now - bday).Days + 1;
            outputTB.Text = current + "-й день с рождения";
            int n = (int)intervalNUD.Value;
            for (int i = n; i <= intervalNUD.Maximum; i += n)
            {
                bday = bday.AddDays(n);
                string completed = DateTime.Compare(bday, now) > 0 ? "[-] " : "[+] ";
                string dateStr = bday.ToString("d");
                outputTB.Text += "\r\n" + completed + i + " дней:\t"+dateStr;
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(outputTB.Text);
        }
    }
}
