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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //declare global variable

        public string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\143.160.81.13\CTX_Redirected_Data$\35481013\Documents\35481013_EXAM\Default.mdf;Integrated Security=True";
        public SqlConnection conn;
        public SqlCommand cmd;
        public SqlDataAdapter dataAdapter;

        
                private void bttnRegistration_Click(object sender, EventArgs e)
        {
            // Clear error providers
            NameError.SetError(txtName, "");
            EmailError.SetError(txtUsername, "");
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

            if (txtUsername.Text != "")
            {
                email = txtUsername.Text;

                //the email must include "@" between characters and "."
                if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    txtUsername.Text = "";
                    EmailError.SetError(txtUsername, "Please enter a valid email address");
                    email = ""; // Set email to empty string to indicate validation failure
                }
            }
            else
            {
                txtUsername.Text = "";
                EmailError.SetError(txtUsername, "Please enter your email");
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

            // Open the connection
            conn = new SqlConnection(connString);
            conn.Open();

            try
            {
                

                // Insert user details into the database table after registration
                if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password)) // Only proceed if email and password are valid
                {
                    DateTime now = DateTime.Now;

                    // Determine membership level
                    // Get the selected membership level from the combo box
                    string selectedMembershipLevel = cmbMembershipLevel.SelectedItem.ToString();
                    // SQL insert statement
                    string insert_query = "INSERT INTO Users(Name, Email, Password,MemberShip_Type, Registration_date) VALUES(@name, @email, @password,@memberLevel, @registrationDate)";

                    cmd = new SqlCommand(insert_query, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@memberLevel", selectedMembershipLevel);
                    cmd.Parameters.AddWithValue("@registrationDate", now);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show(name + " Thank you for registering");

                    //clear textbox
                    txtName.Text="";
                    txtUsername.Text = "";
                    txtPassword.Text = "";

                    //sets textbox to focus
                    txtName.Focus();

                    // Clear the selection in the ComboBox
                    cmbMembershipLevel.SelectedIndex = -1;

                    // Close the connection
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bttnLogin_Click(object sender, EventArgs e)
        {
            //show contentsofanother form
            Login loginform = new Login();
            loginform.ShowDialog();
        }
    }
    
}
