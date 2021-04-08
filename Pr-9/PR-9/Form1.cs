using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_9
{
  public partial class Form1 : Form
  {
    Point[] points = new Point[50];
    Pen pen = new Pen(Color.Black, 2);


    public Form1()
    {
      InitializeComponent();
    }
   


    private void Form1_Paint(object sender, PaintEventArgs e)
    {

      Graphics g = e.Graphics; // Объявляется объект Graphics   
                               // Далее вставляется код рисования
      g.DrawLines(pen, points);

    }

    private void button1_Click(object sender, EventArgs e)
    {
      //this.BackgroundImage = Image.FromFile(@"Pictures/summer-again.jpg");
      pictureBox1.Image = Image.FromFile("D:/Users/My ASUS/Pictures/Camera Roll/Sunflowers_Sunrises_and_sunsets_Sky_Fields_Sun_590818_600x400.jpg");
    }
  }
 }

