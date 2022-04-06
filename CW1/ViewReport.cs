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
    public partial class ViewReport : Form
    {
        private int adultNo;

        private int adultTotalEarning;

        private int adultvisitors;

        private int childNo;

        private int childTotalEarning;

        private int childVisitors;

        private int fridayNo;

        private int fridayTotalEarning;

        private int groupof10No;

        private int groupof10TotalEarning;

        private int groupof10visitors;

        private int groupof15No;

        private int groupof15TotalEarning;

        private int groupof15visitors;

        private int groupof5No;

        private int groupof5TotalEarning;

        private int groupof5visitors;

        private int groupofGreaterthan15No;

        private int groupofGreaterthan15TotalEarning;

        private int groupofGreaterthan15visitors;

        private int mondayNo;

        private int mondayTotalEarning;

        private int saturdayNo;

        private int saturdayTotalEarning;

        private int sundayNo;

        private int sundayTotalEarning;

        private int thursdayNo;

        private int thursdayTotalEarning;

        private int tuesdayNo;

        private int tuesdayTotalEarning;

        private int wednesdayNo;

        private int wednesdayTotalEarning;

        public ViewReport()
        {
            InitializeComponent();
        }

        private void btpervious_Click(object sender, EventArgs e)
        {

            AdminPanel adminPanel= new AdminPanel();
            adminPanel.Show();
            this.Hide();
        }

        private void btdevelopreport_Click(object sender, EventArgs e)
        {
            SetValues();
        }
        private void SetValues()
        {
            childNo = 0;
            adultNo = 0;
            groupof5No = 0;
            groupof10No = 0;
            groupof15No = 0;
            groupofGreaterthan15No = 0;
            childTotalEarning = 0;
            adultTotalEarning = 0;
            groupof5TotalEarning = 0;
            groupof10TotalEarning = 0;
            groupof15TotalEarning = 0;
            groupofGreaterthan15TotalEarning = 0;
            childVisitors = 0;
            adultvisitors = 0;
            groupof5visitors = 0;
            groupof10visitors = 0;
            groupof15visitors = 0;
            groupofGreaterthan15visitors = 0;
            sundayNo = 0;
            mondayNo = 0;
            tuesdayNo = 0;
            wednesdayNo = 0;
            thursdayNo = 0;
            fridayNo = 0;
            saturdayNo = 0;
            sundayTotalEarning = 0;
            mondayTotalEarning = 0;
            tuesdayTotalEarning = 0;
            wednesdayTotalEarning = 0;
            thursdayTotalEarning = 0;
            fridayTotalEarning = 0;
            saturdayTotalEarning = 0;

            string line;
            using (StreamReader sr = new StreamReader("visitorscheckout.csv"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    string[] checkin = line.Split(',');

                    if (rbdailyreport.Checked)
                    {
                        if (dtime.Value.DayOfWeek.ToString() == checkin[7])
                        {
                            if (checkin[3] == "Child (5-12)")
                            {
                                childVisitors += int.Parse(checkin[2]);
                                childNo++;
                                childTotalEarning += int.Parse(checkin[10]);
                            }
                            else if (checkin[3] == "Adult > 12")
                            {
                                adultvisitors += int.Parse(checkin[2]);
                                adultNo++;
                                adultTotalEarning += int.Parse(checkin[10]);
                            }
                            else if (checkin[2] == "5")
                            {
                                groupof5visitors += int.Parse(checkin[2]);
                                groupof5No++;
                                groupof5TotalEarning += int.Parse(checkin[10]);
                            }
                            else if (checkin[2] == "10")
                            {
                                groupof10visitors += int.Parse(checkin[2]);
                                groupof10No++;
                                groupof10TotalEarning += int.Parse(checkin[10]);
                            }
                            else if (checkin[2] == "15")
                            {
                                groupof15visitors += int.Parse(checkin[2]);
                                groupof15No++;
                                groupof15TotalEarning += int.Parse(checkin[10]);
                            }
                            else if (checkin[2] == ">15")
                            {
                                groupofGreaterthan15visitors += int.Parse(checkin[2]);
                                groupofGreaterthan15No++;
                                groupofGreaterthan15TotalEarning += int.Parse(checkin[10]);
                            }
                        }
                        DataTable dt = new DataTable();
                        dtGride.DataSource = dt;
                        dt.Columns.Add("Age Group");
                        dt.Columns.Add("Group Count");
                        dt.Columns.Add("Visitors");
                        dt.Columns.Add("Total Earning");
                        dt.Rows.Add("Child (5-12)", childNo, childVisitors, childTotalEarning);
                        dt.Rows.Add("Adult > 12", adultNo, adultvisitors, adultTotalEarning);
                        dt.Rows.Add("Group 5", groupof5No, groupof5visitors, groupof5TotalEarning);
                        dt.Rows.Add("Group 10", groupof10No, groupof10visitors, groupof10TotalEarning);
                        dt.Rows.Add("Group 15", groupof15No, groupof15visitors, groupof15TotalEarning);
                        dt.Rows.Add("Group >15", groupofGreaterthan15No, groupofGreaterthan15visitors, groupofGreaterthan15TotalEarning);
                    }
                    else if (rbweeklyreport.Checked)
                    {
                        if (checkin[7] == "Sunday")
                        {
                            sundayNo += int.Parse(checkin[2]);
                            sundayTotalEarning += int.Parse(checkin[10]);
                        }
                        else if (checkin[7] == "Monday")
                        {
                            mondayNo += int.Parse(checkin[2]);
                            mondayTotalEarning += int.Parse(checkin[10]);
                        }
                        else if (checkin[7] == "Tuesday")
                        {
                            tuesdayNo += int.Parse(checkin[2]);
                            tuesdayTotalEarning += int.Parse(checkin[10]);
                        }
                        else if (checkin[7] == "Wednesday")
                        {
                            wednesdayNo += int.Parse(checkin[2]);
                            wednesdayTotalEarning += int.Parse(checkin[10]);
                        }
                        else if (checkin[7] == "Thursday")
                        {
                            thursdayNo += int.Parse(checkin[2]);
                            thursdayTotalEarning += int.Parse(checkin[10]);
                        }
                        else if (checkin[7] == "Friday")
                        {
                            fridayNo += int.Parse(checkin[2]);
                            fridayTotalEarning += int.Parse(checkin[10]);
                        }
                        else if (checkin[7] == "Saturday")
                        {
                            saturdayNo += int.Parse(checkin[2]);
                            saturdayTotalEarning += int.Parse(checkin[10]);
                        }

                        DataTable dt = new DataTable();
                        dt.Columns.Add("Day");
                        dt.Columns.Add("No of Visitors");
                        dt.Columns.Add("Total Earning");
                        dtGride.DataSource = dt;
                        dt.Rows.Add("Sunday", sundayNo, sundayTotalEarning);
                        dt.Rows.Add("Monday", mondayNo, mondayTotalEarning);
                        dt.Rows.Add("Tuesday", tuesdayNo, tuesdayTotalEarning);
                        dt.Rows.Add("Wednesday", wednesdayNo, wednesdayTotalEarning);
                        dt.Rows.Add("Thursday", thursdayNo, thursdayTotalEarning);
                        dt.Rows.Add("Friday", fridayNo, fridayTotalEarning);
                        dt.Rows.Add("Saturday", saturdayNo, saturdayTotalEarning);
                    }
                }
            }
        }

        private void bttransferfile_Click(object sender, EventArgs e)
        {
            if (dtGride.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Report.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dtGride.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[dtGride.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dtGride.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; i < dtGride.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += dtGride.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void btvisitors_Click(object sender, EventArgs e)
        {
            dtGride.Sort(dtGride.Columns[1], ListSortDirection.Descending);
        }

        private void btearnings_Click(object sender, EventArgs e)
        {
            dtGride.Sort(dtGride.Columns[2], ListSortDirection.Descending);
        }
    }       
}
