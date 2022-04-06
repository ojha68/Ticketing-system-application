using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW1
{
    public partial class signIn : Form
    {
        public signIn()
        {

            InitializeComponent();
        }
        public string Username
        {
            get { return tbUsername.Text; }
            set { tbUsername.Text = value; }
        }

        public string Password
        {
            get { return tbPassword.Text; }
            set {tbPassword.Text = value; }
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("adminCredintial.csv"))
            {
                string currentLine;
                bool userValid = false;
                while ((currentLine = reader.ReadLine()) != null && userValid == false)
                {
                    var userDetails = currentLine.Split(',');

                    if (Username.Equals(userDetails[0]) && Password.Equals(userDetails[1]))
                    {
                        userValid = true;
                        if (Username.Equals("admin"))
                        {
                          
                            AdminPanel adminPanel = new AdminPanel();
                            adminPanel.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        userValid = true;
                       
                        EmployeePanel employeePanel = new EmployeePanel();
                        employeePanel.Show();
                        this.Hide();
                    }
                }
                if (userValid == false)
                {
                    MessageBox.Show("Incorrect Username or Password");
                }
                reader.Close();
            }

        }

       
    }
}
