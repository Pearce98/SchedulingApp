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
    }
}
