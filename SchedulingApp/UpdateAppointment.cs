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
    public partial class UpdateAppointment : Form
    {
        public UpdateAppointment(int aptID)
        {
            InitializeComponent();
            
            //Get appointment info from server
            string sqlCMD = "SELECT type, start, end, customerId FROM appointment " +
                            $"WHERE appointmentId = {aptID}";
            DataTable aptInfo = sqlClass.gridFiller(sqlCMD);

            string type = Convert.ToString(aptInfo.Rows[0]["type"]);
            string start = Convert.ToString(aptInfo.Rows[0]["start"]);
            string end = Convert.ToString(aptInfo.Rows[0]["end"]);
            string custId = Convert.ToString(aptInfo.Rows[0]["customerId"]);

            DateTime startDateTime = DateTime.Parse(start);
            string startDate = startDateTime.Date.ToString("MM-dd-yyyy");
            string startTime = Convert.ToString(startDateTime.TimeOfDay);

            DateTime endDateTime = DateTime.Parse(end);
            string endDate = endDateTime.Date.ToString("MM-dd-yyyy");
            string endTime = Convert.ToString(endDateTime.TimeOfDay);

            aptIDTextBox.Text = aptID.ToString();
            typeTextBox.Text = type;
            custIDBox.Text = custId;
            startDateTextBox.Text = startDate;
            endDateTextBox.Text = endDate;
            startTimeTextBox.Text = startTime;
            endTimeTextBox.Text = endTime;


        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
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
        }
    }
}
