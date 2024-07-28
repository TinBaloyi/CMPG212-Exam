using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//35481013 BALOYI T

namespace _35481013_EXAM
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Venue { get; set; }
        public DateTime Date { get; set; }
        public decimal Fee { get; set; }
    }
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        //declare global variables
        public string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\143.160.81.13\CTX_Redirected_Data$\35481013\Documents\35481013_EXAM\Default.mdf;Integrated Security=True";
        public SqlConnection conn;
        public SqlCommand cmd;
        public SqlDataAdapter dataAdapter;
        public SqlDataReader reader;
        public DataSet dataSet;
        private void bttnRegister_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            // Retrieve the selected event ID from the ListBox
            int eventId = GetSelectedEventId();

            // Check if an event is selected
            if (eventId != -1)
            {
                // Retrieve the logged-in user's ID
                int userId = GetLoggedUserId();

                // Check if the user ID retrieval was successful
                if (userId != -1)
                {
                    // Open a connection to the database
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        try
                        {
                            conn.Open();

                            // Check if the user is already registered for the event
                            string checkRegistrationQuery = "SELECT COUNT(*) FROM Registration WHERE Event = @eventId AND user_id = @userId";
                            SqlCommand cmd = new SqlCommand(checkRegistrationQuery, conn);
                            cmd.Parameters.AddWithValue("@eventId", eventId);
                            cmd.Parameters.AddWithValue("@userId", userId);
                            int registrationCount = (int)cmd.ExecuteScalar();

                            if (registrationCount > 0)
                            {
                                // The user is already registered for the event
                                MessageBox.Show("You are already registered for this event.");
                            }
                           else
                            {
                                // Retrieve the registration fee for the event
                                string sqlRegistrationFee = "SELECT Registration_fee FROM Events WHERE Event_id = @eventId";
                                cmd = new SqlCommand(sqlRegistrationFee, conn);
                                cmd.Parameters.AddWithValue("@eventId", eventId);
                                object result = cmd.ExecuteScalar();

                                if (result != null && decimal.TryParse(result.ToString(), out decimal registrationFee))
                                {
                                    // Register the user for the event
                                    string registerQuery = "INSERT INTO Registration (Event, user_id, Registration_date, registration_fees) VALUES (@eventId, @userId, @reg_date, @reg_fees)";
                                    cmd = new SqlCommand(registerQuery, conn);
                                    cmd.Parameters.AddWithValue("@eventId", eventId);
                                    cmd.Parameters.AddWithValue("@userId", userId);
                                    cmd.Parameters.AddWithValue("@reg_date", now);
                                    cmd.Parameters.AddWithValue("@reg_fees", registrationFee);
                                    cmd.ExecuteNonQuery();

                                    // Display a success message to the user
                                    MessageBox.Show("Registration successful. You are now registered for the event.");
                                }
                                else
                                {
                                    // Unable to retrieve or parse the registration fee
                                    MessageBox.Show("Unable to retrieve or parse the registration fee for the event.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred while processing your request: " + ex.Message);
                        }
                    }
                }
                else
                {
                    // Unable to retrieve the user ID
                    MessageBox.Show("Unable to retrieve user information.");
                }
            }
            else
            {
                // No event selected
                MessageBox.Show("Please select an event to register.");
            }

        }
        private int GetSelectedEventId()
        {
            // Retrieve the selected item from the ListBox
            string selectedEvent = lstBxEvents.SelectedItem.ToString();

            // Split the selected item by tabs and retrieve the event ID
            string[] eventDetails = selectedEvent.Split('\t');
            if (eventDetails.Length > 0 && int.TryParse(eventDetails[0], out int eventId))
            {
                return eventId;
            }

            // No item selected or unable to retrieve the event ID
            return -1;
        }
        private int GetLoggedUserId()
        {
            // Retrieve the logged-in user's email
            string userEmail = Login.UserEmail;

            // Initialize the user ID variable
            int userId = -1;

            // Open a connection to the database
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    // Retrieve the user ID based on the email
                    string selectQuery = "SELECT user_id FROM Users WHERE Email = @userEmail";
                    SqlCommand cmd = new SqlCommand(selectQuery, conn);
                    cmd.Parameters.AddWithValue("@userEmail", userEmail);
                    object result = cmd.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out userId))
                    {
                        // User ID found and parsed successfully
                        return userId;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving the user ID: " + ex.Message);
                }
            }

            return userId;
        }

        private void DisplayEvents()
        {
            conn = new SqlConnection(connString);
            try
            {
                conn.Open();

                // Clear the ListBox
                lstBxEvents.Items.Clear();
                lstBxEvents.Items.Add("id\tName\tType\tVenue\tDate\tFee");

                // Get the current date
                DateTime currentDate = DateTime.Now.Date;

                // Retrieve the events from the database
                string selectQuery = "SELECT Event_id,Name,Type,Date, Venue, Registration_fee FROM Events WHERE Date > @currentDate"; 
                cmd = new SqlCommand(selectQuery, conn);
                cmd.Parameters.AddWithValue("@currentDate", currentDate);

                reader = cmd.ExecuteReader();
                //int eventCount = 0;
                while (reader.Read())
                {


                    // Add the event details to the ListBox
                    lstBxEvents.Items.Add(reader["Event_id"].ToString() + "\t" + reader["Name"].ToString() + "\t" + reader["Type"].ToString() + "\t" + reader["Venue"].ToString() + "\t" + reader["Date"].ToString() + "\t" + reader["Registration_fee"].ToString());




                    lstBxEvents.Items.Add(" ");
                }

                reader.Close();
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void Register_Load(object sender, EventArgs e)
        {
            DisplayEvents();
        }
    }
}
