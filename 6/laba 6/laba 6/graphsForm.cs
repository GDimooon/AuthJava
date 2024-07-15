using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace laba_6
{
    public partial class graphsForm : Form
    {
        public graphsForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            // Создаем серию данных для графика
            Series graphic = new Series();
            graphic.ChartType = SeriesChartType.Line;
            graphic.BorderWidth = 2;
            double a = Convert.ToDouble(textBox1.Text);
            for (double x = 0; x <= 6 * Math.PI; x += 0.1)
            {
                double y = Math.Sin(2 * Math.PI - x) * Math.Exp(-a * x);
                graphic.Points.AddXY(x, y);
            }
            chart1.Series.Add(graphic);
            chart1.Invalidate();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Graphics g = graphWind.CreateGraphics();
            g.Clear(Color.White);
            Pen myPen = new Pen(Color.Red);
            double a;
            if (!Double.TryParse(textBox1.Text, out a))
            {
                MessageBox.Show("Ошибка! Некорректное значение параметра 'a'");
                return;
            }
            int points = 100;
            float minX = 0, maxX = 6 * (float)Math.PI;
            float stepX = (maxX - minX) / points;
            float minY = 1, maxY = (float)(Math.Exp((-a) * maxX) * Math.Sin(2 * Math.PI - maxX)); ;
            float kX = graphWind.Width / (maxX - minX), kY = 30;
            float x1 = minX, y1 = minY;

            for (int i = 0; i < points; i++)
            {
                float x2 = x1 + stepX;
                float y2 = (float)(Math.Exp((-a) * x2) * Math.Sin(2 * Math.PI - x2));
                g.DrawLine(myPen, x1 * kX, graphWind.Height - y1 * kY - 80, x2 * kX, graphWind.Height - y2 * kY - 80);
                x1 = x2;
                y1 = y2;
            }
            g.DrawString("y=sin(2π -x) *exp(- " + a + " * x)", DefaultFont, new SolidBrush(Color.Black), new PointF(3, 3));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = graphDraw.CreateGraphics();
            Random rnd = new Random(), rndMax = new Random();
            Color[] colors = new Color[] { Color.BlueViolet, Color.DarkMagenta, Color.DarkOrange, Color.Orchid, Color.PaleVioletRed, Color.PeachPuff, Color.Pink, Color.Purple, Color.Red, Color.Violet };
            Pen[] myPens = { Pens.Brown, Pens.Red, Pens.Blue, Pens.Black, Pens.Violet, Pens.Cyan, Pens.Maroon, Pens.Gray, Pens.Aqua, Pens.Fuchsia };
            for (int i = 0; i < rndMax.Next(0, 5); i++)
            {
                float randHeight = rnd.Next(10, graphDraw.Height), randWidth = rnd.Next(10, graphDraw.Width), randX = rnd.Next(0, (int)randWidth), randY = rnd.Next(0, (int)randHeight);
                g.DrawRectangle(myPens[rnd.Next(0, 10)], randX, randY, randWidth, randHeight);
            }
            for (int i = 0; i < rndMax.Next(0, 5); i++)
            {
                float randHeight = rnd.Next(10, graphDraw.Height), randWidth = rnd.Next(10, graphDraw.Width), randX = rnd.Next(0, (int)randWidth), randY = rnd.Next(0, (int)randHeight);
                g.DrawEllipse(myPens[rnd.Next(0, 10)], randX, randY, randWidth, randHeight);
            }
            for (int i = 0; i < rndMax.Next(0, 5); i++)
            {
                float randHeight = rnd.Next(10, graphDraw.Height), randWidth = rnd.Next(10, graphDraw.Width), randX = rnd.Next(0, (int)randWidth), randY = rnd.Next(0, (int)randHeight);
                g.DrawLine(myPens[rnd.Next(0, 10)], randX, randY, randWidth, randHeight);
            }
            for (int i = 0; i < rndMax.Next(0, 5); i++)
            {
                float randHeight = rnd.Next(10, graphDraw.Height), randWidth = rnd.Next(10, graphDraw.Width), randX = rnd.Next(0, (int)randWidth), randY = rnd.Next(0, (int)randHeight);
                PointF randPoint = new PointF(randX, randY);
                Font randFont = new Font("Segoe UI", rnd.Next(5, 30));
                char randLetter = Convert.ToChar(rnd.Next(65, 90));
                g.DrawString(randLetter.ToString(), randFont, new SolidBrush(colors[rnd.Next(0, 9)]), randPoint);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chart2.Series.Clear();
            Series graphic = new Series();
            Series graphic1 = new Series();
            Series graphic2 = new Series();
            graphic.ChartType = SeriesChartType.Line;
            graphic.BorderWidth = 2;
            graphic1.ChartType = SeriesChartType.Line;
            graphic1.BorderWidth = 2;
            graphic2.ChartType = SeriesChartType.Line;
            graphic2.BorderWidth = 2;
            double x, xn, xk, h, Y, f;
            int n, N, i;
            xn = 0;
            xk = 1;
            h = (xk - xn) / 10;
            N = 8;
            for (x = xn; x <= xk; x += h)
            {
                double S = 0;

                for (n = 0; n <= N; n++)
                {
                    f = 1;
                    for (i = 1; i <= 2 * n; i++)
                    { f = f * i; }
                    S = S + Math.Pow(-1, n) * (Math.Pow(2 * x, 2 * n) / f);
                }
                graphic1.Points.AddXY(x, -S);
                Y = 2 * (Math.Cos(x) * Math.Cos(x) - 1);
                graphic.Points.AddXY(x, Y);
                double y = 0;
                graphic2.Points.AddXY(x, y);

            }
            // Добавляем серию данных на график
            chart2.Series.Add(graphic1);
            chart2.Series.Add(graphic);
            chart2.Series.Add(graphic2);
            chart2.Invalidate();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void свойстваToolStripMenuItem_Click_1(object sender, EventArgs e, int minX, int maxX)
        {
            {
                Control sourceControl = null;
                // Определяем выбранный пункт меню
                ToolStripItem menuItem = sender as ToolStripItem;
                if (menuItem != null)
                {
                    // Находим ContextMenuStrip - владельца найденного пункта меню
                    ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                    if (owner != null)
                    {
                        // Находим Сontrol, для которого вызвано контекстное меню
                        sourceControl = owner.SourceControl;
                    }
                }
                string txt = "";
                if (sourceControl.Name == "chart1" || sourceControl.Name == "graphWind")
                {
                    txt = "График функции \ny=sin(2π -x) *exp(-a* x)\nгде параметр a=" + textBox1.Text + "\nXmin=" + minX.ToString() + "\tXmax=" + maxX.ToString("F");
                }
                else if (sourceControl.Name == "chart2")
                {
                    txt = "1) График функции Y(x)=2 * (Cos(x) * Cos(x) - 1)\nXmin= 0\nXmax=1\n\n2) Сумма ряда S(x)=(-1)^n*(2x)^2n/(2n)! от n=0 до n=8\n\n";
                }
                MessageBox.Show(txt, "Свойства диаграммы", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }      

}