using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_6
{
    public partial class task1Form : Form
    {
        string FileName;
        public task1Form()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "Готово";
        }

        void loadImage()
        {
            openFileDialog1.Title = "Открыть файл";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(FileName);
                toolStripStatusLabel1.Text = "Загружено изображение: " + FileName;
            }
        }

        private void toolStripButtonJPG_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonBMP_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            graphsForm frm = new graphsForm();
            frm.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rsl = MessageBox.Show("Закрыть приложение?", "Внимание",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rsl == DialogResult.Yes)
                this.Close();
        }

        private void вФорматеJPEGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "image (JPEG) files (*.jpg)|*.jpg|All files (*.*)|*.*";
            try
            {
                loadImage();
            }
            catch (Exception ex) { MessageBox.Show("Не удалось загрузить файл: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void вФорматеBMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "image (BMP) files (*.bmp)|*.bmp|All files (*.*)|*.*"; openFileDialog1.Title = "Открыть файл";
            try
            {
                loadImage();
            }
            catch (Exception ex) { MessageBox.Show("Не удалось загрузить файл: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void показатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graphsForm frm = new graphsForm();
            frm.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (FileName != null)
            {
                FileInfo fileInform = new FileInfo(FileName);
                MessageBox.Show("Имя файла: " + fileInform.Name + "\nРасположение: " + fileInform.DirectoryName.ToString() + "\nРазмер: " + fileInform.Length.ToString() + " бит" + "\nФормат: " + fileInform.Extension.ToString() + "\nИзмерения: " + Image.FromFile(FileName).PhysicalDimension, "Свойства изображения", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Изображение не загружено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void графикиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
