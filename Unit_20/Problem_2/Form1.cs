using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp20
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
            double X1 = int.Parse(textBox1.Text);

            double Y1 = int.Parse(textBox2.Text);

            double X2 = int.Parse(textBox3.Text);

            double Y2 = int.Parse(textBox4.Text);

            double X3 = int.Parse(textBox5.Text);

            double Y3 = int.Parse(textBox6.Text);

            double AB = Math.Sqrt((X2 - X1) * (X2 - X1) + (Y2 - Y1) * (Y2 - Y1));

            double BC = Math.Sqrt((X3 - X2) * (X3 - X2) + (Y3 - Y2) * (Y3 - Y2));

            double CA = Math.Sqrt((X3 - X1) * (X3 - X1) + (Y3 - Y1) * (Y3 - Y1));

            if (AB + BC > CA && BC + CA > AB && CA + AB > BC)

            {

                double P = AB + BC + CA;

                double P1 = Math.Round(P, 2);

                label8.Text = P1.ToString();

            }

            else

            {

                label8.Text = "Няма решение";

            }
        }
    }
}
