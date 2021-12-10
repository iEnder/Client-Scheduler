using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace C969_Scheduler
{
    public partial class LogIn : Form
    {
        private static Lang lang;

        dynamic langs = new  {
            en = new Lang("Log in", "Username:", "Password:", "Log in", "Invalid Login Info!"),
            es = new Lang("Iniciar sesión", "Nombre de usuario:", "Contraseña:", "Iniciar sesión", "Información de inicio de sesión no válido!")
        };

        public LogIn()
        {
            InitializeComponent();
            setLang();
        }

        private void submitLb_Click(object sender, EventArgs e)
        {
            User user = DbController.GetAndValidateUser(userInput.Text, passInput.Text);

            if(user != null)
            {
                Helpers.WriteLog("User: " + user.username + " logged in at " + DateTime.Now);
                DbController.currentUser = user;

                this.Hide();
                if(user.admin)
                {
                    Views.AdminScheduler main = new Views.AdminScheduler(user);
                    main.ShowDialog();
                } else
                {
                    Views.UserScheduler main = new Views.UserScheduler(user);
                    main.ShowDialog();
                }
                this.Close();

            } else
            {
                MessageBox.Show(lang.error);
            }
        }

        private void setLang()
        {
            try
            {
                lang = langs.GetType().GetProperty(CultureInfo.CurrentCulture.TwoLetterISOLanguageName).GetValue(langs, null);
            } catch (Exception)
            {
                lang = langs.en;
            }

            this.Text = lang.head;
            userLb.Text = lang.user;
            passLb.Text = lang.pass;
            submitLb.Text = lang.btn;
        }
    }

    struct Lang
    {
        public string head { get; set; }
        public string user { get; set; }
        public string pass { get; set; }
        public string btn { get; set; }
        public string error { get; set; }

        public Lang(string head, string user, string pass, string btn, string error)
        {
            this.head = head;
            this.user = user;
            this.pass = pass;
            this.btn = btn;
            this.error = error;
        }
    }
}
