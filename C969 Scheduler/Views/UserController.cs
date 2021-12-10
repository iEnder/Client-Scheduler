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
    public partial class UserController : Form
    {
        int targetId = -1;
        string formState = "Add";
        public UserController(string state, User data = null)
        {
            InitializeComponent();
            SetState(state, data);
        }
        private void SetState(string state, User data)
        {
            formLabel.Text = state + " User";
            formState = state;

            // if customer is supplied then fill form data

            if (data != null)
            {
                targetId = data.userId;

                if (data.active)
                {
                    noRadio.Checked = false;
                    yesRadio.Checked = true;
                }
                else
                {
                    yesRadio.Checked = false;
                    noRadio.Checked = true;
                }

                if(data.admin)
                {
                    yesAdmin.Checked = true;
                    noAdmin.Checked = false;
                } else
                {
                    noAdmin.Checked = true;
                    yesAdmin.Checked = false;
                }

                userInput.Text = data.username;
                passInput.Text = data.password;
            }
        }

        private bool validateForm()
        {
            if (this.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)))
            {
                MessageBox.Show("Inputs can not be empty!");
                return false;
            }

            return true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                User formUser = new User
                {
                    username = userInput.Text,
                    password = passInput.Text,
                    active = yesRadio.Checked,
                    admin = yesAdmin.Checked
                };

                if (formState == "Modify")
                {
                    DbController.UpdateUser(targetId, formUser);
                }
                else if (formState == "Add")
                {
                    DbController.AddUser(formUser);
                }

                Scheduler.instance.refreshTables();
                this.Close();

            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
