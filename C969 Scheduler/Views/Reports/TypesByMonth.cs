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
    public partial class TypesByMonth : Form
    {
        private readonly string[] months = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        public TypesByMonth()
        {
            InitializeComponent();
            typesInput.DataSource = DbController.GetAppointmentTypes();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            reportGrid.DataSource = null;
            reportGrid.Rows.Clear();

            int[] counts = DbController.GetTypesByMonth(typesInput.Text);
            
            if(reportGrid.Columns.Count == 0)
            {
                reportGrid.Columns.Add("Month", "Month");
                reportGrid.Columns.Add("Value", "Appointments");
            }

            for (int i = 0; i < months.Length; i++)
            {
                reportGrid.Rows.Add(new object[] {months[i],  counts[i]});
            }
        }
    }
}
