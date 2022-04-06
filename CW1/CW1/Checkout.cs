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
    public partial class Checkout : Form
    {
        private string AgeGroup;

        private string[] checkin = new string[] { };

        private string ContactNumber;

        private DateTime date = DateTime.Now;

        private string FullName;

        private string Group;

        private string VisitDate;

        private int VisitorCount;

        private bool VisitorIDValid = false;

        public Checkout()
        {
            InitializeComponent();
        }

        private void btcalAmount_Click(object sender, EventArgs e)
        {
            GetVisitors();
            tbta.Text = CalculatePrice().ToString();
            tbtime.Text = GetEntryTime();
            tbtime.Text = GetTotalHours().ToString();
            tbetime.Text = date.ToString();
            using (FileStream fs = new FileStream("visitorsCheckout.csv", FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sWriter = new StreamWriter(fs))
                {
                    if (VisitorIDValid)
                    {
                        string[] visitors = new string[] { tbvisitorid.Text, FullName, Group, AgeGroup, VisitorCount.ToString(), ContactNumber, tbtime.Text, VisitDate, tbetime.Text, tbtime.Text, tbta.Text };

                        for (int i = 0; i < visitors.Length; i++)
                        {
                            sWriter.Write(visitors[i] + ",");
                        }
                        MessageBox.Show("Visitor checked out!");
                        sWriter.WriteLine("");

                    }
                    else
                    {
                        MessageBox.Show("Visitor invalid!");
                    }
                }
                fs.Close();
            }
        }
        private double CalculatePrice()
        {
            double price = 0;
            double totalHours = GetTotalHours();
            GetVisitors();

            if (VisitorCount == 1)
            {
                if (AgeGroup == "Child (5-12)")
                {
                    switch (totalHours)
                    {
                        case 1:
                            price = 400;
                            tbta.Text = price.ToString();
                            break;

                        case 2:
                            price = 700;
                            tbta.Text = price.ToString();
                            break;

                        case 3:
                            price = 1050;
                            tbta.Text = price.ToString();
                            break;

                        case 4:
                            price = 1450;
                            tbta.Text = price.ToString();
                            break;

                        case double hours when hours > 4:
                            price = 2200;
                            tbta.Text = price.ToString();
                            break;
                    }
                }
                else if (AgeGroup == "Adult > 12")
                {
                    switch (totalHours)
                    {
                        case 1:
                            price = 550;
                            tbta.Text = price.ToString();
                            break;

                        case 2:
                            price = 1000;
                            tbta.Text = price.ToString();
                            break;

                        case 3:
                            price = 1500;
                            tbta.Text = price.ToString();
                            break;

                        case 4:
                            price = 2100;
                            tbta.Text = price.ToString();
                            break;

                        case double hours when hours > 4:
                            price = 2700;
                            tbta.Text = price.ToString();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Please select a valid age group!");
                }
            }
            else if (VisitorCount == 5)
            {
                if (AgeGroup == "Group")
                {
                    switch (totalHours)
                    {
                        case 1:
                            price = 2375;
                            tbta.Text = price.ToString();
                            break;

                        case 2:
                            price = 4250;
                            tbta.Text = price.ToString();
                            break;

                        case 3:
                            price = 6375;
                            tbta.Text = price.ToString();
                            break;

                        case 4:
                            price = 8875;
                            tbta.Text = price.ToString();
                            break;

                        case double hours when hours > 4:
                            price = 12250;
                            tbta.Text = price.ToString();
                            break;
                    }
                }
            }
            else if ((VisitorCount > 5 && VisitorCount <= 10))
            {
                if (AgeGroup == "Group")
                {
                    switch (totalHours)
                    {
                        case 1:
                            price = 4750;
                            tbta.Text = price.ToString();
                            break;

                        case 2:
                            price = 8500;
                            tbta.Text = price.ToString();
                            break;

                        case 3:
                            price = 12750;
                            tbta.Text = price.ToString();
                            break;

                        case 4:
                            price = 17750;
                            tbta.Text = price.ToString();
                            break;

                        case double hours when hours > 4:
                            price = 24500;
                            tbta.Text = price.ToString();
                            break;
                    }
                }
            }
            else if (VisitorCount > 10 && VisitorCount <= 15)
            {
                if (AgeGroup == "Group")
                {
                    switch (totalHours)
                    {
                        case 1:
                            price = 7125;
                            tbta.Text = price.ToString();
                            break;

                        case 2:
                            price = 12750;
                            tbta.Text = price.ToString();
                            break;

                        case 3:
                            price = 19125;
                            tbta.Text = price.ToString();
                            break;

                        case 4:
                            price = 26625;
                            tbta.Text = price.ToString();
                            break;

                        case double hours when hours > 4:
                            price = 36750;
                            tbta.Text = price.ToString();
                            break;
                    }
                }
            }
            else if (VisitorCount > 15)
            {
                if (AgeGroup == "Group")
                {
                    switch (totalHours)
                    {
                        case 1:
                            price = 475 * VisitorCount;
                            tbta.Text = price.ToString();
                            break;

                        case 2:
                            price = 850 * VisitorCount;
                            tbta.Text = price.ToString();
                            break;

                        case 3:
                            price = 1275 * VisitorCount;
                            tbta.Text = price.ToString();
                            break;

                        case 4:
                            price = 1775 * VisitorCount;
                            tbta.Text = price.ToString();
                            break;

                        case double hours when hours > 4:
                            price = 2450 * VisitorCount;
                            tbta.Text = price.ToString();
                            break;
                    }
                }
            }
            return price;
        }

        private void btpervious_Click(object sender, EventArgs e)
        {
            EmployeePanel employeePanel = new EmployeePanel();
            employeePanel.Show();
            this.Hide();
        }

        private string GetEntryTime()
        {
            string visitorEntryTime;
            DateTime visitorTime = DateTime.Parse(checkin[6]);
            visitorEntryTime = visitorTime.ToString("hh:mm tt");
            return visitorEntryTime;
        }
        private double GetTotalHours()
        {
            DateTime visitorEntryTime = DateTime.Parse(checkin[6]);
            TimeSpan totalHrs = Convert.ToDateTime(date) - Convert.ToDateTime(visitorEntryTime);
            double totalHours = Math.Ceiling(totalHrs.TotalHours);
            return totalHours;
        }
        private void GetVisitors()
        {
            string line;
            VisitorIDValid = false;
            using (StreamReader csvReader = new StreamReader("visitorsCheckin.csv"))
            {
                while ((line = csvReader.ReadLine()) != null)
                {
                    string[] visitorArray = line.Split(',');
                    if (tbvisitorid.Text == visitorArray[0])
                    {
                        VisitorIDValid = true;
                        checkin = visitorArray;
                        break;
                    }
                }
                if (VisitorIDValid == false)
                {
                    MessageBox.Show("Please enter a valid visitor id!");
                }
                else
                {
                    VisitorCount = int.Parse(checkin[2]);
                    FullName = checkin[1];
                    AgeGroup = checkin[3];
                    Group = checkin[4];
                    ContactNumber = checkin[5];
                    VisitDate = checkin[7];
                }
            }
        }

        private void tbts_TextChanged(object sender, EventArgs e)
        {

        }
    }
    

}

