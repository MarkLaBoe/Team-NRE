using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamNRE_SeniorProject
{
    public partial class Login : Form
    {
        private string tempAdminName = "admin";
        private string tempAdminPass = "pass";

        private string tempUserName = "user";
        private string tempUserPass = "pass";

        private AdminHome aHome = new AdminHome();
        private UserHome uHome = new UserHome();

        public Login()
        {
            InitializeComponent();
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to quit?", "Do You Wish To Quit?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usernameTxt.Text == tempAdminName && passwordTxt.Text == tempAdminPass) {
                aHome.Show();
                this.Hide();
            }
            else if (usernameTxt.Text == tempUserName && passwordTxt.Text == tempUserPass)
            {
                uHome.Show();
                this.Hide();
            }
            else{
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
