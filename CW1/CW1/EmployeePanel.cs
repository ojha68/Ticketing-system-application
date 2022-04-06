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
    public partial class EmployeePanel : Form
    {
        public EmployeePanel()
        {
            InitializeComponent();
        }

        private void btcheckIn_Click(object sender, EventArgs e)
        {
            Checkin checkIn = new Checkin();
            checkIn.Show();
            this.Hide();
        }

        private void btlogout_Click(object sender, EventArgs e)
        {
            const string message = "Do you want to logout?";
            const string caption = "Logout";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                signIn login = new signIn();
                login.Show();
                this.Hide();
            }
            else if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btcheckOut_Click(object sender, EventArgs e)
        {
            Checkout checkOut = new Checkout();
            checkOut.Show();
            this.Hide();
        }

        private void btviewReport_Click(object sender, EventArgs e)
        {
            ViewReport dailyReport = new ViewReport();
            dailyReport.Show();
            this.Hide();
        }
    }
}
