using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_APP
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignUp sign_up = new SignUp();
            sign_up.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowData show = new ShowData();
            show.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.Show();
            this.Show();

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            Update update = new Update();
            update.Show();
            this.Hide();
        }
    }
}
