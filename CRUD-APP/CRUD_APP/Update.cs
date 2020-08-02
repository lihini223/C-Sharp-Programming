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

namespace CRUD_APP
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text,
                   Password = txtPassword.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CRUD APP\CRUD_APP\UserData.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "Update SignUp SET password = '"+Password+"' where User Name='"+username+"'";
            SqlCommand cmd = new SqlCommand(qry,con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Password Updated Successfully!");
            }
            catch(SqlException sqlex)
            {
                MessageBox.Show("" + sqlex);
            }
        }
    }
}
