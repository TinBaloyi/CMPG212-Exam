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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\143.160.81.13\CTX_Redirected_Data$\35481013\Documents\35481013_EXAM\Default.mdf;Integrated Security=True";
        public SqlConnection conn;
        public SqlCommand cmd;
        public SqlDataAdapter dataAdapter;
        public SqlDataReader reader;

        public static string UserEmail { get; set; }


        private void bttnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //declare variables
                UserEmail = "";
                string password = "";

                //clear error providers
                errorEmail.SetError(txtEmail, "");
                errorPassword.SetError(txtPassword, "");

                // Validation of user inputs
                if (txtEmail.Text != "")
                {
                    UserEmail = txtEmail.Text;
                }
                else
                {
                    txtEmail.Text = "";
                    errorEmail.SetError(txtEmail, "Please enter your name");
                }
                if (txtEmail.Text != "")
                {
                    UserEmail = txtEmail.Text;
                    //the email must include "@" between characters and "."
                    if (!Regex.IsMatch(UserEmail, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                    {
                        txtEmail.Text = "";
                        errorEmail.SetError(txtEmail, "Please enter a valid email address");
                        UserEmail = ""; // Set email to empty string to indicate validation failure
                    }
                }
                else
                {
                    txtEmail.Text = "";
                    errorEmail.SetError(txtEmail, "Please enter your name");
                }
                if (txtPassword.Text != "")
                {
                    password = txtPassword.Text;

                    // Password must be at least 8 characters long
                    if (password.Length < 8)
                    {
                        txtPassword.Text = "";
                        errorPassword.SetError(txtPassword, "Please enter a valid password (minimum 8 characters)");
                        password = ""; // Set password to empty string to show validation failure
                    }

                    //Password requirements
                    else if (!Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$"))
                    {
                        txtPassword.Text = "";
                        errorPassword.SetError(txtPassword, "Password must contain at least one uppercase letter, one lowercase letter, and one digit.");
                        password = ""; // Set password to empty string to show validation failure
                    }
                }
                else
                {
                    txtPassword.Text = "";
                    errorPassword.SetError(txtPassword, "Please enter your password");
                }

                conn = new SqlConnection(connString);
                //open connection
                conn.Open();

                //slq statement to find users matching email and password
                string sql_query = "SELECT *FROM Users WHERE Email = @email AND Password = @password";

                //execute non query
                cmd = new SqlCommand(sql_query, conn);
                cmd.Parameters.AddWithValue("@email", UserEmail);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.ExecuteNonQuery();

                reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    string name = reader["Name"].ToString();
                    string memberType= reader["Membership_Type"].ToString();
                    MessageBox.Show(name+" you are Successfully Logged in as a "+memberType+" member");

                    //direct to dashboard after a successful login
                    DashBoardForm dashBoard = new DashBoardForm();
                    dashBoard.ShowDialog();
                    
                    //close the connection
                    conn.Close();
                }
                else
                {
                    //if the details entered are not registered
                    MessageBox.Show("Email or Password does not exist");

                    // Close the connection
                    conn.Close();
                }
                
                //close the connection
                conn.Close();

                //clear the textbox
                txtEmail.Text = "";
                txtPassword.Text = "";

                //set focus
                txtEmail.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
