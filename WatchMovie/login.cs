using Core.data;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WatchMovie
{
    public partial class login : Form
    {
        private WatchMovieHD DbContext;
        public login()
        {
            InitializeComponent();
            DbContext = new WatchMovieHD();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            register register = new register();
            Hide();
            register.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Farxodbek206" && textBox2.Text == "ing0077K")
            {
                adminpanel adminpanel = new adminpanel();
                Hide();
                adminpanel.Show();
            }
            var db = new WatchMovieHD();

            var res = db.User.SingleOrDefault(user => user.UserName == textBox1.Text && user.password == textBox2.Text);

            if (res == null)
            {
                label4.Visible = true;

            }
            else
            {
                homepage homepage = new homepage(textBox1.Text);
                Hide();
                homepage.Show();
            }
            //{
            //    var result = db.user
            //        .include(x => x.password)
            //        .firstordefault(x => x.password. == login && x.loginpassword.password == password);
            //    if (result != null)
            //    {
            //        loganform.employee = result;
            //        return result;
            //    }
            //    else return null;
            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
