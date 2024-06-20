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

namespace time_clock_connection
{
    public partial class Form1 : Form
    {
        SqlConnection Connection;
        string connectionString = "server=OMRIRAJUAN\\SQLEXPRESS;" +
            "initial-catalog=time-clock;" +
            "user id=sa;" +
            " password = 1234";

        public Form1()
        {
            InitializeComponent();
        }

        private void Connect()
        {
            try
            {
                Connection = new SqlConnection(connectionString);
                Connection.Open();
                MessageBox.Show("פתווווווחחחח");
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
                
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)13) return;
            Connect();
        }
    }
}
