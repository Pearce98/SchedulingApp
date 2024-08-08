using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SchedulingApp
{
     class sqlClass
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
        
        public static int getCount(string tableName)
        {
            //get length of the table
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand($"SELECT COUNT(*) FROM {tableName}", conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count += Convert.ToInt32(reader["COUNT(*)"]);
            }
            reader.Close();
            conn.Close();
            return count;
        }

        public static int getMax(string tableName)
        {
            //get length of the table
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand($"SELECT MAX({tableName}Id) AS count FROM {tableName}", conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count += Convert.ToInt32(reader["count"]);
            }
            reader.Close();
            conn.Close();
            return count;
        }

        public static bool checker(string tableType, string item)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            //check if item in table
            string q = $"SELECT {tableType} FROM {tableType} " +
                              $"WHERE {tableType} = '{item}'";
            MySqlCommand cmd = new MySqlCommand(q, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            bool check = false;
            while (reader.Read())
            {
                if (Convert.ToString(reader[0]) == item)
                {
                    check = true;
                }
            }
            reader.Close();
            conn.Close();
            return check;
        }

        public static void insertItem(string query)
        {
            //inserts item into table
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static int getItemID(string table, string name)
        {
            string query = $"SELECT {table+"Id"} FROM {table} WHERE {table} = '{name}'";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            int ID = 0;
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ID = Convert.ToInt32(reader[0]);
            }
            return ID;
        }

        public static string returnItem(string cmdString)
        {
            string item = "";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(cmdString, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                item = Convert.ToString(reader[0]);
            }
            return item;
        }

        public static void fillComboBox(ComboBox cBox, string query)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string line = Convert.ToString(reader[0]);
                    cBox.Items.Add(line);
                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Add customers before creating an appointment.");
            }
            

        }
    }


}
