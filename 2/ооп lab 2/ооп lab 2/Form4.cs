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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ооп_lab_2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (myClass.Check_array(textBox1.Text) == false || myClass.Check_array(textBox2.Text) == false)
                MessageBox.Show("Некорректные символы в полях значений Xn и Xk");
            else
            {
                 dataGridView1.Rows.Clear();
                 string[] ans = { "", "", "" };
                 ans = myClass.Part_3_func(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), ans );
                 string[] x = ans[0].Split(' '), Y = ans[1].Split(' '), S = ans[2].Split(' ');
                 for (int i = 0; i < x.Length; i++)
                 {
                     dataGridView1.Rows.Add();
                     dataGridView1.Rows[i].Cells[0].Value = x[i];
                     dataGridView1.Rows[i].Cells[1].Value = Y[i];
                     dataGridView1.Rows[i].Cells[2].Value = S[i];
                 }
                 dataGridView1.Rows.RemoveAt(x.Length - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "1";
            button2_Click(null, null);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
