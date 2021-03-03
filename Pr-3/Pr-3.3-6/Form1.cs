using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_3._3_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double y = 0;
            richTextBox1.Text += Environment.NewLine + "При x =" + x.ToString();
            if (radioButton1.Checked)
            {
                if (x > 5)
                {
                    y = Math.Cos(x);
                }
                if ((x > 2) && (x <= 5))
                {
                    y = 0.5 * Math.Cos(x);
                }
                if (x <= 2)
                {
                    y = -1;
                }
                richTextBox1.Text += Environment.NewLine + "Результат y =" + x.ToString();
            }

            if (radioButton2.Checked)
            {
                if (x > 5)
                {
                    y = Math.Cos(x);
                }
                if ((x > 2) && (x <= 5))
                {
                    y = 0.5 * Math.Cos(x);
                }
                if (x <= 2)
                {
                    y = -1;
                }
                richTextBox1.Text += Environment.NewLine + "Результат y =" + x.ToString();
            }

            if (radioButton3.Checked)
            {
                if (x > 5)
                {
                    y = Math.Cos(x);
                }
                if ((x > 2) && (x <= 5))
                {
                    y = 0.5 * Math.Cos(x);
                }
                if (x <= 2)
                {
                    y = -1;
                }
                richTextBox1.Text += Environment.NewLine + "Результат y =" + x.ToString();
            }
        }
    }
}
