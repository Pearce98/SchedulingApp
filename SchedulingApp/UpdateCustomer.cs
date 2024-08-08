using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SchedulingApp
{
    public partial class UpdateCustomer : Form
    {
        public static int custID {  get; set; }
        public UpdateCustomer(int CustID)
        {
            InitializeComponent();
            custID = CustID;
            idTextBox.Text = custID.ToString();
            fillCustInfo();

        }

        private void fillCustInfo()
        {
            //get values to fill text boxes
            //name
            string getName = $"SELECT customerName FROM customer WHERE customerId = {custID}";
            nameTextBox.Text = sqlClass.returnItem(getName);
            
            //address
            string getAddress = "SELECT distinct address FROM customer " +
                "INNER JOIN address ON customer.addressId = address.addressId " +
                $"WHERE customerId = {custID}";
            addressTextBox.Text = sqlClass.returnItem(getAddress);

            //phone number
            string getPhone = "SELECT distinct phone FROM customer " +
                "INNER JOIN address ON customer.addressId = address.addressId " +
                $"WHERE customerId = {custID}";
            phoneTextBox.Text = sqlClass.returnItem(getPhone);

            //postal
            string getPostal = "SELECT distinct postalCode FROM customer " +
                "INNER JOIN address ON customer.addressId = address.addressId " +
                $"WHERE customerId = {custID}";
            postalTextBox.Text = sqlClass.returnItem(getPostal);
            
            //City
            string getCity = "SELECT distinct city FROM customer " +
                "INNER JOIN address ON customer.addressId = address.addressId " +
                "INNER JOIN city ON address.cityId = city.cityId " +
                $"WHERE customerId = {custID}";
            cityTextBox.Text = sqlClass.returnItem(getCity);

            //Country
            string getCountry = "SELECT distinct country FROM customer " +
                "INNER JOIN address ON customer.addressId = address.addressId " +
                "INNER JOIN city ON address.cityId = city.cityId " +
                "INNER JOIN country ON city.countryId = country.countryId " +
                $"WHERE customerId = {custID}";
            countryTextBox.Text = sqlClass.returnItem(getCountry);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //Check each box to see if there is something in each
            if (string.IsNullOrEmpty(idTextBox.Text) ||
                string.IsNullOrEmpty(nameTextBox.Text) ||
                string.IsNullOrEmpty(phoneTextBox.Text) ||
                string.IsNullOrEmpty(addressTextBox.Text) ||
                string.IsNullOrEmpty(cityTextBox.Text) ||
                string.IsNullOrEmpty(countryTextBox.Text) ||
                string.IsNullOrEmpty(postalTextBox.Text)
                )
            {
                MessageBox.Show("Please enter data for each entry.");
                return;
            }
            //Check for valid phone number
            foreach (char c in phoneTextBox.Text)
            {
                if (!Char.IsNumber(c) &&
                    c != char.Parse("-"))
                {
                    MessageBox.Show("Phone numbers may only be digits and dashes");
                    return;
                }
            }


            int custID = Convert.ToInt32(idTextBox.Text);
            string name = nameTextBox.Text;
            string phone = phoneTextBox.Text;
            string address = addressTextBox.Text;
            string address2 = "";
            string city = cityTextBox.Text;
            string country = countryTextBox.Text;
            string postal = postalTextBox.Text;
            string now = DateTime.Now.ToString(@"yyyy-MM-dd hh:mm:ss");
            string creator = CurrentUser.returnName();


            //IDs for customer location
            int countryID;
            int cityID;
            int addressID;

            if (!sqlClass.checker("country", country))
            {
                //add country to table
                countryID = sqlClass.getCount("country") + 1;
                string cmdString = "INSERT INTO country " +
                    $"VALUES ('{countryID}', '{country}', '{now}', '{creator}', '{now}', '{creator}')";
                sqlClass.insertItem(cmdString);
            }
            else
            {
                countryID = sqlClass.getItemID("country", country);
            }

            if (!sqlClass.checker("city", city))
            {
                //add city to table
                cityID = sqlClass.getCount("city") + 1;
                string cmdString = "INSERT INTO city " +
                    $"VALUES ('{cityID}', '{city}', '{countryID}', '{now}', '{creator}', '{now}', '{creator}')";
                sqlClass.insertItem(cmdString);
            }
            else
            {
                cityID = sqlClass.getItemID("city", city);
            }

            if (!sqlClass.checker("address", address))
            {
                //add address to table
                addressID = sqlClass.getCount("address") + 1;
                string cmdString = "INSERT INTO address " +
                    $"VALUES ('{addressID}', '{address}', '{address2}', '{cityID}', '{postal}', '{phone}', '{now}', '{creator}', '{now}', '{creator}')";
                sqlClass.insertItem(cmdString);
            }
            else
            {
                addressID = sqlClass.getItemID("address", address);
            }

            //update customer in database
            string custUpdate = "UPDATE customer " +
                $"SET customerName = '{name}', addressId = {addressID}, lastUpdate = '{now}', lastUpdateBy = '{creator}' " +
                $"WHERE customerId = '{custID}'";
            sqlClass.insertItem(custUpdate);


            MessageBox.Show("Customer information updated");
            Close();
        }
    }
}
