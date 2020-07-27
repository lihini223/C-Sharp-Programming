using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignUpForm
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            lblwelcome.BackColor = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void signup_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
            this.Hide();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Delete dl = new Delete();
            dl.Show();
            this.Hide();
        }

        private void update_Click(object sender, EventArgs e)
        {
            Update up = new Update();
            up.Show();
            this.Hide();
        }
    }
}
