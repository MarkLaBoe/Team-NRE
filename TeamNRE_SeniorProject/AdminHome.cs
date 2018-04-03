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
    public partial class AdminHome : Form
    {
        private AddEditProject aEProject = new AddEditProject();
        private BurndownChart bChart = new BurndownChart();

        public AdminHome()
        {
            InitializeComponent();

        }

        private void addProjectBtn_Click(object sender, EventArgs e)
        {
            aEProject.Show();
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to quit?", "Do You Wish To Quit?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void editProjectBtn_Click(object sender, EventArgs e)
        {
            if (projectCbx.SelectedItem != null)
            {
                aEProject.Show();
            }
        }

        private void burndownBtn_Click(object sender, EventArgs e)
        {
            if (projectCbx.SelectedItem != null)
            {
                bChart.Show();
            }
        }

        private void deleteProjectBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to delete this project?", "Do You Wish To Delete This Project?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Application.Exit();
            }
        }

    }
}
