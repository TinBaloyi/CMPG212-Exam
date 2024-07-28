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

namespace _35481013_EXAM
{
    public partial class DashBoardForm : Form
    {
        public DashBoardForm()
        {
            InitializeComponent();
        }
        public string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\143.160.81.13\CTX_Redirected_Data$\35481013\Documents\35481013_EXAM\Default.mdf;Integrated Security=True";
        public SqlConnection conn;
        public SqlCommand cmd;
        public SqlDataAdapter dataAdapter;
        public SqlDataReader dataReader;
        private void upcomingEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an instance of the UpcomingEvents form
            UpcomingEvents upcomingEventsform = new UpcomingEvents();
            upcomingEventsform.MdiParent = this;
            upcomingEventsform.Show();
        }

        private void updateInformationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an instance of the UpdateDetail form
            UpdateDetails updateDetails = new UpdateDetails();
            updateDetails.MdiParent = this;
            updateDetails.Show();
        }

        private void eventHostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connString);

                // Retrieve the logged-in user's email
                string email = Login.UserEmail;

                // Open connection
                conn.Open();

                string membershipLevel = "";

                // SQL query to retrieve the user's membership level
                string selectQuery = "SELECT Membership_Type FROM Users WHERE Email = @email";

                SqlCommand cmd = new SqlCommand(selectQuery, conn);
                cmd.Parameters.AddWithValue("@email", email);
                dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    membershipLevel = dataReader["Membership_Type"].ToString();

                    // Close the data reader since we have retrieved the value
                    dataReader.Close();

                    // Debug statement to check the retrieved membership level
                    MessageBox.Show("Membership Level: " + membershipLevel);

                    if (membershipLevel.Trim().Equals("Premium", StringComparison.OrdinalIgnoreCase))
                    {
                        EventHost eventHost = new EventHost();
                        eventHost.MdiParent = this;
                        eventHost.Show();
                    }
                    else
                    {
                        MessageBox.Show("Only Premium members can use this feature");
                    }

                }
                else
                {
                    // Display an error message if the membership type is not found
                    MessageBox.Show("Unable to retrieve membership information.");
                }

                // Close the connection
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving membership information: " + ex.Message);
            }

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void regularUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connString);

                // Retrieve the logged-in user's email
                string email = Login.UserEmail;

                // Open connection
                conn.Open();

                string membershipLevel = "";

                // SQL query to retrieve the user's membership level
                string selectQuery = "SELECT Membership_Type FROM Users WHERE Email = @email";

                SqlCommand cmd = new SqlCommand(selectQuery, conn);
                cmd.Parameters.AddWithValue("@email", email);
                dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    membershipLevel = dataReader["Membership_Type"].ToString();

                    // Close the data reader since we have retrieved the value
                    dataReader.Close();

                    // Debug statement to check the retrieved membership level
                    MessageBox.Show("Membership Level: " + membershipLevel);

                    if (membershipLevel.Trim().Equals("Regular", StringComparison.OrdinalIgnoreCase))
                    {
                        Users users = new Users();
                        users.MdiParent = this;
                        users.Show();
                    }
                    else
                    {
                        MessageBox.Show("Only Regular members can use this feature");
                    }

                }
                else
                {
                    // Display an error message if the membership type is not found
                    MessageBox.Show("Unable to retrieve membership information.");
                }

                // Close the connection
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving membership information: " + ex.Message);
            }
        }

        private void eventsHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventHistory eventHistory = new EventHistory();
            eventHistory.MdiParent = this;
            eventHistory.Show();
               
        }
    }
}
