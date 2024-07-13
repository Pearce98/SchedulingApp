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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
            
            //Get ID for new Customer
            MySqlConnection conn = new MySqlConnection(sqlClass.connectionString);
            conn.Open();
            MySqlDataReader reader = null;
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM customer", conn);
            reader = cmd.ExecuteReader();
            int count = 1;
            while (reader.Read())
            {
                count += Convert.ToInt32(reader["COUNT(*)"]);
            }
            reader.Close();
            conn.Close();
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
                string.IsNullOrEmpty(countryTextBox.Text)
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

            int ID = Convert.ToInt32(idTextBox.Text);
            string name = nameTextBox.Text;
            string phone = phoneTextBox.Text;
            string address = addressTextBox.Text;
            string city = cityTextBox.Text;
            string country = countryTextBox.Text;
            string active = "1";
            DateTime now = DateTime.Now;
            string creator = CurrentUser.returnName();


            MySqlConnection conn = new MySqlConnection(sqlClass.connectionString);
            conn.Open();
            //Country
            //check if country in country tabel
            string qCountry = $"SELECT country FROM country " +
                              $"WHERE country = '{country}'";
            MySqlCommand cmdCountry = new MySqlCommand(qCountry, conn);
            MySqlDataReader countryReader = cmdCountry.ExecuteReader();
            bool check = false;
            while (countryReader.Read())
            {
                if (Convert.ToString(countryReader[0]) == country)
                {
                    check = true;
                }
            }
            countryReader.Close();

            //If country not in table
            int countryCount;
            if (!check)
            {
                //Counts country
                string countryCountQuery = $"SELECT countryId FROM country ORDER BY countryId DESC LIMIT 1";
                MySqlCommand countryCountCMD = new MySqlCommand(countryCountQuery, conn);
                countryCount = Convert.ToInt32(countryCountCMD.ExecuteScalar()) + 1;
                //Insert country into table
                string countryInsertQuery = $"INSERT INTO country " +
                                            $"VALUES ({countryCount}, '{country}', NOW(), '{CurrentUser.returnName()}', NOW(), '{CurrentUser.returnName()}')";
                MySqlCommand countryInsertCMD = new MySqlCommand(countryInsertQuery, conn);
                countryInsertCMD.ExecuteNonQuery();
            }
            else //get country ID if it is in the table
            {
                string findCountryID = $"SELECT countryId FROM country " +
                                       $"WHERE country = '{country}'";
                var idCMD = new MySqlCommand(findCountryID, conn);
                countryCount = Convert.ToInt32(idCMD.ExecuteScalar());
            }




            conn.Close();
            return;
            /*
            string cmdString = $"INSERT INTO customer" +
                $"VALUES ('{ID}', '{name}', '{address}', '{active}', '{now}', '{creator}', '{now}', '{creator}')";

            
            MySqlCommand cmd = new MySqlCommand(cmdString, conn);
            cmd.ExecuteNonQuery();
            
            
            
            
            
            conn.Close();



            MessageBox.Show("New customer added");
            Close();
            */
        }
    }
}
