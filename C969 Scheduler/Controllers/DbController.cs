using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace C969_Scheduler
{
    public static class DbController
    {
        private static readonly string connectStr = "CONNECT STRING";
        private static MySqlConnection connection = new MySqlConnection(connectStr);
        public static User currentUser = new User { username = "test", userId = 1 };

        public static User GetAndValidateUser(string user, string pass)
        {
            User foundUser = null;
            MySqlCommand cmd;
            connection.Open();
            cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM client_schedule.user WHERE userName=@user AND password=@pass";
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            MySqlDataReader reader = cmd.ExecuteReader();

            if(reader.HasRows)
            {
                foundUser = FormatUser(reader);
            } 

            connection.Close();
            return foundUser;
        }
        public static DataTable GetFormattedUsers()
        {
            MySqlCommand cmd;
            connection.Open();
            cmd = connection.CreateCommand();

            cmd.CommandText = @"SELECT userId AS 'id', username,
                                CASE
                                    WHEN active = 0 THEN 'No' WHEN active = 1 THEN 'Yes'
                                END AS active,
                                CASE
                                    WHEN admin = 0 THEN 'No' WHEN admin = 1 THEN 'Yes'
                                END AS admin
                                FROM user";

            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            adap.Fill(ds);

            connection.Close();
            return ds;
        }

        public static DataTable GetFormattedCustomers(string nameQuery = "")
        {
            MySqlCommand cmd;
            connection.Open();
            cmd = connection.CreateCommand();

            cmd.CommandText =
                            @"
                            SELECT customerId AS 'id', customerName AS 'name', phone, address, city, postalCode AS 'zip Code', country, active
                            FROM customer
                            JOIN address ON customer.addressId = address.addressId
                            JOIN city ON address.cityId = city.cityId
                            JOIN country ON city.countryId = country.countryId
                            ";

            if(nameQuery.Length > 0)
            {
                cmd.CommandText += "WHERE customerName LIKE @nameQuery";
                cmd.Parameters.AddWithValue("@nameQuery", $"%{nameQuery}%");
            }

            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            adap.Fill(ds);
            
            connection.Close();
            return ds;
        }
        public static List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            MySqlCommand cmd;
            connection.Open();
            cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM client_schedule.customer";

            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);

            DataTable ds = new DataTable();
            adap.Fill(ds);
            
            DataRowCollection rows = ds.Rows;
            foreach (DataRow row in rows)
            {
                customers.Add(FormatCustomer(row));
            }

            connection.Close();
            return customers;
        }

        public static DataTable GetFormattedAppointments(string dateRange = null)
        {
            MySqlCommand cmd;
            connection.Open();
            cmd = connection.CreateCommand();

            cmd.CommandText =
                            $@"
                            SELECT appointmentId AS 'id', customerName AS 'customer', username AS 'user', title, type, start, end
                            FROM appointment
                            JOIN customer ON appointment.customerId = customer.customerId
                            JOIN user ON appointment.userId = user.userId
                            ";


            if (dateRange != null)
            {
                cmd.CommandText += $"WHERE end <= UTC_TIMESTAMP() + interval 1 {dateRange} and start >= UTC_TIMESTAMP() and appointment.userId = @currId";
            }
            else
            {
                cmd.CommandText += "WHERE appointment.userId = @currId";
            }

            cmd.Parameters.AddWithValue("@currId", currentUser.userId);

            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            adap.Fill(ds);

            foreach(DataRow row in ds.Rows)
            {
                row["start"] = Helpers.ToLocal((DateTime)row["start"]);
                row["end"] = Helpers.ToLocal((DateTime)row["end"]);
            }

            connection.Close();
            return ds;
        }
        public static DataTable GetUsers()
        {
            MySqlCommand cmd;
            connection.Open();
            cmd = connection.CreateCommand();

            cmd.CommandText = @"SELECT * FROM client_schedule.user";

            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            adap.Fill(ds);

            connection.Close();
            return ds;
        }

        public static Appointment GetAppointmentByID(int appointmentId)
        {
            Appointment foundAppointment = null;
            MySqlCommand cmd;
            connection.Open();
            cmd = connection.CreateCommand();

            cmd.CommandText = $"SELECT * FROM client_schedule.appointment WHERE appointmentId = {appointmentId}";
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);

            DataTable ds = new DataTable();
            adap.Fill(ds);

            DataRowCollection rows = ds.Rows;

            foreach (DataRow row in ds.Rows)
            {
                row["start"] = Helpers.ToLocal((DateTime)row["start"]);
                row["end"] = Helpers.ToLocal((DateTime)row["end"]);
            }

            if (rows.Count == 1)
            {
                foreach (DataRow row in rows)
                {
                    foundAppointment = FormatAppointment(row);
                }
            }

            connection.Close();
            return foundAppointment;
        }
        public static Customer GetCustomerByID(int customerId)
        {
            Customer foundCustomer = null;
            MySqlCommand cmd;
            connection.Open();
            cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM client_schedule.customer WHERE customerId='" + customerId + "'";
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);

            DataTable ds = new DataTable();
            adap.Fill(ds);

            DataRowCollection rows = ds.Rows;

            if(rows.Count == 1)
            {
                foreach (DataRow row in rows)
                {
                    foundCustomer = FormatCustomer(row);
                }
            }

            connection.Close();
            return foundCustomer;
        }
        public static Address GetAddressByID(int addressId)
        {
            Address foundAddress = null;
            MySqlCommand cmd;
            connection.Open();
            cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM client_schedule.address WHERE addressId='" + addressId + "'";
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                foundAddress = FormatAddress(reader);
            }

            connection.Close();
            return foundAddress;
        }
        public static Country GetCountryByID(int countryId)
        {
            Country foundCountry = null;
            MySqlCommand cmd;
            connection.Open();
            cmd = connection.CreateCommand();

            cmd.CommandText = $"SELECT * FROM client_schedule.country WHERE countryId= {countryId}";
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                foundCountry = FormatCountry(reader);
            }

            connection.Close();
            return foundCountry;
        }
        public static City GetCityByID(int cityId)
        {
            City foundCity = null;
            MySqlCommand cmd;
            connection.Open();
            cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM client_schedule.city WHERE cityId='" + cityId + "'";
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                foundCity = FormatCity(reader);
            }

            connection.Close();
            return foundCity;
        }
        public static User GetUserByID(int userId)
        {
            User foundUser = null;
            MySqlCommand cmd;
            connection.Open();
            cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM client_schedule.user WHERE userId='" + userId + "'";
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                foundUser = FormatUser(reader);
            }

            connection.Close();
            return foundUser;
        }

        public static bool AddAppointment(Appointment appData)
        {
            MySqlCommand cmd;
            cmd = connection.CreateCommand();
            connection.Open();
            cmd.CommandText = $"INSERT INTO client_schedule.appointment VALUES (NULL, @customerId, @userId, @title, @description, @location, @contact, @type, @url, (@start), (@end), {GetAddString()})";

            cmd.Parameters.AddWithValue("@customerId", appData.customerId);
            cmd.Parameters.AddWithValue("@userId", currentUser.userId);
            cmd.Parameters.AddWithValue("@title", appData.title);
            cmd.Parameters.AddWithValue("@description", appData.description);
            cmd.Parameters.AddWithValue("@location", appData.location);
            cmd.Parameters.AddWithValue("@contact", appData.contact);
            cmd.Parameters.AddWithValue("@type", appData.type);
            cmd.Parameters.AddWithValue("@url", appData.url);

            cmd.Parameters.AddWithValue("@start", Helpers.ToUtc(appData.start));
            cmd.Parameters.AddWithValue("@end", Helpers.ToUtc(appData.end));

            cmd.ExecuteNonQuery();
            connection.Close();
            return true;
        }
        public static bool UpdateAppointment(int targetId, Appointment appData)
        {
            MySqlCommand cmd;
            cmd = connection.CreateCommand();
            connection.Open();
            cmd.CommandText = 
                            $@"UPDATE client_schedule.appointment
                                SET customerId = @customerId,
                                    userId = @userId,
                                    title = @title,
                                    description = @description,
                                    location = @location,
                                    contact = @contact,
                                    type = @type,
                                    url = @url,
                                    start = (@start), 
                                    end = (@end), 
                                    {GetUpdateString()}
                                WHERE appointmentId = @targetId";

            cmd.Parameters.AddWithValue("@targetId", targetId);

            cmd.Parameters.AddWithValue("@customerId", appData.customerId);
            cmd.Parameters.AddWithValue("@userId", currentUser.userId);
            cmd.Parameters.AddWithValue("@title", appData.title);
            cmd.Parameters.AddWithValue("@description", appData.description);
            cmd.Parameters.AddWithValue("@location", appData.location);
            cmd.Parameters.AddWithValue("@contact", appData.contact);
            cmd.Parameters.AddWithValue("@type", appData.type);
            cmd.Parameters.AddWithValue("@url", appData.url);

            cmd.Parameters.AddWithValue("@start", Helpers.ToUtc(appData.start));
            cmd.Parameters.AddWithValue("@end", Helpers.ToUtc(appData.end));

            cmd.ExecuteNonQuery();
            connection.Close();
            return true;
        }
        public static bool DeleteAppointment(int appId)
        {
            MySqlCommand cmd;
            connection.Open();
            cmd = connection.CreateCommand();

            cmd.CommandText = $@"
                                SET FOREIGN_KEY_CHECKS=0;
                                DELETE FROM client_schedule.appointment WHERE appointmentId = {appId};
                                SET FOREIGN_KEY_CHECKS=1;";
            cmd.ExecuteNonQuery();
            connection.Close();
            return true;
        }

        public static bool AddUser(User data)
        {
            MySqlCommand cmd;
            cmd = connection.CreateCommand();
            connection.Open();
            cmd.CommandText = $"INSERT INTO client_schedule.user VALUES (NULL, @user, @pass, @active, @admin, {GetAddString()})";

            cmd.Parameters.AddWithValue("@user", data.username);
            cmd.Parameters.AddWithValue("@pass", data.password);
            cmd.Parameters.AddWithValue("@active", data.active);
            cmd.Parameters.AddWithValue("@admin", data.admin);

            cmd.ExecuteNonQuery();
            connection.Close();
            return true;
        }
        public static bool UpdateUser(int targetId, User data)
        {
            MySqlCommand cmd;
            cmd = connection.CreateCommand();
            connection.Open();
            cmd.CommandText =
                            $@"UPDATE client_schedule.user
                                SET username = @user,
                                    password = @pass,
                                    active = @active,
                                    admin = @admin,
                                    {GetUpdateString()}
                                WHERE userId = @targetId";

            cmd.Parameters.AddWithValue("@targetId", targetId);

            cmd.Parameters.AddWithValue("@user", data.username);
            cmd.Parameters.AddWithValue("@pass", data.password);
            cmd.Parameters.AddWithValue("@active", data.active);
            cmd.Parameters.AddWithValue("@admin", data.admin);


            cmd.ExecuteNonQuery();
            connection.Close();
            return true;
        }
        public static bool DeleteUser(int id)
        {
            MySqlCommand cmd;
            connection.Open();
            cmd = connection.CreateCommand();

            cmd.CommandText = $@"
                                SET FOREIGN_KEY_CHECKS=0;
                                DELETE FROM client_schedule.user WHERE userId = {id};
                                SET FOREIGN_KEY_CHECKS=1;";
            cmd.ExecuteNonQuery();
            connection.Close();
            return true;
        }


        public static bool AddCustomer(Customer cus, Address add, City city, Country con)
        {
            // add or get country
            con = AddOrUpdateCountry(con);

            // same for city
            city = AddOrUpdateCity(city, con);

            // address
            add = AddAddress(add, city);

            // customer
            MySqlCommand cmd;
            cmd = connection.CreateCommand();
            connection.Open();
            cmd.CommandText = $@"INSERT INTO client_schedule.customer VALUES (NULL, @cusName, @addId, @cusActive, {GetAddString()})";

            cmd.Parameters.AddWithValue("@cusName", cus.customerName);
            cmd.Parameters.AddWithValue("@addId", add.addressId);
            cmd.Parameters.AddWithValue("@cusActive", cus.active);

            cmd.ExecuteNonQuery();
            connection.Close();

            return true;
        }
        public static bool UpdateCustomer(CustomerCollection target, Customer cus, Address add, City city, Country con)
        {
            // update country
            con = AddOrUpdateCountry(con);

            // update city
            city = AddOrUpdateCity(city, con);

            // update address
            UpdateAddress(target, add, city);

            // update customer
            MySqlCommand cmd;
            cmd = connection.CreateCommand();
            connection.Open();
            cmd.CommandText = $"UPDATE client_schedule.customer SET customerName = @customerName, active = @active, {GetUpdateString()} WHERE customerId = @customer";

            cmd.Parameters.AddWithValue("@customerName", cus.customerName);
            cmd.Parameters.AddWithValue("@active", cus.active);
            cmd.Parameters.AddWithValue("@customer", target.customer.customerId);

            cmd.ExecuteNonQuery();
            connection.Close();

            return true;
        }
        public static bool DeleteCustomer(int customerId)
        {
            // find customer
            MySqlCommand cmd;
            connection.Open();
            cmd = connection.CreateCommand();

            cmd.CommandText = $"SELECT * FROM client_schedule.customer WHERE customerId = {customerId}";
            MySqlDataReader foundCustomer = cmd.ExecuteReader();

            int addId = -1;

            if(foundCustomer.HasRows)
            {
                while(foundCustomer.Read())
                {
                    addId = (int)foundCustomer["addressId"];
                }
            }

            connection.Close();

            // delete customer
            connection.Open();
            cmd.CommandText = $@"
                                SET FOREIGN_KEY_CHECKS=0;
                                DELETE FROM client_schedule.customer WHERE customerId = {customerId};
                                SET FOREIGN_KEY_CHECKS=1;";
            cmd.ExecuteNonQuery();
            connection.Close();

            if(addId != -1)
            {
                // delete address if no other customers have that address
                connection.Open();
                cmd.CommandText = $@"
                                    SET FOREIGN_KEY_CHECKS=0;
                                    DELETE FROM client_schedule.address WHERE addressId = {addId};
                                    SET FOREIGN_KEY_CHECKS=1;";
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            return false;
        }

        public static Address AddAddress(Address add, City city)
        {
            MySqlCommand cmd;
            connection.Open();
            cmd = connection.CreateCommand();

            cmd.CommandText = $@"INSERT INTO client_schedule.address VALUES (NULL, @address, @address2, @cityId, @postalCode, @phone, {GetAddString()})";

            cmd.Parameters.AddWithValue("@address", add.address);
            cmd.Parameters.AddWithValue("@address2", add.address2);
            cmd.Parameters.AddWithValue("@cityId", city.cityId);
            cmd.Parameters.AddWithValue("@postalCode", add.postalCode);
            cmd.Parameters.AddWithValue("@phone", add.phone);

            cmd.ExecuteNonQuery();
            add.addressId = (int)cmd.LastInsertedId;
            connection.Close();

            return add;
        }
        public static void UpdateAddress(CustomerCollection target, Address add, City city)
        {
            MySqlCommand cmd;
            connection.Open();
            cmd = connection.CreateCommand();

            cmd.CommandText = $@"UPDATE client_schedule.address
                                 SET address = @address, postalCode = @postalCode, phone = @phone, cityId = @cityId, {GetUpdateString()}
                                 WHERE addressId = @addressId";

            cmd.Parameters.AddWithValue("@address", add.address);
            cmd.Parameters.AddWithValue("@postalCode", add.postalCode);
            cmd.Parameters.AddWithValue("@phone", add.phone);
            cmd.Parameters.AddWithValue("@cityId", city.cityId);

            cmd.Parameters.AddWithValue("@addressId", target.address.addressId);

            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private static Country AddCountry(Country con)
        {
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"INSERT INTO client_schedule.country VALUES (NULL, @country, {GetAddString()})";

            cmd.Parameters.AddWithValue("@country", con.country);

            cmd.ExecuteNonQuery();
            con.countryId = (int)cmd.LastInsertedId;
            connection.Close();
            return con;
        }
        public static Country AddOrUpdateCountry(Country con)
        {
            MySqlCommand cmd;
            connection.Open();
            cmd = connection.CreateCommand();

            cmd.CommandText = $"SELECT * FROM client_schedule.country WHERE country = @country";
            cmd.Parameters.AddWithValue("@country", con.country);
            MySqlDataReader foundCountry = cmd.ExecuteReader();
            if (!foundCountry.HasRows)
            {
                connection.Close();
                con = AddCountry(con);
            }
            else
            {
                while (foundCountry.Read())
                {
                    con.countryId = (int)foundCountry["countryId"];
                }
                connection.Close();
            }

            return con;
        } 
        
        private static City AddCity(City city, int country)
        {
            connection.Open();
            MySqlCommand addQuery = connection.CreateCommand();
            addQuery.CommandText = $"INSERT INTO client_schedule.city VALUES (NULL, @city, @country, {GetAddString()})";

            addQuery.Parameters.AddWithValue("@city", city.city);
            addQuery.Parameters.AddWithValue("@country", country);

            addQuery.ExecuteNonQuery();
            city.cityId = (int)addQuery.LastInsertedId;
            connection.Close();
            return city;
        }
        public static City AddOrUpdateCity(City city, Country con)
        {
            MySqlCommand cmd;
            connection.Open();
            cmd = connection.CreateCommand();

            cmd.CommandText = $"SELECT * FROM client_schedule.city WHERE city = @city AND countryId = @countryId";

            cmd.Parameters.AddWithValue("@city", city.city);
            cmd.Parameters.AddWithValue("@countryId", con.countryId);

            MySqlDataReader foundCity = cmd.ExecuteReader();

            if (!foundCity.HasRows)
            {
                connection.Close();
                city = AddCity(city, con.countryId);
            }
            else
            {
                while (foundCity.Read())
                {
                    city.cityId = (int)foundCity["cityId"];
                    city.countryId = con.countryId;
                }
                connection.Close();
            }

            return city;
        }

        private static string GetAddString()
        {
            return $"UTC_TIMESTAMP(), '{currentUser.username}', UTC_TIMESTAMP(), '{currentUser.username}'";
        }
        private static string GetUpdateString()
        {
            return $"lastUpdate = UTC_TIMESTAMP(), lastUpdateBy = '{currentUser.username}'";
        }

        public static List<string> GetAppointmentTypes()
        {
            List<string> typesList = new List<string>();

            MySqlCommand cmd;
            connection.Open();
            cmd = connection.CreateCommand();

            cmd.CommandText = $@"SELECT DISTINCT type FROM client_schedule.appointment";
            MySqlDataReader reader = cmd.ExecuteReader();

            if(reader.HasRows)
            {
                while(reader.Read())
                {
                    typesList.Add(reader.GetString(0));
                }
            }

            connection.Close();
            return typesList;
        }
        public static User FormatUser(MySqlDataReader reader)
        {
            while (reader.Read())
            {
                bool _admin = Convert.ToBoolean(reader["admin"]);
                return new User
                {
                    userId   = (int)reader["userId"],
                    username = (string)reader["userName"],
                    password = (string)reader["password"],
                    active   = true,
                    admin    = _admin
                };
            }

            return null;
        }
        public static Appointment FormatAppointment(DataRow row)
        {
            return new Appointment
            {
                appointmentId = (int)row["appointmentId"],
                customerId    = (int)row["customerId"],
                userId        = (int)row["userId"],
                title         = (string)row["title"],
                description   = (string)row["description"],
                location      = (string)row["location"],
                contact       = (string)row["contact"],
                type          = (string)row["type"],
                url           = (string)row["url"],
                start         = (DateTime)row["start"],
                end           = (DateTime)row["end"]

            };

        }
        public static Address FormatAddress(MySqlDataReader reader)
        {
            while (reader.Read())
            {
                return new Address
                {
                    addressId  = (int)reader["addressId"],
                    address    = (string)reader["address"],
                    address2   = (string)reader["address2"],
                    postalCode = (string)reader["postalCode"],
                    phone      = (string)reader["phone"],
                    cityId     = (int)reader["cityId"],

                };
            }

            return null;
        }
        public static City FormatCity(MySqlDataReader reader)
        {
            while (reader.Read())
            {
                return new City
                {
                    city      = (string)reader["city"],
                    cityId    = (int)reader["cityId"],
                    countryId = (int)reader["countryId"]
                };
            }

            return null;
        }
        public static Country FormatCountry(MySqlDataReader reader)
        {
            while (reader.Read())
            {
                return new Country
                {
                    countryId = (int)reader["countryId"],
                    country   = (string)reader["country"]
                };
            }

            return null;
        }
        public static Customer FormatCustomer(DataRow row)
        {
            return new Customer
            {
                customerId   = (int)row["customerId"],
                customerName = (string)row["customerName"],
                addressId    = (int)row["addressId"],
                active       = (bool)row["active"]
                
            };

        }

        public static bool CheckOverlap(int id, DateTime start, DateTime end)
        {
            MySqlCommand cmd;
            connection.Open();
            cmd = connection.CreateCommand();

            cmd.CommandText = $@"SELECT count(*) FROM appointment 
                                WHERE ((@start > start and @start < end) or (@end > start and @end < end)) and end > now() and appointmentId != {id} limit 1;";

            cmd.Parameters.AddWithValue("@start", Helpers.ToUtc(start));
            cmd.Parameters.AddWithValue("@end", Helpers.ToUtc(end));

            int found = int.Parse(cmd.ExecuteScalar().ToString());
            connection.Close();

            if (found > 0)
            {
                return true;
            }

            return false;
        }
        public static List<Appointment> CheckUpcomingAppointments()
        {
            List<Appointment> foundAppointment = new List<Appointment>();

            MySqlCommand cmd;
            connection.Open();
            cmd = connection.CreateCommand();

            cmd.CommandText = $@"SELECT * FROM appointment WHERE (start >= @start and start <= @end)";

            DateTime now = DateTime.Now;

            cmd.Parameters.AddWithValue("@start", Helpers.ToUtc(now));
            cmd.Parameters.AddWithValue("@end", Helpers.ToUtc(now.AddMinutes(15)));

            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);

            DataTable ds = new DataTable();
            adap.Fill(ds);

            DataRowCollection rows = ds.Rows;

            foreach (DataRow row in ds.Rows)
            {
                row["start"] = Helpers.ToLocal((DateTime)row["start"]);
                row["end"] = Helpers.ToLocal((DateTime)row["end"]);
            }

            if (rows.Count != 0)
            {
                foreach (DataRow row in rows)
                {
                    foundAppointment.Add(FormatAppointment(row));
                }
            }

            connection.Close();
            return foundAppointment;
        }

        // *****************************************
        //
        // Report Functions
        //
        // *****************************************

        public static int[] GetTypesByMonth(string type)
        {
            int[] monthCounts = new int[12];

            MySqlCommand cmd;
            cmd = connection.CreateCommand();

            for (int i = 0; i < monthCounts.Length; i++)
            {
                connection.Open();
                cmd.CommandText = $"SELECT COUNT(*) FROM client_schedule.appointment WHERE MONTH(start) = {i + 1} AND YEAR(start) = {DateTime.Now.Year} AND type = '{type}'";
                monthCounts[i] = int.Parse(cmd.ExecuteScalar().ToString());
                connection.Close();
            }
            return monthCounts;
        }
        public static DataTable GetAppointmentsByUser(int userId)
        {
            MySqlCommand cmd;
            connection.Open();
            cmd = connection.CreateCommand();

            cmd.CommandText = $@"
                                SELECT customerName AS 'customer', title, type, location, start, end
                                FROM appointment
                                JOIN customer ON appointment.customerId = customer.customerId
                                WHERE userid = {userId}
                                ORDER BY start ASC
                               ";

            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            adap.Fill(ds);

            connection.Close();
            return ds;
        }
        public static Dictionary<string, int> GetCustomersByCountry()
        {
            MySqlCommand cmd;
            connection.Open();
            cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT country FROM country";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable countries = new DataTable();
            adapter.Fill(countries);
            connection.Close();


            Dictionary<string, int> countriesCount = new Dictionary<string, int>();

            foreach(DataRow row in countries.Rows)
            {
                connection.Open();
                cmd.CommandText = $@"
                                SELECT COUNT(*)
                                FROM customer
                                JOIN address ON customer.addressId = address.addressId
                                JOIN city ON address.cityId = city.cityId
                                JOIN country ON city.countryId = country.countryId
                                WHERE country = '{row["country"]}'
                               ";
                int count = int.Parse(cmd.ExecuteScalar().ToString());

                if (count > 0)
                {
                    countriesCount[(string)row["country"]] = count;
                }
                connection.Close();
            }

            return countriesCount;
        }
    }
}
