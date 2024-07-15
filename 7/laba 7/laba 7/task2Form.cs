using dateLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_7
{
    public partial class task2Form : Form
    {
        private Date date;

        public task2Form()
        {
            InitializeComponent();
            date = new Date(DateTime.Today.Day, DateTime.Today.Month, DateTime.Today.Year);
            UpdateDateLabel();
        }       


       
        private void UpdateDateLabel()
        {
            DateTextBox.Text = date.ToString();
            ResultTextBox.Text = $"Год {(date.IsLeapYear() ? "" : "не ")}високосный";
        }


        private void nextbutton_Click(object sender, EventArgs e)
        {
            date.Next();
            UpdateDateLabel();
        }

        private void prevbutton_Click_1(object sender, EventArgs e)
        {
            date.Prev();
            UpdateDateLabel();
        }

        private void adddaysbutton_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(DaysTextBox.Text, out int days))
            {
                var newDate = date + days;
                if (newDate != null)
                {
                    date = newDate;
                    UpdateDateLabel();
                    ResultTextBox.Text = date.ToString(); // обновляем содержимое текстового поля
                }
                else
                {
                    MessageBox.Show("Невозможно добавить такое количество дней.");
                }
            }
            else
            {
                MessageBox.Show("Введите целое число дней");
            }
        }

        private void subtractdaysbutton_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(DaysTextBox.Text, out int days))
            {
                var newDate = date - days;
                if (newDate != null)
                {
                    date = newDate;
                    UpdateDateLabel();
                    ResultTextBox.Text = date.ToString(); // обновляем содержимое текстового поля
                }
                else
                {
                    MessageBox.Show("Невозможно вычесть такое количество дней.");
                }
            }
            else
            {
                MessageBox.Show("Введите целое число дней");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
