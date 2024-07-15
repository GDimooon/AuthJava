using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_2
{
    public partial class Form1 : Form
    {
        private Point startPoint;
        private Point endPoint;
        private bool isDrawing;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                startPoint = new Point(0, 0);
                endPoint = e.Location;
                isDrawing = true;
                Refresh();
            }
            else if (e.Button == MouseButtons.Left)
            {
                startPoint = e.Location;
                endPoint = new Point(ClientSize.Width, ClientSize.Height);
                isDrawing = true;
                Refresh();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (isDrawing)
            {
                using (var pen = new Pen(Color.Black))
                {
                    e.Graphics.DrawLine(pen, startPoint, endPoint);
                }
            }
        }
    }
}