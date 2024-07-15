using mycalculator2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_3._2
{
    public partial class Form1 : Form
    {
        private MyCalc2 Calculator;
        private string[] operationHistory;
        private int historyIndex;

        public Form1()
        {
            InitializeComponent();
            Calculator = new MyCalc2();
            operationHistory = new string[10]; // Массив для хранения истории до 10 элементов
            historyIndex = -1; // Изначально история пустая, -1 указывает на пустую историю
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkVariables(string str1, string str2)
        {
            if (!double.TryParse(str1, out _) || !double.TryParse(str2, out _))
                throw new Exception("Некорректные символы в полях значений");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                checkVariables(textBox1.Text, textBox2.Text);
                Calculator.a = Convert.ToInt32(textBox1.Text);
                Calculator.d = Convert.ToDouble(textBox2.Text);
                Calculator.b = Convert.ToDouble(textBox4.Text);
                double result = Calculator.Calculate();
                textBox3.Text = result.ToString("F2");

                // Добавление операции в историю
                string operation = $"{textBox1.Text} {textBox4.Text} {textBox2.Text} = {result.ToString("F2")}";
                AddToHistory(operation);
                UpdateComboBox(); // Обновление ComboBox после каждой операции
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chooseSelected(object sender, EventArgs e)
        {
            string operation = Convert.ToString(comboBox1.SelectedItem);

            if (!string.IsNullOrEmpty(operation))
            {
                SetTextFromOperation(operation);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (historyIndex > 0)
            {
                historyIndex--;
                SetTextFromOperation(operationHistory[historyIndex]);
                comboBox1.SelectedIndex = historyIndex;
            }
            else
            {
                MessageBox.Show("Достигнуто начало истории.");
            }
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            if (historyIndex < operationHistory.Length - 1 && operationHistory[historyIndex + 1] != null)
            {
                historyIndex++;
                SetTextFromOperation(operationHistory[historyIndex]);
                comboBox1.SelectedIndex = historyIndex;
            }
            else
            {
                MessageBox.Show("Достигнут конец истории.");
            }
        }

        private void AddToHistory(string operation)
        {
            if (historyIndex < operationHistory.Length - 1)
            {
                historyIndex++;
            }
            else
            {
                ShiftOperationsLeft();
            }
            operationHistory[historyIndex] = operation;
        }

        private void ShiftOperationsLeft()
        {
            for (int i = 0; i < operationHistory.Length - 1; i++)
            {
                operationHistory[i] = operationHistory[i + 1];
            }
        }

        private void SetTextFromOperation(string operation)
        {
            string[] parts = operation.Split(new[] { ' ',' ' }, StringSplitOptions.RemoveEmptyEntries);
            textBox1.Text = parts[0];
            textBox2.Text = parts[1];
            textBox4.Text = parts[3];
            textBox3.Text = parts[5];
        }

        private void UpdateComboBox()
        {
            comboBox1.Items.Clear();
            foreach (string operation in operationHistory)
            {
                if (operation != null)
                {
                    comboBox1.Items.Add(operation);
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
