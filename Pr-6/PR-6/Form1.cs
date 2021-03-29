using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//индивидуальное задание 7
namespace PR_6
{

  public partial class Form1 : Form
  {
    int[] massive = new int[20];
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Random rand = new Random();
     
      for (int i = 0; i < 20; i++)
      {
        massive[i] = rand.Next(-100, 100);
        richTextBox1.Text += "Mas[" + Convert.ToString(i) + "] = " + Convert.ToString(massive[i]) + "\n";
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      //listBox2.Text = "";
      for (int i = 0; i < 15; i++)
      {
        if (massive[i] < 0) massive[i] = 0;
        richTextBox2.Text += "Mas[" + Convert.ToString(i) + "] = " + Convert.ToString(massive[i]) + Environment.NewLine;
      }

    }

   }
}
