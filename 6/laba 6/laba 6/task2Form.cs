using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_6
{
    public partial class task2Form : Form
    {
        public task2Form()
        {
            InitializeComponent();
        }

        
        private void должностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Укажите должность";
            if (MessageBox.Show("Выбран пункт меню Справочник > Должность\", \"Действие", "Действие", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                toolStripStatusLabel1.Text = "Готово";
        }

        private void странаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Укажите страну";
            if (MessageBox.Show("Выбран пункт меню Справочник > Страна", "Действие", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                toolStripStatusLabel1.Text = "Готово";
        }

        private void регионToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Укажите регион";
            if (MessageBox.Show("Выбран пункт меню Справочник > Регион", "Действие", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                toolStripStatusLabel1.Text = "Готово";
        }

        private void городToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Укажите город";
            if (MessageBox.Show("Выбран пункт меню Справочник > Город", "Действие", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                toolStripStatusLabel1.Text = "Готово";
        }

        private void иМНСToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Укажите ИМНС";
            if (MessageBox.Show("Выбран пункт меню Справочник > ИМНС", "Действие", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                toolStripStatusLabel1.Text = "Готово";
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Информация о программе";
            if (MessageBox.Show("Программа разработана для Лабораторной работы №6 по предмету 'Объектно-Ориентированное программирование'\n\nМаксимова Мария ИВТ-22", "Справка > О программе", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                toolStripStatusLabel1.Text = "Готово";
        }

        private void сотрудникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Данные о сотруднике";
            if (MessageBox.Show("Выбран пункт меню Объект > Сотрудник", "Действие", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                toolStripStatusLabel1.Text = "Готово";
        }

        private void клиентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Данные о клиенте";
            if (MessageBox.Show("Выбран пункт меню Объект > Клиент", "Действие", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                toolStripStatusLabel1.Text = "Готово";
        }

        private void договорToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Данные о договоре";
            if (MessageBox.Show("Выбран пункт меню Объект > Договор", "Действие", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                toolStripStatusLabel1.Text = "Готово";
        }

        private void поручениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Данные о поручении";
            if (MessageBox.Show("Выбран пункт меню Объект > Поручение", "Действие", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                toolStripStatusLabel1.Text = "Готово";
        }

        private void сделкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Данные о сделке";
            if (MessageBox.Show("Выбран пункт меню Объект > Сделка", "Действие", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                toolStripStatusLabel1.Text = "Готово";
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Выход из приложения";
            DialogResult rsl = MessageBox.Show("Закрыть приложение?", "Внимание",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rsl == DialogResult.Yes)
                this.Close();
        }

        private void объектToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
