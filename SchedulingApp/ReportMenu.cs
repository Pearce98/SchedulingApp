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
    public partial class ReportMenu : Form
    {
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
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateScheduleButton_Click(object sender, EventArgs e)
        {

        }

        private void aptMonthUpdateButton_Click(object sender, EventArgs e)
        {

        }

        private void numbCustUpdateButton_Click(object sender, EventArgs e)
        {

        }
    }
}
