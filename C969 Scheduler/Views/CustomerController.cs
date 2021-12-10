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
    public partial class CustomerController : Form
    {
        CustomerCollection target = new CustomerCollection();
        string formState = "Add";

        public CustomerController(string state, Customer data = null)
        {
            InitializeComponent();
            SetState(state, data);
        }

        private bool validateForm()
        {

            // validate ints
            if (!int.TryParse(zipInput.Text, out _))
            {
                MessageBox.Show("Zip is not numeric!");
                return false;
            }

            // LAMBDA x2 - simplify expression and peform operations on specific textboxes without having to define and loop over all
            if (this.Controls.OfType<TextBox>().Where(c => c.Name != "idInput").Any(t => string.IsNullOrEmpty(t.Text)))
            {
                MessageBox.Show("Inputs can not be empty!");
                return false;
            }

            return true;
        }

        private void SetState (string state, Customer data)
        {
            formLabel.Text = state + " Customer";
            formState = state;

            // if customer is supplied then fill form data

            if(data != null)
            {
                if(data.active)
                {
                    noRadio.Checked = false;
                    yesRadio.Checked = true;
                } else
                {
                    yesRadio.Checked = false;
                    noRadio.Checked = true;
                }

                idInput.Text      = data.customerId.ToString();
                nameInput.Text    = data.customerName;

                Address addressData = DbController.GetAddressByID(data.addressId);

                phoneInput.Text   = addressData.phone;
                addressInput.Text = addressData.address;
                zipInput.Text     = addressData.postalCode;

                City cityData = DbController.GetCityByID(addressData.cityId);

                cityInput.Text    = cityData.city;

                Country countryData = DbController.GetCountryByID(cityData.countryId);

                countryInput.Text = countryData.country;

                target.customer = data;
                target.address  = addressData;
                target.city     = cityData;
                target.country  = countryData;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(validateForm())
            {
                Customer customer = new Customer
                {
                    customerName = nameInput.Text,
                    active = yesRadio.Checked
                };

                Address address = new Address
                {
                    address = addressInput.Text,
                    address2 = "",
                    postalCode = zipInput.Text,
                    phone = phoneInput.Text
                };

                City city = new City
                {
                    city = cityInput.Text
                };

                Country country = new Country
                {
                    country = countryInput.Text
                };

                if (formState == "Modify")
                {
                    DbController.UpdateCustomer(target, customer, address, city, country);
                }
                else if (formState == "Add")
                {
                    DbController.AddCustomer(customer, address, city, country);
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
