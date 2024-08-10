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

            //validate start and end dates/times are in proper format
            DateTime startTime;
            DateTime endTime;
            DateTime startDate;
            DateTime endDate;
            DateTime start;
            DateTime end;
            DateTime eastStart;
            DateTime eastEnd;

            try
            {
                startDate = DateTime.ParseExact(startDateTextBox.Text, "MM-dd-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                endDate = DateTime.ParseExact(endDateTextBox.Text, "MM-dd-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                startTime = DateTime.ParseExact(startTimeTextBox.Text, "hh:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture);
                endTime = DateTime.ParseExact(endTimeTextBox.Text, "hh:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture); ;

                start = startDate.Date.Add(startTime.TimeOfDay);
                end = endDate.Date.Add(endTime.TimeOfDay);

                //convert times to EST
                eastStart = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(start, "Eastern Standard Time");
                eastEnd = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(end, "Eastern Standard Time");

            }
            catch
            {
                MessageBox.Show("Please make sure all dates are in MM-DD-YYYY format and times are in HH:MM:SS tt format");
                return;
            }

            DateTime earliest = DateTime.Parse("09:00:00 am");
            DateTime latest = DateTime.Parse("05:00:00 pm");
            if (eastStart.TimeOfDay < earliest.TimeOfDay || eastEnd.TimeOfDay > latest.TimeOfDay ||
                eastStart.DayOfWeek == DayOfWeek.Saturday || eastStart.DayOfWeek == DayOfWeek.Sunday ||
                eastEnd.DayOfWeek == DayOfWeek.Saturday || eastEnd.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Hours are between 09:00:00 am and 05:00:00 pm EST, Monday through Friday. " +
                    "Please adjust the start and end times between those hours.");
            }

            string query = "INSERT INTO appointment " +
                $"VALUES ('{aptID}', '{custID}', '{userID}', '{not}', '{not}', '{not}', '{not}', '{meetingType}'," +
                $" '{not}', '{eastStart.ToString(@"yyyy-MM-dd hh:mm:ss")}', '{eastEnd.ToString(@"yyyy-MM-dd hh:mm:ss")}'," +
                $" '{createDate.ToString(@"yyyy-MM-dd hh:mm:ss")}', '{userName}', '{createDate.ToString(@"yyyy-MM-dd hh:mm:ss")}', '{userName}')";
            sqlClass.insertItem(query);

            MessageBox.Show("Appointment Created");
            Close();
            
        }

    }
}
