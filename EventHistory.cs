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
    public partial class EventHistory : Form
    {
        public EventHistory()
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

        private void EventHistory_Load(object sender, EventArgs e)
        {
            // display upcoming events in the dataGrid

            conn = new SqlConnection(connString);
            try
            {
                //open connection
                conn.Open();

                // Get the current date
                DateTime currentDate = DateTime.Now.Date;

                //sql statement to get  upcoming events that have not occured
                string sql = "SELECT *FROM Events WHERE Date < @currentDate";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@currentDate", currentDate);

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
    }
}
