using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp42
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            if( a > 0)
            {
                label2.Visible = true;
                textBox2.Visible = true;
                button1.Visible = false;
                button2.Visible = true;
                label3.Text = "";
            }
            else
            {
                label3.Text = "Invalid";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int b = int.Parse(textBox2.Text);
            if (b > 0)
            {
                button2.Visible = false;
                button3.Visible = true;
                label4.Text = "";
            }
            else
            {
                label4.Text = "Invalid";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double area = a * b;
            double perimeter = 2 * a + 2 * b;
            label5.Text = "Perimeter = " + perimeter;
            label6.Text = "Area = " + area;
            button4.Visible = true;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label5.Text = "";
            label6.Text = "";
            label1.Visible = true;
            textBox1.Visible = true;
            label2.Visible = false;
            textBox2.Visible = false;
            button1.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }
    }
}
