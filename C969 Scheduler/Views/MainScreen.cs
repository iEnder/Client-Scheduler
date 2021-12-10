using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_Scheduler.Views
{
    public partial class Scheduler : Form
    {
        public static Scheduler instance;

        public Scheduler(C969_Scheduler.User user)
        {
            instance = this;
            InitializeComponent();
            checkAlerts();
            allRad.Checked = true;
        }

        // *****************************************
        //
        // Table Helpers
        //
        // *****************************************

        public void loadTables(string dateRange = null)
        {
            cusGrid.DataSource = DbController.GetFormattedCustomers().DefaultView;
            appGrid.DataSource = DbController.GetFormattedAppointments(dateRange).DefaultView;
            if(userGrid.Enabled)
            {
                userGrid.DataSource = DbController.GetFormattedUsers().DefaultView;
            }
        }

        public void refreshTables(string dateRange = null)
        {
            cusGrid.DataSource = null;
            appGrid.DataSource = null;
            if (userGrid.Enabled)
            {
                userGrid.DataSource = null;
            }
            loadTables(dateRange);
        }

        // *****************************************
        //
        // Customer Page Logic
        //
        // *****************************************


        private void cusAddBtn_Click(object sender, EventArgs e)
        {
            new Views.CustomerController("Add").Show();
        }

        private void cusModBtn_Click(object sender, EventArgs e)
        {
           new Views.CustomerController("Modify", DbController.GetCustomerByID((int)cusGrid.SelectedRows[0].Cells["id"].Value)).Show();
        }

        private void cusDelBtn_Click(object sender, EventArgs e)
        {
            DbController.DeleteCustomer((int)cusGrid.SelectedRows[0].Cells["id"].Value);
            refreshTables();
        }

        private void cusCloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cusSearchBtn_Click(object sender, EventArgs e)
        {
            cusGrid.DataSource =  DbController.GetFormattedCustomers(cusSearch.Text);
        }

        // *****************************************
        //
        // Appointment Page Logic
        //
        // *****************************************


        private void aptAddBtn_Click(object sender, EventArgs e)
        {
            new Views.AppointmentController("Add").Show();
        }

        private void aptModBtn_Click(object sender, EventArgs e)
        {
            new Views.AppointmentController("Modify", DbController.GetAppointmentByID((int)appGrid.SelectedRows[0].Cells["id"].Value)).Show();
        }

        private void aptDelBtn_Click(object sender, EventArgs e)
        {
            DbController.DeleteAppointment((int)appGrid.SelectedRows[0].Cells["id"].Value);
            refreshTables();
        }

        private void aptCloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // *****************************************
        //
        // Appointment Display By
        //
        // *****************************************


        private void allRad_CheckedChanged(object sender, EventArgs e)
        {
            refreshTables();
        }

        private void monthRad_CheckedChanged(object sender, EventArgs e)
        {
            refreshTables("month");
        }

        private void weekRad_CheckedChanged(object sender, EventArgs e)
        {
            refreshTables("week");
        }


        // *****************************************
        //
        // Report Page Logic
        //
        // *****************************************

        private void report1Btn_Click(object sender, EventArgs e)
        {
            new Views.Reports.TypesByMonth().Show();
        }

        private void report2Btn_Click(object sender, EventArgs e)
        {
            new Views.Reports.ConsultantSchedule().Show();
        }

        private void report3Btn_Click(object sender, EventArgs e)
        {
            new Views.Reports.CustomersByCountry().Show();
        }

        private void reportCloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // *****************************************
        //
        // User Page Logic
        //
        // *****************************************

        private void userAddBtn_Click(object sender, EventArgs e)
        {
            new Views.UserController("Add").Show();
        }

        private void userModBtn_Click(object sender, EventArgs e)
        {
            new Views.UserController("Modify", DbController.GetUserByID((int)cusGrid.SelectedRows[0].Cells["id"].Value)).Show();
        }

        private void userDelBtn_Click(object sender, EventArgs e)
        {
            DbController.DeleteUser((int)userGrid.SelectedRows[0].Cells["id"].Value);
            refreshTables();
        }

        private void userCloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // *****************************************
        //
        // Alerts Logic
        //
        // *****************************************

        private void checkAlerts()
        {
            List<Appointment> nearbyAppointments = DbController.CheckUpcomingAppointments();
            if (nearbyAppointments.Count != 0)
            {
                MessageBox.Show($"You have {nearbyAppointments.Count} appointments within 15 minutes!");
            }
        }
    }

    public class AdminScheduler : Scheduler
    {
        public AdminScheduler(C969_Scheduler.User user) : base(user)
        {
            this.Text = "Admin Scheduler";
            loadTables();
        }

        // *****************************************
        //
        // Table Helpers
        //
        // *****************************************

    }

    public class UserScheduler : Scheduler
    {
        public UserScheduler(C969_Scheduler.User user) : base(user) 
        {
            userGrid.Enabled = false;
            tabControl1.TabPages.Remove(tabControl1.TabPages[3]);
            loadTables();
        }

        // *****************************************
        //
        // Table Helpers
        //
        // *****************************************

    }
}
