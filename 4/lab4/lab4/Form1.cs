using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        Start task1, task2;

        public Form1()
        {
            task1 = new Class1();
            task2 = new Class2();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            task1.A = a;
            task1.B = b;
            task1.TaskValue();
            tk1.AppendText(task1.ToString() + "\r\n");
            task1.Task2(a, b);
            tk11.AppendText(task1.ToString("a=" + "b=" + "res=") + "\r\n");
            ts1.AppendText("res =" + task1.r.ToString() + "\r\n");
            ts11.AppendText("res =" + task1.ToString("res=") + "\r\n");
        }
         
        private void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double d = Convert.ToDouble(textBox3.Text);
            task2.A = a;
            task2.B = b;
            task2.D = d;
            task2.TaskValue();
            tk2.AppendText(task2.ToString() + "\r\n");
            task2.Task2(a, b);
            tk21.AppendText(task2.ToString("a=" + "b=" + "res=") + "\r\n");
            ts2.AppendText("res=" + task2.r.ToString() + "\r\n");
            ts21.AppendText("res=" + task2.ToString("res=") + "\r\n");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
