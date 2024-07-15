using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab8_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Point cursorPosition = PointToClient(Cursor.Position);
            string coordinates = $"X: {cursorPosition.X}, Y: {cursorPosition.Y}";
            lblCoordinates.Text = coordinates;
        }
    }
}