﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        int a;

        int b;

        int c;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);

            b = int.Parse(textBox1.Text);

            c = a + b;

            label1.Text = c.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);

            b = int.Parse(textBox2.Text);

            c = a - b;

            label1.Text = c.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";

            textBox2.Text = "0";

            label1.Text = "0";
        }
    }
}
