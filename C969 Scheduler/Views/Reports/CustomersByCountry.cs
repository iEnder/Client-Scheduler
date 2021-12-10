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
    public partial class CustomersByCountry : Form
    {
        public CustomersByCountry()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void genBtn_Click(object sender, EventArgs e)
        {
            reportGrid.DataSource = null;
            reportGrid.Rows.Clear();

            if (reportGrid.Columns.Count == 0)
            {
                reportGrid.Columns.Add("Country", "Country");
                reportGrid.Columns.Add("Customers", "Customers");
            }

            Dictionary<string, int> countryCount = DbController.GetCustomersByCountry();

            foreach (KeyValuePair<string, int> entry in countryCount)
            {
                reportGrid.Rows.Add(new object[] { entry.Key, entry.Value });
            }
        }
    }
}
