using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp46
{
    public partial class Form1 : Form
    {
        int minNum = int.MaxValue;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            listBox1.Items.Clear();
            Random r = new Random();
            minNum = int.MaxValue;
            for (int i = 0; i < 10; i++)
            {
                int numberRandom = r.Next() % 100 + 1;
                listBox1.Items.Add(numberRandom);
                if (minNum > numberRandom)
                {
                    minNum = numberRandom;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = minNum.ToString();
        }
    }
}
