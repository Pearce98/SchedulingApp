using System;
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
    public partial class AddAppointment : Form
    {
        public AddAppointment()
        {
            InitializeComponent();

            //New Appointment ID number
            aptIDTextBox.Text = Convert.ToString(sqlClass.getMax("appointment") + 1);

            //fill customer combobox with customer IDs
            string custIdListQuery = "SELECT customerId FROM customer";
            sqlClass.fillComboBox(custIDBox, custIdListQuery);

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //Check to see if each box has data
            if (String.IsNullOrEmpty(typeTextBox.Text) ||
                String.IsNullOrEmpty(startDateTextBox.Text) ||
                String.IsNullOrEmpty(startTimeTextBox.Text) ||
                String.IsNullOrEmpty(endDateTextBox.Text) ||
                String.IsNullOrEmpty(endTimeTextBox.Text) ||
                String.IsNullOrEmpty(custIDBox.Text))
            {
                MessageBox.Show("Data needs to be entered into each box.");
                return;
            }

            int aptID = Convert.ToInt32(aptIDTextBox.Text);
            string meetingType = typeTextBox.Text;
            int custID = Convert.ToInt32(custIDBox.Text);
            int userID = CurrentUser.returnUserID();
            DateTime createDate = DateTime.Now;
            string not = "not needed";
            string userName = CurrentUser.returnName();
            DateTime now = DateTime.Now;

            //validate start and end dates/times are in proper format
            DateTime startTime;
            DateTime endTime;
            DateTime startDate;
            DateTime endDate;
            DateTime start;
            DateTime end;
            DateTime utcStart;
            DateTime utcEnd;

            try
            {
                startDate = DateTime.ParseExact(startDateTextBox.Text, "MM-dd-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                endDate = DateTime.ParseExact(endDateTextBox.Text, "MM-dd-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                startTime = DateTime.ParseExact(startTimeTextBox.Text, "hh:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture);
                endTime = DateTime.ParseExact(endTimeTextBox.Text, "hh:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture); ;

                start = startDate.Date.Add(startTime.TimeOfDay);
                end = endDate.Date.Add(endTime.TimeOfDay);

                //convert times to UTC
                utcStart = TimeZoneInfo.ConvertTimeToUtc(start, TimeZoneInfo.Local);
                utcEnd = TimeZoneInfo.ConvertTimeToUtc(end, TimeZoneInfo.Local);

            }
            catch
            {
                MessageBox.Show("Please make sure all dates are in MM-DD-YYYY format and times are in HH:MM:SS tt format");
                return;
            }

            //check to make sure it is within business hours
            DateTime earliest = DateTime.Parse("02:00:00 pm");
            DateTime latest = DateTime.Parse("10:00:00 pm");
            if (utcStart.TimeOfDay < earliest.TimeOfDay || utcEnd.TimeOfDay > latest.TimeOfDay ||
                utcStart.DayOfWeek == DayOfWeek.Saturday || utcStart.DayOfWeek == DayOfWeek.Sunday ||
                utcEnd.DayOfWeek == DayOfWeek.Saturday || utcEnd.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Hours are between 09:00:00 am and 05:00:00 pm EST, Monday through Friday. " +
                                "Please adjust the start and end times between those hours.");
                return;
            }

            //makes sure start is not after end
            if (utcStart > utcEnd)
            {
                MessageBox.Show("Start time cannot be before end time.");
                return;
            }

            string strStart = start.ToString("yyyy-MM-dd HH:mm:ss");
            string strEnd = end.ToString("yyyy-MM-dd HH:mm:ss");
            string strNow = now.ToString("yyyy-MM-dd HH:mm:ss");

            //checks for overlapping user appointments
            string overlapCMD1 = "SELECT COUNT(*) FROM appointment " +
                               $"WHERE userId = {userID} " +
                               $"AND start < '{strEnd}' AND end > '{strStart}'";
            if (sqlClass.alertCheck(overlapCMD1))
            {
                MessageBox.Show("This meeting overlaps with another one of your appointments, please change the date / times.");
                return;
            }

            //checks for overlapping customer appointments
            string overlapCMD2 = "SELECT COUNT(*) FROM appointment " +
                               $"WHERE customerId = {custID} " +
                               $"AND start < '{strEnd}' AND end > '{strStart}'";
            if (sqlClass.alertCheck(overlapCMD2))
            {
                MessageBox.Show("This meeting overlaps with another one of the customer's appointments, please change the date / times.");
                return;
            }


            //creates the appointment
            string query = "INSERT INTO appointment " +
                $"VALUES ('{aptID}', '{custID}', '{userID}', '{not}', '{not}', '{not}', '{not}', '{meetingType}'," +
                $" '{not}', '{strStart}', '{strEnd}'," +
                $" '{strNow}', '{userName}', '{strNow}', '{userName}')";
            sqlClass.insertItem(query);

            MessageBox.Show("Appointment Created");
            Close();
            
        }

    }
}
