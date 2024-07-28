using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//35481013 BALOYI T

namespace _35481013_EXAM
{
    public partial class UpdateEvent : Form
    {
        public UpdateEvent()
        {
            InitializeComponent();
        }
        //declare public variables 
        public int event_id;
        public int capacity;
        public string venue;
        public DateTime date = DateTime.Now;
        public string type;

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtEventId, " ");
            errorProvider2.SetError(txtCapacity, " ");
            

            if (int.TryParse(txtEventId.Text, out event_id))
            {
                if (int.TryParse(txtCapacity.Text, out capacity))
                {
                   
                     //asigning variables to textbox                      
                     venue = txtVenue.Text;
                     type = txtType.Text;
                    // Assign the DateTime value to the TextBox.Text property
                    txtDate.Text = date.ToString();

                    this.Close();

                }
                else
                {
                    txtCapacity.Text = "";
                    errorProvider2.SetError(txtCapacity, "Please enter a valid Capacity");
                }
            }
            else
            {
                txtEventId.Text = "";
                errorProvider1.SetError(txtEventId, "Please enter a valid id");
            }
        }
    }
}
