//11
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

    private void Form1_Load(object sender, EventArgs e)
    {
      
      // Вывод строки в многострочный редактор
      richTextBox1.Text = "Практическая работа №2";
      richTextBox1.Text += Environment.NewLine + "Рассчитать значение выражения y";

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      // Считывание значения X
      double x = double.Parse(textBox1.Text);
      // Вывод значения X в окно
      richTextBox1.Text += Environment.NewLine + "При x = " + x.ToString();
      // Вычисляем арифметическое выражение
      double y = (Math.Sqrt(3+Math.Log(x)+15-x))/1+Math.Sin((2+Math.Pow(x,2)/1+x));

      // Выводим результат в окно
      richTextBox1.Text += Environment.NewLine + "Результат y = " + y.ToString();

    }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
