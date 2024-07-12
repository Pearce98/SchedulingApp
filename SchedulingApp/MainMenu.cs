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
            aptGridView.DataSource = returnAptInfo(CurrentUser.returnUserID());
            aptGridView.Columns[0].HeaderText = "Appointment ID";
            aptGridView.Columns[1].HeaderText = "Customer ID";
            aptGridView.Columns[2].HeaderText = "User ID";
            aptGridView.Columns[3].HeaderText = "Title";
            aptGridView.Columns[4].HeaderText = "Date of Appointment";


            //Customer Info View
            custGridView.DataSource = returnCustomerInfo(CurrentUser.returnUserID());
            custGridView.Columns[0].HeaderText = "Name";
            custGridView.Columns[1].HeaderText = "Address";
            custGridView.Columns[2].HeaderText = "Zip";
            custGridView.Columns[3].HeaderText = "Phone";
            custGridView.Columns[4].HeaderText = "City";
            custGridView.Columns[5].HeaderText = "Country";

        }

        private DataTable returnCustomerInfo(int v)
        {
            //Creates DataTable
            DataTable customers = new DataTable();
            //MySQL command literal
            string sqlCMD = @"SELECT DISTINCT customerName, address, postalCode, phone, city, country
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
            int dataAdapter = new MySqlDataAdapter(custCMD).Fill(customers);
            conn.Close();
            

            return customers;
        }

        private DataTable returnAptInfo(int userID)
        {
            //Creates Datatable
            DataTable appointments = new DataTable();
            //MySQL command literal
            string sqlCMD = "SELECT appointmentID, customerID, userID, title, start " +
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
            AddAppointment addAppointment = new AddAppointment();
            addAppointment.Show();
        }

        private void updateAptButton_Click(object sender, EventArgs e)
        {
            UpdateAppointment updateAppointment = new UpdateAppointment();
            updateAppointment.Show();
        }

        private void addCustButton_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
        }

        private void updateCustButton_Click(object sender, EventArgs e)
        {
            UpdateCustomer updateCustomer = new UpdateCustomer();
            updateCustomer.Show();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CurrentUser.returnName());
        }
    }
}
