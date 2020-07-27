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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (txtUname.Text == "" || txtPassword.Text == "" || txtCpassword.Text == "")
            {
                MessageBox.Show("Enter Required field");
            }
            else
            {
                string Uname = txtUname.Text;
                string Password = txtPassword.Text;
                string ConPassword = txtCpassword.Text;

                if (Password == ConPassword)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# Projects\UserDatabase.mdf;Integrated Security=True;Connect Timeout=30");
                    string qry = "Insert Into SignUp Values('"+Uname+"','"+Password+"','"+ConPassword+"')";
                    SqlCommand cmd = new SqlCommand(qry,con);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Inserted Successfully");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("" +ex);
                    }
                }
                else
                {
                    MessageBox.Show("Password and Confirm Password is not maching");
                }
            }
        }

        private void deletewindow_Click(object sender, EventArgs e)
        {
            Delete dl = new Delete();
            dl.Show();
            this.Hide();
        }

        private void updatewindow_Click(object sender, EventArgs e)
        {
            Update up = new Update();
            up.Show();
            this.Hide();
        }

        private void home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
