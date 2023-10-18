using Core.data;
using Core.Enum;
using Dapper;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchMovie
{
    public partial class adminpanel : Form
    {
        public adminpanel()
        {
            InitializeComponent();
            checkedListBox1.DataSource = Enum.GetValues(typeof(genre));

            comboBox1.DataSource = Enum.GetValues(typeof(movies));


        }

        private void adminpanel_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //homepage homepage = new homepage();
            //Hide();
            //homepage.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (WatchMovieHD context = new WatchMovieHD())
            {
                Film film = new Film();

                film.Name = textBox1.Text;
                film.Genre = checkedListBox1.Text;
                film.Year = textBox3.Text;
                film.Type = comboBox1.Text;
                film.Country = textBox17.Text;
                film.Duration = textBox5.Text;
                film.Producer = textBox4.Text;
                film.Achivement = textBox13.Text;

                context.Films.Add(film);
                context.SaveChanges();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //using (WatchMovieHD contexts = new WatchMovieHD())
            //{
            //    Film user = new Film();
            //    user.Name = textBox12.Text;
            //    user.Genre = checkedListBox3.Text;
            //    user.Year = textBox11.Text;
            //    user.Type = comboBox3.Text;
            //    user.Duration = textBox2.Text;
            //    user.Producer = textBox10.Text;
            //    user.Achivement = textBox14.Text;
            //    contexts.Films.Add(user);
            //    contexts.SaveChanges();

            //}
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string movie = textBox16.Text;

            using (WatchMovieHD contexts = new WatchMovieHD())
            {
                var result = contexts.Films.FirstOrDefault(x => x.Name == movie);

                if (result != null)
                {
                    contexts.Films.Remove(result);
                    contexts.SaveChanges();
                }
            }
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=ing0077K;Database=WatchMovieHD;";

            using (var connection = new NpgsqlConnection(connectionString))
            {
                var user = new Users()
                {
                    UserName = textBox2.Text,
                };
                var sqlQuery = "delete from public.\"User\" where \"UserName\" = @UserName";

                connection.Execute(sqlQuery, user);

                MessageBox.Show("Sucesfully Deleted");
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            homepage homepage = new homepage();
            Hide();
            homepage.Show();
        }
    }
}
