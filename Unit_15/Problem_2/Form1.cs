using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, FontStyle.Regular);

            if (textBox1.Text == "1") label1.Text = "понеделник";

            else if (textBox1.Text == "2") label1.Text = "вторник";

            else if (textBox1.Text == "3") label1.Text = "сряда";

            else if (textBox1.Text == "4") label1.Text = "четвъртък";

            else if (textBox1.Text == "5") label1.Text = "петък";

            else if (textBox1.Text == "6") label1.Text = "събота";

            else if (textBox1.Text == "7") label1.Text = "неделя";

            else label1.Text = "Не знам!";
        }
    }
}
