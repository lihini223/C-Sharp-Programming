using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_APP
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtFname.Text = null;
            txtLname.Text = null;
            txtUname.Text = null;
            txtPassword.Text = null;
            txtAge.Text = null;
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {

        }

        string FirstName, LastName, UserName, Password;
        int Age;

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            FirstName = txtFname.Text;
            LastName = txtLname.Text;
            UserName = txtUname.Text;
            Password = txtPassword.Text;
            Age = int.Parse(txtAge.Text);

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CRUD APP\CRUD_APP\UserData.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "Insert Into SignUp Values('"+FirstName+"','"+LastName+"','"+UserName+"','"+Password+"','"+Age+"');";
            SqlCommand cmd = new SqlCommand(qry,con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully!");
            }
            catch(SqlException sqlex)
            {
                MessageBox.Show("" + sqlex);
            }
        }
    }
}
