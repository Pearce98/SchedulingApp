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
            } 
        }
    }
}
