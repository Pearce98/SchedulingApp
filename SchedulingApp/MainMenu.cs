using MySql.Data.MySqlClient;
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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

            //Appointment info view
            allAppointmentsButton.Checked = true;
            returnAllInfo(CurrentUser.returnUserID());
            aptGridView.Columns[0].HeaderText = "Appointment ID";
            aptGridView.Columns[1].HeaderText = "Customer ID";
            aptGridView.Columns[2].HeaderText = "User ID";
            aptGridView.Columns[3].HeaderText = "Type";
            aptGridView.Columns[4].HeaderText = "Date of Appointment";

            //Customer Info View
            returnCustomerInfo();
            custGridView.Columns[0].HeaderText = "Customer ID";
            custGridView.Columns[1].HeaderText = "Name";
            custGridView.Columns[2].HeaderText = "Address";
            custGridView.Columns[3].HeaderText = "Zip";
            custGridView.Columns[4].HeaderText = "Phone";
            custGridView.Columns[5].HeaderText = "City";
            custGridView.Columns[6].HeaderText = "Country";



        }

        public void returnCustomerInfo()
        {
            //Fills the customer table
            string sqlCMD = @"SELECT DISTINCT customerId, customerName, address, postalCode, phone, city, country
                              FROM customer
                              INNER JOIN address
                                  ON customer.addressId = address.addressId
                              INNER JOIN city
                                  ON address.cityId = city.cityId
                              INNER JOIN country
                                  ON country.countryId = city.countryID";
            custGridView.DataSource = sqlClass.gridFiller(sqlCMD);
        }

        public void returnMonthInfo(int userID)
        {

            //Returns all appointments in the current month for the user
            string sqlCMD = "SELECT appointmentId, customerId, userId, type, start " +
                "FROM appointment " +
                $"WHERE userId = {userID} AND MONTH(start) = MONTH(curdate())";
            aptGridView.DataSource = sqlClass.gridFiller(sqlCMD);
        }

        public void returnWeekInfo(int userID)
        {
            //Returns all appointments in the current week for the user
            string sqlCMD = "SELECT appointmentId, customerId, userId, type, start " +
                "FROM appointment " +
                $"WHERE userId = {userID} AND YEARWEEK(start,1) = YEARWEEK(curdate(),1)";
            aptGridView.DataSource = sqlClass.gridFiller(sqlCMD);
        }

        public void returnAllInfo(int userID)
        {
            //Returns all appointments that the user has
            string sqlCMD = "SELECT appointmentId, customerId, userId, type, start " +
                "FROM appointment " +
                $"WHERE userID = {Convert.ToString(userID)}";
            aptGridView.DataSource = sqlClass.gridFiller(sqlCMD);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            ReportMenu reportMenu = new ReportMenu();
            reportMenu.ShowDialog();
        }

        private void addAptButton_Click(object sender, EventArgs e)
        {
            AddAppointment addAppointment = new AddAppointment();
            addAppointment.ShowDialog();
            buttonChecker();
        }

        private void updateAptButton_Click(object sender, EventArgs e)
        {
            //exception handle to avoid attempting to update without any customers
            try
            {
                int aptID = (int)aptGridView.CurrentRow.Cells[0].Value;
                UpdateAppointment updateAppointment = new UpdateAppointment(aptID);
                updateAppointment.ShowDialog();
                buttonChecker();
            }
            catch
            {
                MessageBox.Show("No appointment selected");
            }
        }

        private void addCustButton_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ShowDialog();
            returnCustomerInfo();
        }

        private void updateCustButton_Click(object sender, EventArgs e)
        {
            //exception handle to avoid attempting to update without any customers
            try
            {
                int custID = (int)custGridView.Rows[custGridView.CurrentCell.RowIndex].Cells[0].Value;
                UpdateCustomer updateCustomer = new UpdateCustomer(custID);
                updateCustomer.ShowDialog();
                returnCustomerInfo();
            }
            catch
            {
                MessageBox.Show("No customer selected.");
            }
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CurrentUser.returnName());
        }

        private void allAppointmentsButton_CheckedChanged(object sender, EventArgs e)
        {
            returnAllInfo(CurrentUser.returnUserID());
        }

        private void currentWeekButton_CheckedChanged(object sender, EventArgs e)
        {
            returnWeekInfo(CurrentUser.returnUserID());
        }

        private void currentMonthButton_CheckedChanged(object sender, EventArgs e)
        {
            returnMonthInfo(CurrentUser.returnUserID());
        }

        private void deleteCustButton_Click(object sender, EventArgs e)
        {
            int custID = 0;
            try
            {
                //Selected Row will be asked to be deleted
                custID = (int)custGridView.SelectedRows[0].Cells[0].Value;
            }
            catch
            {
                MessageBox.Show("No customer selected");
                return;
            }
            var confirmResult = MessageBox.Show($"Are you sure you wish to delete customer? ID = {custID}", "Confirmation", MessageBoxButtons.YesNo);

            //try catch statement is for customers with appointments
            try
            {
                if (confirmResult == DialogResult.Yes)
                {
                    //deletes if yes is selected
                    string deleteCust = "DELETE FROM customer " +
                        $"WHERE customerId = '{custID}'";
                    sqlClass.insertItem(deleteCust);
                    MessageBox.Show("Customer deleted from system");
                    returnCustomerInfo();
                }
                else
                {
                    //doesnt delete if no is selected
                    MessageBox.Show("Customer Not Deleted");
                }
            }
            catch
            {
                MessageBox.Show("Cannot delete customers with appointments scheduled");
            }
        }

        private void buttonChecker()
        {
            //used to refresh appointments table when appointments added, updated, or deleted
            if (allAppointmentsButton.Checked == true)
            {
                returnAllInfo(CurrentUser.returnUserID());
            }
            else if (currentWeekButton.Checked == true)
            {
                returnWeekInfo(CurrentUser.returnUserID());
            }
            else
            {
                returnMonthInfo(CurrentUser.returnUserID());
            }
        }

        private void deleteAptButton_Click(object sender, EventArgs e)
        {
            int aptID = 0;
            try
            {
                //Selected Row will be deleted
                aptID = (int)aptGridView.SelectedRows[0].Cells[0].Value;
            }
            catch
            {
                MessageBox.Show("No appointment selected");
                return;
            }

            var confirmResult = MessageBox.Show($"Are you sure you wish to delete appointment {aptID}?","Confirmation", MessageBoxButtons.YesNo);
            
            try
            {
                if (confirmResult == DialogResult.Yes)
                {
                    //Deletes appointment if yes is selected
                    string delete = "DELETE FROM appointment " +
                                    $"WHERE appointmentId = {aptID}";
                    sqlClass.insertItem(delete);
                    MessageBox.Show("Appointment deleted");
                }
                else
                {
                    //Doesn't delete if no is selected
                    MessageBox.Show("Appointment not deleted");
                }
                //refreshes appointment table
                buttonChecker();
            }
            catch
            {
                MessageBox.Show("Unable to delete appointment.");
            }
        }
    }
}
