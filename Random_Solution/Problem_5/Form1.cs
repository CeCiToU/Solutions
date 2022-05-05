using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp44
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button3.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Visible = false;
            button11.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Visible = false;
            button10.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            button4.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Visible = false;
            button1.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Visible = false;
            button8.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button5.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
            button7.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
            button6.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Visible = false;
            button9.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button12.Visible = false;
        }
    }
}
