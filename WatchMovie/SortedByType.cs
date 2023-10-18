using Core.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchMovie
{
    public partial class SortedByType : Form
    {
        public SortedByType()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(movies));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var db = new WatchMovieHD();
            var AllRows = db.Films.Where(f => f.Type == comboBox1.Text).ToList();
            dataGridView1.DataSource = AllRows;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var db = new WatchMovieHD();

            var AllRows = db.Films.Where(f => f.Genre == comboBox1.Text).ToList();
            dataGridView1.DataSource = AllRows;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            homepage homepage = new homepage();
            Hide();
            homepage.Show();
        }
    }
}

