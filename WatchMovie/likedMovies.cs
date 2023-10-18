using Core.data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WatchMovie
{
    public partial class likedMovies : Form
    {
        public likedMovies()
        {
            InitializeComponent();
        }

        private void likedMovies_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var db = new WatchMovieHD();

            var AllRows = db.LikedFilms.Include(x => x.Film);
            dataGridView1.DataSource = AllRows;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            homepage homepage = new homepage();
            Hide();
            homepage.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var db = new WatchMovieHD();

            var AllRows = db.LikedFilms.Include(x => x.Film);
            dataGridView1.DataSource = AllRows;

        }
    }
}

