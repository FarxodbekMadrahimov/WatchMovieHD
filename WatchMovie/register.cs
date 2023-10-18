using Microsoft.EntityFrameworkCore;
using System;
using Core.models;

using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;
using Core.data;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;
using Core.ExtencionMethod;

namespace WatchMovie
{
    public partial class register : Form

    {
        private WatchMovieHD DbContext;
        public register()
        {
            InitializeComponent();
            DbContext = new WatchMovieHD();



        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            login login = new login();
            Hide();
            login.Show();
        }
        public User user = new User();

        private void button1_Click(object sender, EventArgs e)
        {

            int c = 0;
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox6.Text))
            {
                
                label4.Visible = true;
                c++;
            }
            var db = new WatchMovieHD();
            if (db.User.FirstOrDefault(user => user.email == textBox2.Text) == null)
            {

                label11.Text = label10.Text;

            }
            if (!IsValidEmail(textBox2.Text))
            {
                label11.Visible = true;
                c++;

            }

            //else
            //{
            //    c++;
            //    label11.Visible = true;
            //}

            if (db.User.FirstOrDefault(user => user.UserName == textBox1.Text) == null)
            {
                label10.Text = label11.Text;
            }
            if (textBox2.Text.Length < 8)
            {
                label5.Visible = true;
                c++;
            }

            if (textBox3.Text.Length < 8)
            {
                label12.Visible = true;
                c++;
            }
            if (textBox4.Text != textBox3.Text)
            {
                label9.Visible = true;
                c++;
            }

            else if (label4.Visible == false && label11.Visible == false && label10.Visible == false && label5.Visible == false && label12.Visible == false && label9.Visible == false)
            {
                Users user = new Users();
                using (WatchMovieHD contexts = new WatchMovieHD())
                {

                    user.FirstName = textBox5.Text;
                    user.LastName = textBox6.Text;
                    user.UserName = textBox1.Text;
                    user.email = textBox2.Text;
                    user.password = textBox3.Text;
                    contexts.User.Add(user);
                    contexts.SaveChanges();

                }
                homepage homepage = new homepage(textBox1.Text);
                Hide();
                homepage.Show();


            }

        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private bool IsValidEmail(string email)
        {
            // Using a regular expression for email format validation
            string pattern = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            return Regex.IsMatch(email, pattern);
        }
        private bool IsValidUsername(string username)
        {

            string pattern = "^[a-zA-Z][a-zA-Z0-9]{3,9}$";
            return Regex.IsMatch(username, pattern);
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            register register = new register();
            Hide();
            register.Show();



        }
    }
}