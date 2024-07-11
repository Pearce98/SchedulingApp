using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
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

            if (CultureInfo.CurrentUICulture.LCID == 2058)
            {
                usernameLabel.Text = "Nombre de usario";
                passwordLabel.Text = "Contraseña";
                loginButton.Text = "Acceso";
                cancelButton.Text = "Cancelar";
                loginLabel.Text = "Acceso";
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
            string pass = userTextBox.Text;

            //opens MySQL connection
            MySqlConnection conn = new MySqlConnection(sqlClass.connectionString);
            conn.Open();
            //Enters command and reads output
            MySqlCommand command = new MySqlCommand($"SELECT userId FROM user WHERE userName = {user} AND password = {pass}", conn);
            MySqlDataReader reader = command.ExecuteReader();
            bool login = false;

            //
            if (reader.HasRows)
            {
                login = true;
                reader.Read();
                CurrentUser.setUserID(Convert.ToInt32(reader[0]));
                
            }


            if (login)
            {
                MainMenu mainMenu = new MainMenu();
                mainMenu.FormClosed += (s, args) => this.Close();
                //Lambda Function if the main menu closes, it will close the whole program
                this.Hide();
                mainMenu.Show();
            } 
            else
            {
                MessageBox.Show(error);
                passTextBox.Text = "";
            }
        }
    }
}
