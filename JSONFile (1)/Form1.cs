using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace MuseumApp
{
    public class Exhibit
    {
        public string Name { get; set; }
        public string Source { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public int Pages { get; set; }
    }

    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }

    public class Loan
    {
        public string ExhibitId { get; set; }
        public string UserId { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }

    public class Museum
    {
        public List<Exhibit> Exhibits { get; set; }
        public List<User> Users { get; set; }
        public List<Loan> Loans { get; set; }
    }

    public partial class Form1
    {
        private Museum museum;

        public Form1()
        {
            InitializeComponent();
            museum = new Museum();
            museum.Exhibits = new List<Exhibit>();
            museum.Users = new List<User>();
            museum.Loans = new List<Loan>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Museum));
            using (FileStream fs = new FileStream("museum.xml", FileMode.Create))
            {
                serializer.Serialize(fs, museum);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Museum));
            using (FileStream fs = new FileStream("museum.xml", FileMode.Open))
            {
                museum = (Museum)serializer.Deserialize(fs);
            }
            FillDgv();
        }

        private void FillDgv()
        {
            dataGridView1.DataSource = museum.Exhibits;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.Columns[0].HeaderText = "Name";
            dataGridView1.Columns[1].HeaderText = "Source";
            dataGridView1.Columns[2].HeaderText = "Year";
            dataGridView1.Columns[3].HeaderText = "Genre";
            dataGridView1.Columns[4].HeaderText = "Pages";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string genreFilter = textBox1.Text; // Get genre filter
            List<Exhibit> filteredExhibits = museum.Exhibits.Where(x => x.Genre == genreFilter).ToList();
            FillDgvFromObj(filteredExhibits);
        }

        private void FillDgvFromObj(List<Exhibit> exhibits)
        {
            dataGridView1.DataSource = exhibits;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.Columns[0].HeaderText = "Name";
            dataGridView1.Columns[1].HeaderText = "Source";
            dataGridView1.Columns[2].HeaderText = "Year";
            dataGridView1.Columns[3].HeaderText = "Genre";
            dataGridView1.Columns[4].HeaderText = "Pages";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string userIdFilter = textBox2.Text; // Get user ID filter
            List<Loan> filteredLoans = museum.Loans.Where(x => x.UserId == userIdFilter).ToList();
            List<Exhibit> exhibits = new List<Exhibit>();
            foreach (var loan in filteredLoans)
            {
                Exhibit exhibit = museum.Exhibits.FirstOrDefault(x => x.Id == loan.ExhibitId);
                exhibits.Add(exhibit);
            }
            FillDgvFromObj(exhibits);
        }
    }
}