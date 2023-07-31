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
using static Core.Enum.genre;

namespace WatchMovie
{
    public partial class homepage : Form
    {

        public homepage()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(genre));
            comboBox2.DataSource = Enum.GetValues(typeof(movies));

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
            comboBox1.BeginUpdate();
            foreach (var genres in Enum.GetNames(typeof(genre)))
            {
                comboBox1.Items.Add(genres);
            }
            comboBox1.EndUpdate();


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
    }
}
