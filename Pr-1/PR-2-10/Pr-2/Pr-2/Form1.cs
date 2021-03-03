using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_2
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    private void Form1_load(object sender, EventArgs e)
    {
      this.BackColor = Color.Pink;
      textBox1.Text = "Done!";
    }
        private void button1_Click(object sender, EventArgs e)
        {
      this.button1.BackColor = Color.Red;
      string g = ("Готов к работе");
      textBox1.Text = g;
         }

    private void button2_Click(object sender, EventArgs e)
    {
      this.button2.BackColor = Color.Orange;
      string g = ("Готов к работе");
      textBox1.Text = g;
    }

    private void button3_Click(object sender, EventArgs e)
    {
      this.button3.BackColor = Color.Blue;
      string g = ("Готов к работе");
      textBox1.Text = g;
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
