using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Работа 10, Задание 2 
namespace Pr_10
{
  public partial class Form1 : Form
  {
    private int[] x1 = new int[4];
    private int[] y1 = new int[4];
    private int[] x2 = new int[4];
    private int[] y2 = new int[4];
    private int r;
    private double[] a = new double[4];

    public Form1()
    {
      InitializeComponent();
    }
    private void Form1_Paint(object sender, PaintEventArgs e)
    {
      Graphics g = e.Graphics;
      Pen forLine = new Pen(Color.Crimson, 100);
 
 g.DrawLine(forLine, x1[0], y1[0], x2[0], y2[0]);
      g.DrawLine(forLine, x1[1], y1[1], x2[1], y2[1]);
      g.DrawLine(forLine, x1[2], y1[2], x2[2], y2[2]);
      g.DrawLine(forLine, x1[3], y1[3], x2[3], y2[3]);

      SolidBrush recBrush = new SolidBrush(Color.Black);
      Rectangle r = new Rectangle(350, 178, 100, 100);
      g.FillEllipse(recBrush, r);
      //g.DrawLine(forLine, x1, y1, x2, y2); 
      //g.DrawLine(forLine, x1, y1, x2, y2); 
      /*SolidBrush newBrush = new SolidBrush(Color.Black); 
      Rectangle myachique = new Rectangle(40, 40, 75, 75); 
      g.FillEllipse(newBrush, myachique);*/
    }
    private void Form1_Load(object sender, EventArgs e)
    {
      for (int i = 0; i < 4; i++)
      {
        x1[i] = ClientSize.Width / 2;
        y1[i] = ClientSize.Height / 2;
      }
      r = 150;
      a[0] = 1.57;
      a[1] = 3.14;
      a[2] = 4.71;
      a[3] = 6.28;

      for (int i = 0; i < 4; i++)
      {
        x2[i] = x1[i] + (int)(r * Math.Cos(a[i]));
        y2[i] = y1[i] - (int)(r * Math.Sin(a[i]));
      }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      a[0] -= 0.1;
      a[1] -= 0.1;
      a[2] -= 0.1;
      a[3] -= 0.1;
      if (timer1.Interval <= 20)
      { timer1.Interval = 25; }
      else
      {
        timer1.Interval -= 10;
      }
      for (int i = 0; i < 4; i++)
      {
        x2[i] = x1[i] + (int)(r * Math.Cos(a[i]));
        y2[i] = y1[i] - (int)(r * Math.Sin(a[i]));
      }
      Invalidate();
    }
  }
}



    