using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_Scheduler.Views.Reports
{
    public partial class ConsultantSchedule : Form
    {
        public ConsultantSchedule()
        {
            InitializeComponent();

            var users = DbController.GetUsers().DefaultView;
            usersInput.DisplayMember = "username";
            usersInput.ValueMember = "userId";
            usersInput.DataSource = users;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            reportGrid.DataSource = null;
            reportGrid.DataSource = DbController.GetAppointmentsByUser(int.Parse(usersInput.SelectedValue.ToString())).DefaultView;
        }
    }
}
