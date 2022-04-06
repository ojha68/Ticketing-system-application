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
    public partial class RegisterEmployee : Form
    {
        public RegisterEmployee()
        {
            InitializeComponent();
        }
         

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {

            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (FileStream fileStream = new FileStream("employeeData.csv", FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sWriter = new StreamWriter(fileStream))
                {
                    if (tbUserName.Text != "" && tbPassword.Text != "" && tbName.Text != "")
                    {
                        string[] uDetailsArray = new string[] { tbUserName.Text, tbPassword.Text, tbName.Text };
                        if (tbPassword.Text.Equals(tbPassword.Text))
                        {
                            for (int i = 0; i < uDetailsArray.Length; i++)
                            {
                                sWriter.Write(uDetailsArray[i] + ",");
                            }
                            sWriter.WriteLine("");
                            MessageBox.Show("Employee added!"); ;
                        }
                        else
                        {
                            MessageBox.Show("The password and confirm password is not matching!", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Credentials!", "Error");
                    }
                }
            }
        }

       
    }
}
        