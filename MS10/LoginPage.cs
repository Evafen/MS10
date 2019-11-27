using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace MS10
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void TxtUserEnter(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals("Username"))
            {
                txtUsername.Text = "";
            }

        }

        private void TxtUserLeave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(""))
            {
                txtUsername.Text = @"Username";
            }

        }

        private void PassEnter(object sender, EventArgs e)
        {

        }

        private void PassLeave(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

        }

        private static SqlConnection NewMethod1()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"\\MiniShoppix1.mdf\";Integrated Security=True;Connect Timeout=30;");
            return con;
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(""))
            {
                txtUsername.Text = @"Username";
            }
        }
    }
}
