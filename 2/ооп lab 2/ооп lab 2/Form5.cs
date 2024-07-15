using myLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ооп_lab_2
{
    public partial class Form5 : Form
    {
        char[] mas = new char[5];
        Random ran = new Random();

        public Form5()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.ColumnCount = 5; // Указываем количество столбцов
                dataGridView1.RowCount = 5; // Указываем количество строк

                dataGridView1.AutoGenerateColumns = false;

                int n = 5;
                int[,] matrix = new int[n, n];

                Random rand = new Random();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrix[i, j] = rand.Next(1, 100);
                        dataGridView1.Rows[i].Cells[j].Value = matrix[i, j].ToString(); // Заполняем ячейки значениями
                    }
                }

                var result = myClass.FindMinMaxElements(matrix, n);

              //  MessageBox.Show($"Максимальный элемент ниже побочной диагонали: {result.Item1}\nМинимальный элемент выше главной диагонали: {result.Item2}");
                textBox1.Text = result.Item1.ToString();
                textBox2.Text = result.Item2.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}