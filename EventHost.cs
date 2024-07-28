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
    public partial class EventHost : Form
    {
        public EventHost()
        {
            InitializeComponent();
        }
        //declare global variable

        public string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\143.160.81.13\CTX_Redirected_Data$\35481013\Documents\35481013_EXAM\Default.mdf;Integrated Security=True";
        public SqlConnection conn;
        public SqlCommand cmd;
        public SqlDataAdapter dataAdapter;
        public DataSet dataSet;

        private void EventHost_Load(object sender, EventArgs e)
        {
            //display upcoming events in the dataGrid

            conn = new SqlConnection(connString);
            try
            {
                //open connection
                conn.Open();

                // Get the current date
                DateTime currentDate = DateTime.Now.Date;

                //sql statement all events details
                string sql = "SELECT *FROM Events";
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
        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            //to show form Update access its contents
            UpdateEvent update = new UpdateEvent();
            update.ShowDialog();

            conn = new SqlConnection(connString);
            try
            {
                //open connection
                conn.Open();
                

                //Update sql statement
                string update_query = "UPDATE Events SET Type = @type, Venue = @venue, Capacity = @capacity, Date = @date WHERE Event_id = @eventId";
                cmd = new SqlCommand(update_query, conn);
                cmd.Parameters.AddWithValue("@type", update.type);
                cmd.Parameters.AddWithValue("@venue", update.venue);
                cmd.Parameters.AddWithValue("@capacity", update.capacity);
                cmd.Parameters.AddWithValue("@date", update.date);
                cmd.Parameters.AddWithValue("@eventId", update.event_id);

                cmd.ExecuteNonQuery();

                conn.Close();

                conn.Open();
                string sql = "SELECT * FROM Events";
                cmd = new SqlCommand(sql, conn);

                //assign data adapter and data set
                dataAdapter = new SqlDataAdapter();
                dataSet = new DataSet();

                //
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dataSet, "Events");

                //add data to the grid wies
                dataGridView1.DataSource = dataSet;
                dataGridView1.DataMember = "Events";

                conn.Close();
                MessageBox.Show("Event Details updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttnInsert_Click(object sender, EventArgs e)
        {
            //to show form insert and access its contents
            InsertEvent insert = new InsertEvent();
            insert.ShowDialog();

            try
            {
                conn = new SqlConnection(connString);
                conn.Open();

                //sql insert statement
                string insert_query = $"INSERT INTO Events (Name,Description,Type,Venue,Capacity,Date,Registration_fee) VALUES('{ insert.name}','{ insert.description}','{ insert.type}','{ insert.venue}',{ insert.capacity},'{insert.date.ToString("yyyy-MM-dd")}',{ insert.fee})";
                cmd = new SqlCommand(insert_query, conn);

                cmd.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                string sql = "SELECT * FROM Events";
                cmd = new SqlCommand(sql, conn);

                //assign data adapter and data set
                dataAdapter = new SqlDataAdapter();
                dataSet = new DataSet();

                //
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dataSet, "Events");

                //add data to the grid wies
                dataGridView1.DataSource = dataSet;
                dataGridView1.DataMember = "Events";

                MessageBox.Show("Event added successfully");
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            DeleteEvent delete = new DeleteEvent();
            delete.ShowDialog();

            try
            {
                conn = new SqlConnection(connString);
                conn.Open();

                //sql delete statement
                string sql_delete = "DELETE FROM Events WHERE Event_id=" + delete.event_id + "";
                cmd = new SqlCommand(sql_delete, conn);

                dataAdapter = new SqlDataAdapter();
                dataAdapter.DeleteCommand = cmd;
                dataAdapter.DeleteCommand.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                string sql = "SELECT * FROM Events";
                cmd = new SqlCommand(sql, conn);

                //assign data adapter and data set
                dataAdapter = new SqlDataAdapter();
                dataSet = new DataSet();

                //
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dataSet, "Events");

                //add data to the grid wies
                dataGridView1.DataSource = dataSet;
                dataGridView1.DataMember = "Events";

                MessageBox.Show("Event deleted successfully");
                conn.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
