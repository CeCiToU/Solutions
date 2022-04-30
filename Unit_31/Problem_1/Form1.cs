using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp40
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
            int c = int.Parse(textBox3.Text);
            int min = a;
            if (b < min)
            {
                min = b;
            }
            if (c < min)
            {
                min = c;
            }
            if(a + b > c && a + c > b && b + c > a)
            {
                label4.Text = "Smallest number is " + min;
                label5.Text = "It is real triangle";
            }
            else
            {
                label4.Text = "Smallest number is " + min;
                label5.Text = "It is not real triangle";
            }
        }
    }
}
