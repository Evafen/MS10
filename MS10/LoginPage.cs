using System;
using System.Windows.Forms;

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

        private void txtUserLeave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(""))
            {
                txtUsername.Text = @"Username";
            }

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

        }

        private void TxtUsername_TextChanged_1(object sender, EventArgs e)
        {

        }
    }

}




    





































