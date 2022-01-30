using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            int randNumber = r.Next(6, 49) % 49 + 1;

            int randNumber1 = r.Next(6, 49) % 49 + 1;

            int randNumber2 = r.Next(6, 49) % 49 + 1;

            int randNumber3 = r.Next(6, 49) % 49 + 1;

            int randNumber4 = r.Next(6, 49) % 49 + 1;

            int randNumber5 = r.Next(6, 49) % 49 + 1;

            textBox1.Text = randNumber.ToString();

            textBox2.Text = randNumber1.ToString();

            textBox3.Text = randNumber2.ToString();

            textBox4.Text = randNumber3.ToString();

            textBox5.Text = randNumber4.ToString();

            textBox6.Text = randNumber5.ToString();
        }
    }
}
