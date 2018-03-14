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
        private string tempUser = "admin";
        private string tempPass = "pass";

        public Login()
        {
            InitializeComponent();
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to quit?", "Quit?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usernameTxt.Text == tempUser && passwordTxt.Text == tempPass) {
                MessageBox.Show("Welcome " + tempUser + "!");
            }
            else{
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
