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
    public partial class ViewChart : Form
    {
        private string[] chartDetails = new string[] { };

        private double fridayCount;

        private double fridayEarning;

        private double mondayCount;

        private double mondayEarning;

        private double satdayCount;

        private double satdayEarning;

        private double sundayCount;

        private double sundayEarning;

        private double thursdayCount;

        private double thursdayEarning;

        private double tuesdayCount;

        private double tuesdayEarning;

        private double wedCount;

        private double wedEarning;
        public ViewChart()
        {
            InitializeComponent();
        }

        private void btpervious_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
            this.Hide();
        }

        private void rbearnig_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
            chartearning.Show();
            chartvisitors.Hide();
        }
        private void LoadData()
        {
            sundayCount = 0;
            mondayCount = 0;
            tuesdayCount = 0;
            wedCount = 0;
            thursdayCount = 0;
            fridayCount = 0;
            satdayCount = 0;
            sundayEarning = 0;
            mondayEarning = 0;
            tuesdayEarning = 0;
            wedEarning = 0;
            thursdayEarning = 0;
            fridayEarning = 0;
            satdayEarning = 0;

            chartvisitors.Series["Visitor"].Points.Clear();
            chartearning.Series["Earning"].Points.Clear();

            string currentLine;
            using (StreamReader sr = new StreamReader("visitorsCheckout.csv"))
            {
                while ((currentLine = sr.ReadLine()) != null)
                {
                    string[] Visitor = currentLine.Split(',');

                    chartDetails = Visitor;
                    LoadReport();
                }
            }

            if (rbvisitors.Checked)
            {
                chartvisitors.Series["Visitor"].Points.AddXY("Sunday", sundayCount);
                chartvisitors.Series["Visitor"].Points.AddXY("Monday", mondayCount);
                chartvisitors.Series["Visitor"].Points.AddXY("Tuesday", tuesdayCount);
                chartvisitors.Series["Visitor"].Points.AddXY("Wednesday", wedCount);
                chartvisitors.Series["Visitor"].Points.AddXY("Thursday", thursdayCount);
                chartvisitors.Series["Visitor"].Points.AddXY("Friday", fridayCount);
                chartvisitors.Series["Visitor"].Points.AddXY("Saturday", satdayCount);
            }

            if (rbearnig.Checked)
            {
                chartearning.Series["Earning"].Points.AddXY("Sunday", sundayEarning);
                chartearning.Series["Earning"].Points.AddXY("Monday", mondayEarning);
                chartearning.Series["Earning"].Points.AddXY("Tuesday", tuesdayEarning);
                chartearning.Series["Earning"].Points.AddXY("Wednesday", wedEarning);
                chartearning.Series["Earning"].Points.AddXY("Thursday", thursdayEarning);
                chartearning.Series["Earning"].Points.AddXY("Friday", fridayEarning);
                chartearning.Series["Earning"].Points.AddXY("Saturday", satdayEarning);
            }
        }
        private void LoadReport()
        {
            if (chartDetails[7] == "Sunday")
            {
                sundayCount += double.Parse(chartDetails[2]);
                sundayEarning += double.Parse(chartDetails[10]);
            }
            else if (chartDetails[7] == "Monday")
            {
                mondayCount += double.Parse(chartDetails[2]);
                mondayEarning += double.Parse(chartDetails[10]);
            }
            else if (chartDetails[7] == "Tuesday")
            {
                tuesdayCount += double.Parse(chartDetails[2]);
                tuesdayEarning += double.Parse(chartDetails[10]);
            }
            else if (chartDetails[7] == "Wednesday")
            {
                wedCount += double.Parse(chartDetails[2]);
                wedEarning += double.Parse(chartDetails[10]);
            }
            else if (chartDetails[7] == "Thursday")
            {
                thursdayCount += double.Parse(chartDetails[2]);
                thursdayEarning += double.Parse(chartDetails[10]);
            }
            else if (chartDetails[7] == "Friday")
            {
                fridayCount += double.Parse(chartDetails[2]);
                fridayEarning += double.Parse(chartDetails[10]);
            }
            else if (chartDetails[7] == "Saturday")
            {
                satdayCount += double.Parse(chartDetails[2]);
                satdayEarning += double.Parse(chartDetails[10]);
            }
        }

        private void rbvisitors_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
            chartearning.Hide();
            chartvisitors.Show();
        }
    }
}
