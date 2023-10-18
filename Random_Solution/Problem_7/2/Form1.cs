using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Calc
{
    public partial class Form1 : Form
    {
        List<int> list1 = new List<int>();
        bool change = true;
        double number1;
        double number2;
        public Form1()
        {
            InitializeComponent();
            label8.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
 int numb = 0;
            if (change == true)
            {

                label8.Visible = false;
                if (checkBox1.Checked)
                {
                    numb++;
                    double calculated = number1 + number2;
                    label1.Text = calculated.ToString();
                }
                else
                {
                    label1.Text = "";
                }
                if (checkBox2.Checked)
                {
                    numb++;
                    double calculated = number1 - number2;
                    label2.Text = calculated.ToString();
                }
                else
                {
                    label2.Text = "";
                }
                if (checkBox3.Checked)
                {
                    numb++;
                    double calculated = number1 * number2;
                    label3.Text = calculated.ToString();
                }
                else
                {
                    label3.Text = "";
                }
                if (checkBox4.Checked)
                {
                    numb++;
                    double calculated = number1 / number2;
                    label4.Text = calculated.ToString();
                }
                else
                {
                    label4.Text = "";
                }
                if (numb == 0)
                {
                    label8.Visible = true;
                }
                else
                {
                    label8.Visible = false;
                }
            }
            else
            {
                label8.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            list1.Add(1);
            textBox1.Text = string.Join("", list1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            list1.Add(2);
            textBox1.Text = string.Join("", list1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            list1.Add(3);
            textBox1.Text = string.Join("", list1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            list1.Add(4);
            textBox1.Text = string.Join("", list1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            list1.Add(5);
            textBox1.Text = string.Join("", list1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            list1.Add(6);
            textBox1.Text = string.Join("", list1);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            list1.Add(7);
            textBox1.Text = string.Join("", list1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            list1.Add(8);
            textBox1.Text = string.Join("", list1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            list1.Add(9);
            textBox1.Text = string.Join("", list1);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            list1.Add(0);
            textBox1.Text = string.Join("", list1);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Clear();
                list1.RemoveAt(list1.Count - 1);
                textBox1.Text = string.Join("", list1);
            }
            catch { }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                if (change)
                {
                    number1 = int.Parse(string.Join("", list1));
                    label5.Visible = false;
                    label7.Text = $"num 1:    {number1}";
                    label6.Visible = true;
                    textBox1.Clear();
                    list1.Clear();
                    change = false;
                }
                else
                {
                    number2 = int.Parse(string.Join("", list1));
                    change = true;
                }
            }
            catch
            {
                if (change)
                {
                    number1 = int.Parse(textBox1.Text);
                    label5.Visible = false;
                    label7.Text = $"num 1: {number1}";
                    label6.Visible = true;
                    textBox1.Clear();
                    list1.Clear();
                    change = false;
                }
                else
                {
                    number2 = int.Parse(textBox1.Text);
                }
            }
        }
    }
}
