using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_5
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    //1.	Подсчитать, сколько раз среди символов заданной строки встречается буква «а».
    private void button1_Click(object sender, EventArgs e)
        {
      
        // Получаем номер выделенной строки
        int index = listBox1.SelectedIndex;
        // Считываем строку в перменную str
        string str = (string)listBox1.Items[index];
        // Узнаем количество символов в строке
        int len = str.Length;
        // Считаем, что количество пробелов равно 0
        int count = 0;
        // Устанавливаем счетчик символов в 0
        int i = 0;
        //Организуем цикл перебора всех символов в строке
        while (i < len - 1)
        {
        // Если нашли пробел, то увеличиваем
        // счетчик пробелов на 1
        if (str[i] == 'а')
          count++;
        i++;
      }
      label1.Text = "Символов А в строке = " + count.ToString();
    }

    //14.	Подсчитать, сколько раз встречается в тексте заданный фрагмент.


    


    private void index_string_Click(object sender, EventArgs e)
    {

      {
        // Получаем номер выделенной строки
        int index = listBox1.SelectedIndex;
        // Считываем строку в перменную str
        string str = (string)listBox1.Items[index];
        // Узнаем количество символов в строке
        int len = str.Length;
        // Считаем, что количество пробелов равно 0
        int count = 0;
        // Устанавливаем счетчик символов в 0
        int i = 0;
        //Организуем цикл перебора всех символов в строке

        string str_textbox = textBox1.Text;
        int index_string = 0;
        if (listBox1.SelectedIndex != null)
        {
          index_string = Convert.ToString(listBox1.SelectedItem).Length;
        }
        else MessageBox.Show("Select string, sir");
        Console.WriteLine(index_string);

     

        
          char[] string_to_char = new char[index_string];

          for (int index_for_char = 0; index_for_char <= index_string; index_for_char++)
          {
          string_to_char = str.ToCharArray();
          
          }
        //        char[] string_vveli = new char[];

        



       
        label2.Text = "Заданный фрагмент встречается = " + count.ToString() + "раз";
      }
     
  

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
