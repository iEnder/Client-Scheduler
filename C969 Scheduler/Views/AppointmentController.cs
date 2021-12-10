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
    public partial class AppointmentController : Form
    {
        int targetId = -1;
        string formState = "Add";

        public AppointmentController(string state, Appointment data = null)
        {
            InitializeComponent();
            SetState(state, data);
        }
         
        private void SetState(string state, Appointment data)
        {
            formLabel.Text = state + " Appointment";
            formState = state;

            DataTable customers = DbController.GetFormattedCustomers();
            customers.Columns.Add("idName", typeof(string), "id + ': ' + name");

            customerInput.DataSource = customers;
            customerInput.DisplayMember = "idName";
            customerInput.ValueMember = "id";

            typeInput.DataSource = DbController.GetAppointmentTypes();

            if (data != null)
            {
                targetId = data.appointmentId;

                customerInput.SelectedValue = data.customerId;

                typeInput.Text = data.type;

                titleInput.Text    = data.title;
                descInput.Text     = data.description;
                locationInput.Text = data.location;
                contactInput.Text  = data.contact;
                urlInput.Text      = data.url;
                startInput.Value   = data.start;
                endInput.Value     = data.end;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            DataRowView row = customerInput.SelectedItem as DataRowView;

            Appointment formData = new Appointment
            {
                customerId = (int)row["id"],
                title = titleInput.Text,
                description = descInput.Text,
                location = locationInput.Text,
                contact = contactInput.Text,
                type = typeInput.Text,
                url = urlInput.Text,
                start = startInput.Value, 
                end = endInput.Value,   
            };

            if(validateAppointment(formData))
            {
                if (formState == "Modify")
                {
                    DbController.UpdateAppointment(targetId, formData);
                }
                else if (formState == "Add")
                {
                    DbController.AddAppointment(formData);
                }

                Scheduler.instance.refreshTables();
                this.Close();
            }
        }

        private bool validateAppointment(Appointment app)
        {
            if(DbController.CheckOverlap(targetId, app.start, app.end))
            {
                MessageBox.Show("Appointment overlaps with another");
                return false;
            }

            TimeSpan open = new TimeSpan(9, 0, 0);
            TimeSpan close = new TimeSpan(17, 0, 0);

            if(!(app.start.TimeOfDay >= open && app.end.TimeOfDay <= close) || !(app.end.TimeOfDay >= open && app.start.TimeOfDay <= close))
            {
                MessageBox.Show("Appointment outside normal buisness hours");
                return false;
            }

            return true;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
