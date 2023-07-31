using Core.Enum;
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
    public partial class adminpanel : Form
    {
        public adminpanel()
        {
            InitializeComponent();
            checkedListBox1.DataSource = Enum.GetValues(typeof(genre));
            checkedListBox2.DataSource = Enum.GetValues(typeof(genre));
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
            homepage homepage = new homepage();
            Hide();
            homepage.Show();
        }
    }
}
