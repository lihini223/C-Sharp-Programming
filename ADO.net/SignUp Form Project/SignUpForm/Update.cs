using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SignUpForm
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# Projects\UserDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            string Update = "UPDATE SignUp SET Password = '"+password+"' WHERE UserName = '"+username+"'";
            SqlCommand cmd = new SqlCommand(Update,con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated Successfully!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
