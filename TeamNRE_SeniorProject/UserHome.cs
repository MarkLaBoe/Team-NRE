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
    public partial class UserHome : Form
    {
        private AddEditTime aETime = new AddEditTime();
        private BurndownChart bDChart = new BurndownChart();

        public UserHome()
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

        private void addTimeBtn_Click(object sender, EventArgs e)
        {
            aETime.Show();
        }

        private void burndownBtn_Click(object sender, EventArgs e)
        {
            bDChart.Show();
        }
    }
}
