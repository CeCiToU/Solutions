using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double calculated = 0.0;
            if (radioButton1.Checked)
            {
                calculated = a + b;
            }
            else if (radioButton2.Checked)
            {
                calculated = a - b;
            }
            else if (radioButton3.Checked)
            {
                calculated = a * b;
            }
            else if (radioButton4.Checked)
            {
                calculated = a / b;
            }
            label1.Text = calculated + "";
        }

    }
}
