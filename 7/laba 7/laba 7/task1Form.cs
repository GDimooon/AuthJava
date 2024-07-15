using BClassLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_7
{
    public partial class task1Form : Form
    {
        public task1Form()
        {
            InitializeComponent();
        }

        private void task1Form_Load(object sender, EventArgs e)
        {

        }

        private void checkInput(string str1, string str2, string str3)
        {

            for (int i = 0; i < str1.Length; i++)
            {
                if ((str1[i] >= 'a' && str1[i] <= 'z') || (str1[i] >= 'A' && str1[i] <= 'Z') || str1[i] == ' ')
                    continue;
                else throw new Exception("Некорректное значение поля 'Слово'");
            }
            if (str2 != "")
            {
                if (int.TryParse(str2, out int numeric1) != true)
                    throw new Exception("Некорректное значение поля 'Число 1'");
            }
            if (str3 != "")
            {
                if (double.TryParse(str3, out double numeric2) != true)
                    throw new Exception("Некорректное значение поля 'Число 2'");
            }
        }

        double Convert_toDouble(string str)
        {
            if (str == "")
                return 0;
            else return Convert.ToDouble(str);
        }
        int Convert_toInt(string str)
        {
            if (str == "")
                return 0;
            else return Convert.ToInt32(str);
        }
        void checkAdditional(string str1, string str2)
        {
            if (str1 == "" || str2 == "")
                throw new Exception("Все поля дополнительного раздела должны быть заполнены");
            else
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    if ((str1[i] >= 'a' && str1[i] <= 'z') || (str1[i] >= 'A' && str1[i] <= 'Z') || str1[i] == ' ')
                        continue;
                    else throw new Exception("Некорректное значение поля 'Строка'");
                }
                if (int.TryParse(str2, out int numeric1) != true)
                    throw new Exception("Некорректное значение поля 'Число'");
            }
        }

        BClass obj1, obj2;

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                checkAdditional(textBox7.Text, textBox8.Text);

                if (Convert.ToInt32(textBox8.Text) > obj1.Numbers2)
                    throw new Exception("Значение поля 'Число' больше, чем значение поля 'Число 2' объекта 1. При вычитании получится отрицательное число, что невозможно");
                if (Convert.ToInt32(textBox8.Text) > obj2.Numbers2)
                    throw new Exception("Значение поля 'Число' больше, чем значение поля 'Число 2' объекта 1. При вычитании получится отрицательное число, что невозможно");

                obj1 = obj1 + textBox7.Text;
                obj2 = obj2 + textBox7.Text;

                obj1 = obj1 - Convert.ToInt32(textBox8.Text);
                obj2 = obj2 - Convert.ToInt32(textBox8.Text);

                textBox9.Text += "     Объект 1:" + Environment.NewLine + obj1.ToString() + Environment.NewLine + "     Объект 2:" + Environment.NewLine + obj2.ToString() + Environment.NewLine;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    checkInput(textBox1.Text, textBox2.Text, textBox3.Text);
                    checkInput(textBox6.Text, textBox5.Text, textBox4.Text);

                    obj1 = new BClass(textBox1.Text, Convert_toInt(textBox2.Text), Convert_toDouble(textBox3.Text));
                    obj2 = new BClass(textBox6.Text, Convert_toInt(textBox5.Text), Convert_toDouble(textBox4.Text));

                    textBox1.Text = "";

                    if (obj1)
                        textBox9.Text += "Оператор true/false: объект  1 не пустой" + Environment.NewLine;
                    else textBox9.Text += "Оператор true/false: объект  1 пустой" + Environment.NewLine;

                    if (obj2)
                        textBox9.Text += "Оператор true/false: объект  2 не пустой" + Environment.NewLine;
                    else textBox9.Text += "Оператор true/false: объект  2 пустой" + Environment.NewLine;

                    textBox1.Text += Environment.NewLine;

                    BClass multiplied = obj1 * obj2;
                    textBox9.Text += "После умножения: " + multiplied.ToString() + Environment.NewLine;

                    BClass multiplied1 = obj2 * obj1;
                    textBox9.Text += "После умножения: " + multiplied1.ToString() + Environment.NewLine;

                   textBox9.Text += Environment.NewLine;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
    }
}
