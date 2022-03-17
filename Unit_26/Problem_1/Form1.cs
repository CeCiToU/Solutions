using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int numbersOfRods = 0;
            if (b > a)
            {
                label6.Text = "a should be greater than b!";
            }
            else
            {
                while (a > b)
                {
                    numbersOfRods += 1;
                    a = a - b;
                }
                if (a < b && a > 0 || a == b)
                {
                    numbersOfRods += 1;
                }
                label4.Text = numbersOfRods.ToString();
            }
           

        }
    }
}
