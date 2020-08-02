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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string username = txtUname.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CRUD APP\CRUD_APP\UserData.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "DELETE from SignUp where User Name = '"+username+"';";
            SqlCommand cmd = new SqlCommand(qry,con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Successfully!");
            }
            catch(SqlException sqlex)
            {
                MessageBox.Show("" + sqlex);
            }
        }
    }
}
