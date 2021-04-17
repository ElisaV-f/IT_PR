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
    public Form1()
    {
      InitializeComponent();
    }
    bool flag = false;
    int x1 = 160;
    int x3 = 38;
    private void Form1_Paint(object sender, PaintEventArgs e)
    {
      Graphics g = e.Graphics;
      g.Clear(Color.LightBlue);
      // Создаем объекты-кисти для закрашивания фигур
      SolidBrush myCorp = new SolidBrush(Color.Black);
      SolidBrush myTrum = new SolidBrush(Color.DarkBlue);
      SolidBrush myTrub = new SolidBrush(Color.Gray);
      //Выбираем перо myPen желтого цвета толщиной в 2 пикселя:
      Pen myWind = new Pen(Color.White, 4);
      // Закрашиваем фигуры
      g.FillRectangle(myTrub, 300, 125, 75, 75); // 1 труба (прямоугольник)
      g.FillRectangle(myTrub, 480, 125, 75, 75); // 2 труба (прямоугольник)
      g.FillPolygon(myCorp, new Point[]      // корпус (трапеция)
        {
          new Point(100,300),new Point(700,300),
          new Point(700,300),new Point(600,400),
          new Point(600,400),new Point(200,400),
          new Point(200,400),new Point(100,300)
        }
      );
      g.FillRectangle(myTrum, 250, 200, 350, 100); // палуба (прямоугольник)
      // Иллюминаторы 
      for (int y = 300; y <= 550; y += 50)
      {
        g.DrawEllipse(myWind, y, 240, 20, 20); // 6 окружностей
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      //this.BackgroundImage = Image.FromFile(@"C:\Users\student\Pictures\black-sea_obl.jpg");
      SolidBrush grayBrush = new SolidBrush(Color.Blue);
      Pen blackPen = new Pen(Color.Blue, 4);
      if (flag != true)
      {
        Rectangle makeSmoke = new Rectangle(150, 380, 50, 40);

        this.CreateGraphics().FillEllipse(grayBrush, makeSmoke);
        flag = true;
      }
      else
      {
        x1 += 20;
        Rectangle makeSmoke1 = new Rectangle(x1, 380, x3, 40);
        this.CreateGraphics().FillEllipse(grayBrush, makeSmoke1);
      }
    }
  }
}
