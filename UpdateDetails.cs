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
using System.Text.RegularExpressions;
//35481013 BALOYI T

namespace _35481013_EXAM
{
    public partial class UpdateDetails : Form
    {
        public UpdateDetails()
        {
            InitializeComponent();
        }
        //declare global variable

        public string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\143.160.81.13\CTX_Redirected_Data$\35481013\Documents\35481013_EXAM\Default.mdf;Integrated Security=True";
        public SqlConnection conn;
        public SqlCommand cmd;
        public SqlDataAdapter dataAdapter;

        private void UpdateDetails_Load(object sender, EventArgs e)
        {
            try
            {
                // Retrieve the logged-in user's email
                string email = Login.UserEmail;

                // Clear the ListBox
                lstBxDetails.Items.Clear();

            

            conn = new SqlConnection(connString);

            //open connection
            conn.Open();

            // sql statement to retrieve the user's profile information
            string selectQuery = "SELECT *FROM Users WHERE Email = @email";

            // Create a SqlCommand object with the SELECT query
            cmd = new SqlCommand(selectQuery, conn);
            cmd.Parameters.AddWithValue("@email", email);

            // Execute the query and fetch the data
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {                  
                   // Add the profile details to the ListBox
                    lstBxDetails.Items.Add("Name: "+reader.GetValue(1).ToString());
                    lstBxDetails.Items.Add("Email: " + reader.GetValue(2).ToString());
                    lstBxDetails.Items.Add("Membership Status: " + reader.GetValue(5).ToString());

                }

            reader.Close();

            //close the connection
            conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString);
            try
            {
                // Clear error providers
                NameError.SetError(txtName, "");
                EmailError.SetError(txtEmail, "");
                PasswordError.SetError(txtPassword, "");

                // Declare variables
                string name = "", email = "", password = "";

                // Validation of user inputs
                if (txtName.Text != "")
                {
                    name = txtName.Text;
                }
                else
                {
                    txtName.Text = "";
                    NameError.SetError(txtName, "Please enter your name");
                }

                if (txtEmail.Text != "")
                {
                    email = txtEmail.Text;

                    //the email must include "@" between characters and "."
                    if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                    {
                        txtEmail.Text = "";
                        EmailError.SetError(txtEmail, "Please enter a valid email address");
                        email = ""; // Set email to empty string to indicate validation failure
                    }
                }
                else
                {
                    txtEmail.Text = "";
                    EmailError.SetError(txtEmail, "Please enter your email");
                }

                if (txtPassword.Text != "")
                {
                    password = txtPassword.Text;

                    // Password must be at least 8 characters long
                    if (password.Length < 8)
                    {
                        txtPassword.Text = "";
                        PasswordError.SetError(txtPassword, "Please enter a valid password (minimum 8 characters)");
                        password = ""; // Set password to empty string to show validation failure
                    }

                    //Password requirements
                    else if (!Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$"))
                    {
                        txtPassword.Text = "";
                        PasswordError.SetError(txtPassword, "Password must contain at least one uppercase letter, one lowercase letter, and one digit.");
                        password = ""; // Set password to empty string to show validation failure
                    }
                }
                else
                {
                    txtPassword.Text = "";
                    PasswordError.SetError(txtPassword, "Please enter your password");
                }
                // Retrieve the logged-in user's email
                string user_email = Login.UserEmail;
               
                //open connection
                conn.Open();
                if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(name))
                {
                    //sql statement to update users details
                    string update_query = "UPDATE Users SET Email = @newEmail, Name = @name, Password = @password WHERE Email = @email";
                    cmd = new SqlCommand(update_query, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@newEmail", email);
                    cmd.Parameters.AddWithValue("@email", user_email);
                    cmd.Parameters.AddWithValue("@password", password);

                    cmd.ExecuteNonQuery();

                    // Retrieve the selected membership level from the ComboBox or RadioButton control
                    // string newMembershipLevel = cmbMembershipLevel.SelectedItem.ToString(); // Replace with the appropriate control name

                    // Update the membership level in the database for the logged-in user
                    //UpdateMembershipLevel(email, newMembershipLevel); // Replace with your own method to update the membership level

                    conn.Close();
                    MessageBox.Show("Details updated successfully");
                }
                   

                //clear textbox
                txtEmail.Text = "";
                txtName.Text = "";

                //set focus
                txtName.Focus();

                //close connection
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieve the logged-in user's email
            string email = Login.UserEmail;

            // Open connection
            conn.Open();

            // Check if the user is already a premium member

            //sql stament
            string selectQuery = "SELECT Membership_Type FROM Users WHERE Email = @email";
            cmd = new SqlCommand(selectQuery, conn);
            cmd.Parameters.AddWithValue("@email", email);

            string currentMembershipLevel = cmd.ExecuteScalar()?.ToString();
            if (currentMembershipLevel == null)
            {
                // The user does not exist or an error occurred
                MessageBox.Show("Failed to retrieve membership level");
            }
            if (currentMembershipLevel.Trim().Equals("Premium", StringComparison.OrdinalIgnoreCase))
            {
                // Display a message indicating that the user is already a premium member
                MessageBox.Show("You are already a premium member");
            }
            else
            {
                // Update the membership level to premium in the database
                string updateQuery = "UPDATE Users SET Membership_Type = 'Premium' WHERE Email = @email";
                cmd = new SqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.ExecuteNonQuery();

                // Display a success message
                MessageBox.Show("Membership level changed to premium");
            }

            // Close the connection
            conn.Close();

        }

        private void lstBxDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
