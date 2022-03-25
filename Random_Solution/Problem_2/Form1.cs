using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp36
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double num1 = int.Parse(textBox1.Text);
            double num2 = int.Parse(textBox2.Text);
            if (checkBox1.Checked)
            {
                double sum = num1 + num2;
                label3.Text = sum.ToString();
            }
            else
            {
                label3.Text = "";
            }
            if (checkBox2.Checked)
            {
                double different = num1 - num2;
                label4.Text = different.ToString();
            }
            else
            {
                label4.Text = "";
            }
            if (checkBox3.Checked)
            {
                double res = num1 * num2;
                label5.Text = res.ToString();
            }
            else
            {
                label5.Text = "";
            }
            if (checkBox4.Checked)
            {
                double res = num1 / num2;
                label6.Text = res.ToString();
            }
            else
            {
                label6.Text = "";
            }
        }
    }
}
