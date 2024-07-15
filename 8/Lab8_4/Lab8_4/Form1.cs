using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab8_4
{
    public partial class Form1 : Form
    {
        private bool isDrawing;
        private Point previousPoint;

        public Form1()
        {
            InitializeComponent();
            isDrawing = false;
            previousPoint = new Point(0, 0);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            previousPoint = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                Graphics graphics = CreateGraphics();
                graphics.DrawLine(Pens.Black, previousPoint, e.Location);
                previousPoint = e.Location;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }
    }
}