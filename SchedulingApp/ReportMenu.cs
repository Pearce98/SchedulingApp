using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingApp
{
    public partial class ReportMenu : Form
    {

        public Hashtable numbMonths = new Hashtable();

        public ReportMenu()
        {
            InitializeComponent();

            //fill user combobox with user IDs
            string userIdListQuery = "SELECT userId FROM user";
            sqlClass.fillComboBox(userComboBox, userIdListQuery);

            //fill meeting types
            string meetTypeListQuery = "SELECT DISTINCT type FROM appointment";
            sqlClass.fillComboBox(meetingTypeComboBox, meetTypeListQuery);

            //fill months combobox
            var months = System.Globalization.DateTimeFormatInfo.InvariantInfo.MonthNames;
            monthComboBox.DataSource = months;

            //fill country box
            string countryNameListQuery = "SELECT DISTINCT country FROM country";
            sqlClass.fillComboBox(countryNameBox, countryNameListQuery);

            numbMonths.Add("January","1");
            numbMonths.Add("February", "2");
            numbMonths.Add("March", "3");
            numbMonths.Add("April", "4");
            numbMonths.Add("May", "5");
            numbMonths.Add("June", "6");
            numbMonths.Add("July", "7");
            numbMonths.Add("August", "8");
            numbMonths.Add("September", "9");
            numbMonths.Add("October", "10");
            numbMonths.Add("November", "11");
            numbMonths.Add("December", "12");


        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateScheduleButton_Click(object sender, EventArgs e)
        {
            //userScheduledGrid updater
            Func<string, int> converter = x => Convert.ToInt32(x); //Lambda to convert
            int userId = converter(userComboBox.Text);
            string updateString = $"SELECT appointmentId, type, start FROM appointment WHERE userId = {userId}";
            userScheduleGrid.DataSource = sqlClass.gridFiller(updateString);
        }

        //lambda function used for second and third reports
        Func<Label, string, bool> labelUpdater = (x, y) =>
        {
            try
            {
                string count = sqlClass.returnItem(y);
                x.Text = count;
                return true;
            }
            catch
            {
                return false;
            }
        };

        private void aptMonthUpdateButton_Click(object sender, EventArgs e)
        {
            string month = (string)numbMonths[monthComboBox.Text];
            string appointmentType = meetingTypeComboBox.Text;
            string query = "SELECT COUNT(*) FROM appointment " +
                          $"WHERE type = '{appointmentType}' AND MONTH(start) = '{month}'";
            bool check = labelUpdater(numbMeetings, query);
            if (!check)
            {
                MessageBox.Show("There was an error updating the count");
            }
        }

        private void numbCustUpdateButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(*) FROM customer " +
                "INNER JOIN address " +
                "ON customer.addressId = address.addressId " +
                "INNER JOIN city " +
                "ON address.cityId = city.cityID " +
                "INNER JOIN country " +
                "ON city.countryId = country.countryId " +
                $"WHERE country = '{countryNameBox.Text}'";
            bool check = labelUpdater(numbCusts, query);
            if (!check)
            {
                MessageBox.Show("There was an error updating the count");
            }
        }
    }
}
