using myLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ооп_lab_2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox5.Text == "" || textBox6.Text == "")
                MessageBox.Show("Поля знаечний  не должны быть пустыми");
            else if (myClass.Check_double(textBox1.Text) == false || myClass.Check_double(textBox2.Text) == false || myClass.Check_double(textBox3.Text) == false || myClass.Check_double(textBox5.Text) == false ||  myClass.Check_double(textBox6.Text) == false) 
            MessageBox.Show("Некорректные символы в полях значений ");
                
            else
            {
                try
                {

                    double a = Convert.ToDouble(textBox1.Text);
                    double b = Convert.ToDouble(textBox2.Text);
                    double c = Convert.ToDouble(textBox3.Text);
                    double d = Convert.ToDouble(textBox5.Text);
                    double k = Convert.ToDouble(textBox6.Text);
                    double g;

                    g = myClass.Part_2_func(a,b,c,d,k);

                    textBox4.Text = Convert.ToString(g);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "2";
            textBox2.Text = "5,5";
            textBox3.Text = "1";
            textBox5.Text = "79,5";
            textBox6.Text = "6";

            textBox4.Text = "18,8";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
