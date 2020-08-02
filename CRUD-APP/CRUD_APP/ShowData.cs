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
    public partial class ShowData : Form
    {
        public ShowData()
        {
            InitializeComponent();
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CRUD APP\CRUD_APP\UserData.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT * FROM SignUp";

            SqlDataAdapter DA = new SqlDataAdapter(qry, constring);
            DataSet DS = new DataSet();

            DA.Fill(DS,"SignUp");
            UserdataGridView.DataSource = DS.Tables["SignUp"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
