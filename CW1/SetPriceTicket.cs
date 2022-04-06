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

    public partial class SetPriceTicket : Form
    {
        private int adultFourHour;
        private int adultOneHour;
        private int adultThreeHour;
        private int adultTwoHour;
        private int adultunlimited;
        private int childFourHour;
        private int childOneHour;
        private int childThreeHour;
        private int childTwoHour;
        private int childunlimited;
        private int group10FourHour;
        private int group10OneHour;
        private int group10ThreeHour;
        private int group10TwoHour;
        private int group10unlimited;
        private int group15FourHour;
        private int group15OneHour;
        private int group15ThreeHour;
        private int group15TwoHour;
        private int group15unlimited;
        private int group5FourHour;
        private int group5OneHour;
        private int group5ThreeHour;
        private int group5TwoHour;
        private int group5unlimited;
        private int groupGreater15FourHour;
        private int groupGreater15OneHour;
        private int groupGreater15ThreeHour;
        private int groupGreater15TwoHour;
        private int groupGreater15unlimited;
        private bool isValid = true;
        private string[] priceArray = new string[] { };

        public SetPriceTicket()
        {
            InitializeComponent();
        }

        private void perviousbt_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
            this.Hide();
        }

        private void btcleardata_Click(object sender, EventArgs e)
        {
            File.WriteAllText("ticketPrice.csv", string.Empty);
            MessageBox.Show("All the ticket price are Cleared.");
        }

        private void btshowprice_Click(object sender, EventArgs e)
        {
            Values();
        }
        private void Values()
        {
            childOneHour = 0;
            childTwoHour = 0;
            childThreeHour = 0;
            childFourHour = 0;
            childunlimited = 0;
            adultOneHour = 0;
            adultTwoHour = 0;
            adultThreeHour = 0;
            adultFourHour = 0;
            adultunlimited = 0;
            group5OneHour = 0;
            group5TwoHour = 0;
            group5ThreeHour = 0;
            group5FourHour = 0;
            group5unlimited = 0;
            group10OneHour = 0;
            group10TwoHour = 0;
            group10ThreeHour = 0;
            group10FourHour = 0;
            group10unlimited = 0;
            group15OneHour = 0;
            group15TwoHour = 0;
            group15ThreeHour = 0;
            group15FourHour = 0;
            group15unlimited = 0;
            groupGreater15OneHour = 0;
            groupGreater15TwoHour = 0;
            groupGreater15ThreeHour = 0;
            groupGreater15FourHour = 0;
            groupGreater15unlimited = 0;

            string currentLine;
            using (StreamReader sReader = new StreamReader("ticketPrice.csv"))
            {
                while ((currentLine = sReader.ReadLine()) != null)
                {
                    string[] ticketPrice = currentLine.Split(',');
                    priceArray = ticketPrice;
                    LoadPrice();
                }
            }
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Category");
            dataTable.Columns.Add("1 Hr");
            dataTable.Columns.Add("2 Hr");
            dataTable.Columns.Add("3 Hr");
            dataTable.Columns.Add("4 Hr");
            dataTable.Columns.Add("Whole Day");
            DGV.DataSource = dataTable;
            dataTable.Rows.Add("Child (5-12)", childOneHour, childTwoHour, childThreeHour, childFourHour, childunlimited);
            dataTable.Rows.Add("Adult >12", adultOneHour, adultTwoHour, adultThreeHour, adultFourHour, adultunlimited);
            dataTable.Rows.Add("Group 5", group5OneHour, group5TwoHour, group5ThreeHour, group5FourHour, group5unlimited);
            dataTable.Rows.Add("Group 10", group10OneHour, group10TwoHour, group10ThreeHour, group10FourHour, group10unlimited);
            dataTable.Rows.Add("Group 15", group15OneHour, group15TwoHour, group15ThreeHour, group15FourHour, group15unlimited);
            dataTable.Rows.Add("Group greater than 15", groupGreater15OneHour, groupGreater15TwoHour, groupGreater15ThreeHour, groupGreater15FourHour, groupGreater15unlimited);
        }
        private void LoadPrice()
        {
            try
            {
                if (priceArray[0] == "Adult >12")
                {
                    adultOneHour = int.Parse(priceArray[1]);
                    adultTwoHour = int.Parse(priceArray[2]);
                    adultThreeHour = int.Parse(priceArray[3]);
                    adultFourHour = int.Parse(priceArray[4]);
                    adultunlimited = int.Parse(priceArray[5]);
                }
                else if (priceArray[0] == "Child (5-12)")
                {
                    childOneHour = int.Parse(priceArray[1]);
                    childTwoHour = int.Parse(priceArray[2]);
                    childThreeHour = int.Parse(priceArray[3]);
                    childFourHour = int.Parse(priceArray[4]);
                    childunlimited = int.Parse(priceArray[5]);
                }
                else if (priceArray[0] == "Group 5")
                {
                    group5OneHour = int.Parse(priceArray[1]);
                    group5TwoHour = int.Parse(priceArray[2]);
                    group5ThreeHour = int.Parse(priceArray[3]);
                    group5FourHour = int.Parse(priceArray[4]);
                    group5unlimited = int.Parse(priceArray[5]);
                }
                else if (priceArray[0] == "Group 10")
                {
                    group10OneHour = int.Parse(priceArray[1]);
                    group10TwoHour = int.Parse(priceArray[2]);
                    group10ThreeHour = int.Parse(priceArray[3]);
                    group10FourHour = int.Parse(priceArray[4]);
                    group10unlimited = int.Parse(priceArray[5]);
                }
                else if (priceArray[0] == "Group 15")
                {
                    group15OneHour = int.Parse(priceArray[1]);
                    group15TwoHour = int.Parse(priceArray[2]);
                    group15ThreeHour = int.Parse(priceArray[3]);
                    group15FourHour = int.Parse(priceArray[4]);
                    group15unlimited = int.Parse(priceArray[5]);
                }
                else if (priceArray[0] == "Group greater than 15")
                {
                    groupGreater15OneHour = int.Parse(priceArray[1]);
                    groupGreater15TwoHour = int.Parse(priceArray[2]);
                    groupGreater15ThreeHour = int.Parse(priceArray[3]);
                    groupGreater15FourHour = int.Parse(priceArray[4]);
                    groupGreater15unlimited = int.Parse(priceArray[5]);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid price!");
            }
        }

        private void btset_Click(object sender, EventArgs e)
        {
            SetPrice();
        }
        private void SetPrice()
        {
            isValid = true;
            validate();
            if (isValid)
            {
                using (FileStream fileStream = new FileStream("ticketPrice.csv", FileMode.Append, FileAccess.Write))
                {
                    using (StreamWriter sWriter = new StreamWriter(fileStream))
                    {
                        string[] ticketPrice = new string[] { cbCategory.Text, tb1hrprice.Text, tb2hrprice.Text, tb3hrprice.Text, tb4hrprice.Text, tbunlimitedprice.Text };

                        for (int i = 0; i < ticketPrice.Length; i++)
                        {
                            sWriter.Write(ticketPrice[i] + ",");
                        }
                        MessageBox.Show("Price set!");
                        sWriter.WriteLine("");
                    }
                }
            }
        }
        private void validate()
        {
            string line;
            using (StreamReader sr = new StreamReader("ticketPrice.csv"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    string[] price = line.Split(',');
                    if ((price[1] != "0" || price[2] != "0") && price[0] == cbCategory.Text)
                    {
                        isValid = false;
                    }
                }
                if (!isValid)
                {
                    MessageBox.Show("Already set!");
                }
                sr.Close();
            }
        }
    }
}

