using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = int.Parse(textBox1.Text);

            double b = int.Parse(textBox2.Text);

            double c = int.Parse(textBox3.Text);

            double P = (a + b + c) / 2;

            double A = P - a;

            double B = P - b;

            double C = P - c;



            if (A <= 0 || B <= 0 || C <= 0)

            {

                label5.Text = "няма решение";

            }

            else

            {

                double S = Math.Sqrt(P * A * B * C);
                double S1 = Math.Round(S, 2);

                label5.Text = S1.ToString();

            }
        }
    }
}
