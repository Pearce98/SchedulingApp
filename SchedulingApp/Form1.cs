using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SchedulingApp
{
    public partial class Form1 : Form
    {
        public string error = "Invalid Username or Password";
        public Form1()
        {
            InitializeComponent();
            //Display Location
            locationLabel.Text = RegionInfo.CurrentRegion.DisplayName;

            if (CultureInfo.CurrentUICulture.LCID == 2058)
            {
                //Label Translations in Spanish (Mexico)
                usernameLabel.Text = "Nombre de usario";
                passwordLabel.Text = "Contraseña";
                loginButton.Text = "Acceso";
                cancelButton.Text = "Cancelar";
                loginLabel.Text = "Acceso";
                staticLocationLabel.Text = "Ubicación:";
                error = "Usario o contranseña invalido";
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //gets what is entered into username and password boxes
            string user = userTextBox.Text;
            string pass = passTextBox.Text;

            //opens MySQL connection
            MySqlConnection conn = new MySqlConnection(sqlClass.connectionString);
            conn.Open();
            //Enters command and reads output
            MySqlCommand command = new MySqlCommand($"SELECT userId FROM user WHERE userName = '{user}' AND password = '{pass}'", conn);
            MySqlDataReader reader = command.ExecuteReader();

            //If command has rows, then username and password are correct
            if (reader.HasRows)
            {
                //reads row and sets username and ID
                reader.Read();
                int ID = Convert.ToInt32(reader[0]);
                CurrentUser.setUserID(ID);
                CurrentUser.setName(user);
                reader.Close();
                conn.Close();

                //Write to login_history file
                string logName = "Login_History.txt";
                string time = DateTime.Now.ToString();
                using (StreamWriter sw = File.AppendText(logName))
                {
                    sw.WriteLine($"User ID: {ID} logged in at {time}");
                }

                //Opens main menu for user
                MainMenu mainMenu = new MainMenu();
                mainMenu.FormClosed += (s, args) => this.Close(); //Lambda Function if the main menu closes, it will close the whole program
                this.Hide();
                mainMenu.Show();

                string query = "SELECT COUNT(*) FROM appointment " +
                        $"WHERE userId = {CurrentUser.returnUserID()} AND start <= NOW() + INTERVAL 15 MINUTE AND start > NOW()";
                //alert if user has a meeting within 15
                if (sqlClass.alertCheck(query))
                {
                    MessageBox.Show("You have an appointment within 15 minutes.");
                }
            } 
            else 
            {
                //Username and pass are incorrect
                MessageBox.Show(error);
                passTextBox.Text = "";
            }

        }
    }
}
