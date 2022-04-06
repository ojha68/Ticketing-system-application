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
    public partial class Checkin : Form
    {
        private DateTime currentDate = DateTime.Now;

        private string SysDay;

        public Checkin()
        {
            InitializeComponent();
        }
        private string AgeGroup
        {
            get { return ddagegroup.Text; }
            set { ddagegroup.Text = value; }
        }

        private string ContactNumber
        {
            get { return tbcontact.Text; }
            set { tbcontact.Text = value; }
        }

        private string EntryTime
        {
            get { return hel.Text; }
            set { hel.Text = value; }
        }

        private string FullName
        {
            get { return tbfullname.Text; }
            set { tbfullname.Text = value; }
        }

        private string Group
        {
            get { return ddgroup.Text; }
            set { ddgroup.Text = value; }
        }

        private string VisitDate
        {
            get { return tbdate.Text; }
            set { tbdate.Text = value; }
        }

        private string VisitorCount
        {
            get { return tbnumberofv.Text; }
            set { tbnumberofv.Text = value; }
        }

        private string VisitorID
        {
            get { return tbvisitorid.Text; }
            set { tbvisitorid.Text = value; }
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            bool visitorIDValid = true;
            bool formValid = FormValidation();
            if (formValid)
            {
                using (StreamReader sReader = new StreamReader("visitorsCheckin.csv"))
                {
                    string currentLine;
                    while ((currentLine = sReader.ReadLine()) != null)
                    {
                        var visitor = currentLine.Split(',');

                        if (VisitorID.Equals(visitor[0]))
                        {
                            visitorIDValid = false;
                        }
                    }

                    if (visitorIDValid == false)
                    {
                        MessageBox.Show("Visitor ID is already used!");
                    }
                }
                using (FileStream fileStream = new FileStream("visitorsCheckin.csv", FileMode.Append, FileAccess.Write))
                {
                    using (StreamWriter sWriter = new StreamWriter(fileStream))
                    {
                        if (formValid)
                        {
                            if (visitorIDValid)
                            {
                                string[] checkin = new string[] { VisitorID.ToString(), FullName, VisitorCount, AgeGroup, Group, ContactNumber, EntryTime, VisitDate };

                                for (int i = 0; i < checkin.Length; i++)
                                {
                                    sWriter.Write(checkin[i] + ",");
                                }
                                sWriter.WriteLine("");
                                MessageBox.Show("Visitor has been registered!\nYour visitor no. is:\n" + VisitorID, "Successful");
                                ClearTBValues();

                            }
                        }
                    }
                    fileStream.Close();
                }
            }
        }

        private void btpervious_Click(object sender, EventArgs e)
        {
            EmployeePanel employeePanel = new EmployeePanel();
            employeePanel.Show();
            this.Hide();
        }

        private void ddagegroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddagegroup.SelectedIndex == 0 && rbindividual.Checked == true)
            {
                MessageBox.Show("Please select a valid age group!");
            }
        }

        private void ddgroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddgroup.SelectedIndex == 0 && rbgroup.Checked == true)
            {
                MessageBox.Show("Please select a valid group!");
            }
            string selectedItem = ddgroup.SelectedItem.ToString();
            switch (selectedItem)
            {
                case "1":
                    {
                        VisitorCount = "1";
                        break;
                    }
                case "5":
                    {
                        VisitorCount = "5";
                        break;
                    }
                case "10":
                    {
                        VisitorCount = "10";
                        break;
                    }
                case "15":
                    {
                        VisitorCount = "15";
                        break;
                    }
                case "15<":
                    {
                        VisitorCount = "15<";
                        break;
                    }
            }
        }


        private void rbindividual_CheckedChanged(object sender, EventArgs e)
        {
            ddagegroup.Enabled = true;
            ddgroup.SelectedIndex = 0;
            ddgroup.Enabled = false;
            VisitorCount = "1";
            tbnumberofv.Enabled = false;

        }

        private void rbgroup_CheckedChanged(object sender, EventArgs e)
        {
            ddagegroup.SelectedIndex = 0;
            ddagegroup.Enabled = false;
            ddgroup.Enabled = true;
            VisitorCount = "0";
            tbnumberofv.Enabled = true;
        }

        private void Checkin_Load(object sender, EventArgs e)
        {
            SetTBValues();
        }
        private void ClearTBValues()
        {
            VisitorID = "";
            rbindividual.Checked = false;
            rbgroup.Checked = false;
            VisitorCount = "";
            AgeGroup = "";
            Group = "";
            EntryTime = "";
            SetTBValues();
            ContactNumber = "";
        }
        private bool FormValidation()
        {
            bool formValid = false;

            if (ContactNumber == "" || AgeGroup == "" || VisitorID == "" || (rbgroup.Checked == false && rbindividual.Checked == false))
            {
                MessageBox.Show("Please fill all the fields!");
            }
            else if (VisitorCountInt() <= 0 && rbgroup.Checked)
            {
                MessageBox.Show("Please enter a valid number of visitors!");
            }
            else if (VisitorCountInt() < 5 && rbgroup.Checked)
            {
                MessageBox.Show("Number of visitors must be greater than 4 to form a group!");
            }
            else if (VisitorCountInt() == 1)
            {
                ddgroup.SelectedIndex = 0;
                formValid = true;
            }
            else if (VisitorCountInt() == 5 || ddgroup.SelectedIndex == 0)
            {
                ddgroup.SelectedIndex = 1;
                formValid = true;
            }
            else if (VisitorCountInt() > 5 && VisitorCountInt() <= 10)
            {
                ddgroup.SelectedIndex = 2;
                formValid = true;
            }
            else if (VisitorCountInt() > 10 && VisitorCountInt() <= 15)
            {
                ddgroup.SelectedIndex = 3;
                formValid = true;
            }
            else if (VisitorCountInt() > 15)
            {
                ddgroup.SelectedIndex = 4;
                formValid = true;
            }
            return formValid;
        }
        private void SetTBValues()
        {
            EntryTime = currentDate.ToString("hh:mm tt");
            SysDay = currentDate.DayOfWeek.ToString();
            VisitDate = SysDay;
        }
        private int VisitorCountInt()
        {
            int VisitorCountInt;
            try
            {
                VisitorCountInt = int.Parse(VisitorCount);
            }
            catch (Exception)
            {
                return 0;
            }

            return VisitorCountInt;
        }

       

        
    }

}
