using Core.Enum;
using Core.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.data;



namespace WatchMovie
{
    public partial class homepage : Form
    {

        public homepage()
        {
            InitializeComponent();

        }
        public string userName { get; set; }
        public homepage(string userName)
        {
            InitializeComponent();
            this.userName = userName;

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            login login = new login();

            login.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            filmspage filmspage = new filmspage();
            Hide();
            filmspage.Show();
        }

        private void homepage_Load(object sender, EventArgs e)
        {


        }

        private void comboBox1_load(object sender, EventArgs e)
        {
            //comboBox1.Items.AddRange(Enum.GetNames(typeof(genre)));
            //comboBox1.Items.Add(movies);

        }

        private void genreBindingSource3_CurrentChanged(object sender, EventArgs e)
        {
            //foreach (string genres in Enum.GetNames(typeof(genre)))
            //{
            //    genreBindingSource3.Add(genres);
            //}

        }

        private void genreBindingSource_CurrentChanged(object sender, EventArgs e)
        {


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            adminpanel adminpanel = new adminpanel();
            Hide();
            adminpanel.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            likedMovies likedMovies = new likedMovies();
            Hide();
            likedMovies.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var db = new WatchMovieHD();

            var res = db.Films.FirstOrDefault(film => film.Name == textBox1.Text);

            if (res == null)
            {

                textBox1.Text = "movie not found";

            }
            else
            {
                var AllRows = db.Films.Where(f => f.Name == textBox1.Text).ToList();

                dataGridView1.DataSource = AllRows;

                using (WatchMovieHD contexts = new WatchMovieHD())
                {
                    Viewedfilms ViewFilms = new Viewedfilms();

                    var movie = textBox1.Text;

                    var resultMovie = contexts.Films.FirstOrDefault(x => x.Name == movie);

                    var resultUser = contexts.User.FirstOrDefault(x => x.UserName == userName);

                    ViewFilms.userid = resultUser.Id;

                    ViewFilms.FilmId = resultMovie.Id;

                    contexts.Viewedfilms.Add(ViewFilms);
                    contexts.SaveChanges();
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //var db = new WatchMovieHD();
            //var AllRows = db.Films.Where(f => f.Genre == textBox1.Text).ToList();


            sortedmovies sortedmovies = new sortedmovies();
            Hide();
            sortedmovies.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            SortedByType sortedByType = new SortedByType();
            Hide();
            sortedByType.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (WatchMovieHD contexts = new WatchMovieHD())
                {
                    likedFilms likedFilms = new likedFilms();

                    var movie = textBox1.Text;

                    var resultMovie = contexts.Films.FirstOrDefault(x => x.Name == movie);

                    var resultUser = contexts.User.FirstOrDefault(x => x.UserName == userName);

                    likedFilms.userid = resultUser.Id;

                    likedFilms.FilmId = resultMovie.Id;

                    contexts.LikedFilms.Add(likedFilms);
                    contexts.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("you havent choosed movie");
            }
        }
    }
}
