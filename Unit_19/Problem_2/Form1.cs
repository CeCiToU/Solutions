using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int side = int.Parse(textBox1.Text);
            if (side > 0)
            {
                int P = side * 3;

                label3.Text = P.ToString();
            }
            else
            {
                label3.Text = "Does not exist!";
            }
        }
    }
}
