using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using mycalculator;

namespace lab_3._1
{
    public partial class Form1 : Form
    {
    
        public Form1()
        {
            InitializeComponent();
        }

        private void checkVariables(string str1, string str2)
        {
            if (double.TryParse(str1, out double numeric1) != true || double.TryParse(str2, out double numeric2) != true)
                throw new Exception("Некорректные символы в полях значений");
            if (str2 == "-2")
                throw new Exception("Деление на 0 из-за значения d");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                checkVariables(textBox1.Text, textBox3.Text);
                MyCalc1 Calculator = new MyCalc1();
                Calculator.a = Convert.ToInt32(textBox1.Text);
                Calculator.b = Convert.ToDouble(textBox3.Text);
                textBox2.Text = Calculator.Calculate().ToString("F4");
                comboBox1.Items.Add(textBox1.Text + " " + textBox3.Text + " " + textBox2.Text);
            }
           catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chooseSelected(object sender, EventArgs e)
        {
            string[] tmp = Convert.ToString(comboBox1.SelectedItem).Split(' ');
            textBox1.Text = tmp[0];
            textBox3.Text = tmp[1];
            textBox2.Text = tmp[2];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
