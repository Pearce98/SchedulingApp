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
            aptGridView.DataSource = returnAllInfo(CurrentUser.returnUserID());
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
            //Creates DataTable
            DataTable customers = new DataTable();
            //MySQL command literal
            string sqlCMD = @"SELECT DISTINCT customerId, customerName, address, postalCode, phone, city, country
                              FROM customer
                              INNER JOIN address
                                  ON customer.addressId = address.addressId
                              INNER JOIN city
                                  ON address.cityId = city.cityId
                              INNER JOIN country
                                  ON country.countryId = city.countryID";
            //Connect to server and execute command
            MySqlConnection conn = new MySqlConnection(sqlClass.connectionString);
            MySqlCommand custCMD = new MySqlCommand(sqlCMD, conn);

            //adapt the data on the output and close connection
            var dataAdapter = new MySqlDataAdapter(custCMD).Fill(customers);
            custGridView.DataSource = customers;

            conn.Close();
            

        }

        public DataTable returnMonthInfo(int userID)
        {
            //Creates Datatable
            DataTable appointments = new DataTable();
            //MySQL command literal
            string sqlCMD = "SELECT appointmentID, customerID, userID, type, start " +
                "FROM appointment " +
                $"WHERE userId = {userID} AND MONTH('start') = MONTH(curdate())";

            //Connect to server and execute command
            MySqlConnection conn = new MySqlConnection(sqlClass.connectionString);
            MySqlCommand aptCMD = new MySqlCommand(sqlCMD, conn);

            //adapt data on output and close connection
            int dataApater = new MySqlDataAdapter(aptCMD).Fill(appointments);
            conn.Close();

            return appointments;
        }

        public DataTable returnWeekInfo(int userID)
        {
            //Creates Datatable
            DataTable appointments = new DataTable();
            //MySQL command literal
            string sqlCMD = "SELECT appointmentID, customerID, userID, type, start " +
                "FROM appointment " +
                $"WHERE userId = {userID} AND YEARWEEK('start',1) = YEARWEEK(curdate(),1)";

            //Connect to server and execute command
            MySqlConnection conn = new MySqlConnection(sqlClass.connectionString);
            MySqlCommand aptCMD = new MySqlCommand(sqlCMD, conn);

            //adapt data on output and close connection
            int dataApater = new MySqlDataAdapter(aptCMD).Fill(appointments);
            conn.Close();

            return appointments;
        }

        public DataTable returnAllInfo(int userID)
        {
            //Creates Datatable
            DataTable appointments = new DataTable();
            //MySQL command literal
            string sqlCMD = "SELECT appointmentID, customerID, userID, type, start " +
                "FROM appointment " +
                $"WHERE userID = {Convert.ToString(userID)}";

            //Connect to server and execute command
            MySqlConnection conn = new MySqlConnection(sqlClass.connectionString);
            MySqlCommand aptCMD = new MySqlCommand(sqlCMD, conn);

            //adapt data on output and close connection
            int dataApater = new MySqlDataAdapter(aptCMD).Fill(appointments);
            conn.Close();

            return appointments;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            ReportMenu reportMenu = new ReportMenu();
            reportMenu.Show();
        }

        private void addAptButton_Click(object sender, EventArgs e)
        {
            // --------------------------------------------------------------------- Add something to update appointment datagridview
            AddAppointment addAppointment = new AddAppointment();
            addAppointment.ShowDialog();
        }

        private void updateAptButton_Click(object sender, EventArgs e)
        {
            UpdateAppointment updateAppointment = new UpdateAppointment();
            updateAppointment.Show();
        }

        private void addCustButton_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ShowDialog();
            returnCustomerInfo();
        }

        private void updateCustButton_Click(object sender, EventArgs e)
        {
            int custID = (int)custGridView.SelectedRows[0].Cells[0].Value;
            UpdateCustomer updateCustomer = new UpdateCustomer(custID);
            updateCustomer.ShowDialog();
            returnCustomerInfo();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CurrentUser.returnName());
        }

        private void allAppointmentsButton_CheckedChanged(object sender, EventArgs e)
        {
            aptGridView.DataSource = returnAllInfo(CurrentUser.returnUserID());
        }

        private void currentWeekButton_CheckedChanged(object sender, EventArgs e)
        {
            aptGridView.DataSource = returnWeekInfo(CurrentUser.returnUserID());
        }

        private void currentMonthButton_CheckedChanged(object sender, EventArgs e)
        {
            aptGridView.DataSource = returnMonthInfo(CurrentUser.returnUserID());
        }

        private void deleteCustButton_Click(object sender, EventArgs e)
        {
            //Selected Row will be asked to be deleted
            int custID = (int)custGridView.SelectedRows[0].Cells[0].Value;
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
    }
}
