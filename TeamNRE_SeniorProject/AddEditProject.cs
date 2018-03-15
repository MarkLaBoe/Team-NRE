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
    public partial class AddEditProject : Form
    {
        //private AdminHome aHome = new AdminHome();
        
        //Confirmation message will appear after saving a project asking the user if they would like to add another project.
        //the form will send the user back to the home page.
        
        public AddEditProject()
        {
            InitializeComponent();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
