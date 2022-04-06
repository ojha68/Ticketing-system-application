using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW1
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void btRegisterEmployee_Click(object sender, EventArgs e)
        {
            RegisterEmployee registerEmployee = new RegisterEmployee();
            registerEmployee.Show();
            this.Hide();
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            ViewReport viewReport= new ViewReport();
            viewReport.Show();
            this.Hide();
        }

        private void btnViewChart_Click(object sender, EventArgs e)
        {
            ViewChart viewChart = new ViewChart();
            viewChart.Show();
            this.Hide();
        }

        private void btnSetPriceTicket_Click(object sender, EventArgs e)
        {
            SetPriceTicket setPriceTicket = new SetPriceTicket();
            setPriceTicket.Show();
            this.Hide();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            const string message = "Do you want to logout?";
            const string caption = "Logout";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                signIn signIn = new signIn();
                signIn.Show();
                this.Hide();
            }
            else if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
