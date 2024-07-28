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
    
    public partial class Users : Form
    {
        public Users()
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

        private void Users_Load(object sender, EventArgs e)
        {
            //call the method to display when formloads
            DisplayEvents();
        }
        private void DisplayEvents()
        {
            //display upcoming events in the dataGrid

            conn = new SqlConnection(connString);
            try
            {
                //open connection
                conn.Open();

                // Get the current date
                DateTime currentDate = DateTime.Now.Date;

                //sql statement to get  upcoming events that have not occured
                string sql = "SELECT Name,Description,Type,Venue,Capacity,Date,Registration_fee FROM Events WHERE Date > @currentDate";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@currentDate", currentDate);

                //assign data adapter and data set
                dataAdapter = new SqlDataAdapter();
                dataSet = new DataSet();

                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dataSet, "Events");

                //add data to the grid 
                dataGridView1.DataSource = dataSet;
                dataGridView1.DataMember = "Events";

                //close the connection
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void DisplayEvents(string sqlStatement)
        {
            //display upcoming events in the dataGrid

            conn = new SqlConnection(connString);
            try
            {
                //open connection
                conn.Open();

                // Get the current date
                DateTime currentDate = DateTime.Now.Date;

                //sql statement
                string sql = sqlStatement;
                cmd = new SqlCommand(sql, conn);
               

                //assign data adapter and data set
                dataAdapter = new SqlDataAdapter();
                dataSet = new DataSet();

                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dataSet, "Events");

                //add data to the grid wies
                dataGridView1.DataSource = dataSet;
                dataGridView1.DataMember = "Events";

                //close the connection
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //sarch for events based on name,type and venue
            DisplayEvents("SELECT * FROM Events WHERE Name LIKE '%" + txtSearch.Text + "%' OR Venue LIKE '%" + txtSearch.Text + "%' OR Type LIKE '%" + txtSearch.Text + "%'");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bttnInvoice_Click(object sender, EventArgs e)
        {
          
        }
       
    }
}
