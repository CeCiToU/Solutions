using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBox1.Text);
            int sum = 0;
            if (number < 1000)
            {
                while (number != 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                label1.Text = sum.ToString();
            }
            else
            {
                label1.Text = "Insert new number (-infinity; 1000)";
            }
        }
    }
}
