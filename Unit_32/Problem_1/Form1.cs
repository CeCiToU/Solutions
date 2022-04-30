using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp41
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = int.Parse(textBox1.Text);
            if (a <= 0)
            {
                label3.Text = "Invalid side! Please try again!";
            }
            else
            {
                label3.Text = "Valid side!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double b = int.Parse(textBox2.Text);
            if (b <= 0)
            {
                label4.Text = "Invalid side! Please try again!";
            }
            else
            {
                label4.Text = "Valid side!";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label3.Text == "Valid side!" && label4.Text == "Valid side!")
            {
                double a = int.Parse(textBox1.Text);
                double b = int.Parse(textBox2.Text);
                double sum = 2 * a + 2 * b;
                label5.Text = "The perimeter is " + sum;
            }
            else
            {
                if (label3.Text == "" && label4.Text == "")
                {
                    label5.Text = "Check both sides!";
                }
                if (label3.Text == "Invalid side! Please try again!" && label4.Text == "Invalid side! Please try again!")
                {
                    label5.Text = "Both sides are invalid!";
                }
                else
                {
                    if (label3.Text == "Invalid side! Please try again!")
                    {
                        label5.Text = "Side a is invalid!";
                    }
                    else if (label4.Text == "Invalid side! Please try again!")
                    {
                        label5.Text = "Side b is invalid!";
                    }

                }

            }
        }
    }
}
