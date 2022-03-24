using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mark = textBox1.Text;
            if (mark == "2")
            {
                label2.Text = "Poor!";
            }
            else if (mark == "3")
            {
                label2.Text = "Average!";
            }
            else if (mark == "4")
            {
                label2.Text = "Good!";
            }
            else if (mark == "5")
            {
                label2.Text = "Very good!";
            }
            else if (mark == "6")
            {
                label2.Text = "Excelent!";
            }
            else
            {
                label2.Text = "Invalid mark!\n Try again!";
            }
        }
    }
}
