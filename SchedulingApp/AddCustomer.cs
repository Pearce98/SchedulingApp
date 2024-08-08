using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingApp
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
            //comment
            //Get ID for new Customer
            int count = sqlClass.getCount("customer") + 1;
            idTextBox.Text = count.ToString();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
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
            
            if (!sqlClass.checker("country",country))
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

            if (!sqlClass.checker("city",city))
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

            if (!sqlClass.checker("address",address))
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

            //add customer to table
            string cmd = "INSERT INTO customer " +
                $"VALUES ('{custID}', '{name}', '{addressID}', '1', '{now}', '{creator}', '{now}', '{creator}')";
            sqlClass.insertItem(cmd);
            
            

            MessageBox.Show("Customer added to database");
            Close();

        }
        
    }
}
