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
    public partial class InsertEvent : Form
    {
        public InsertEvent()
        {
            InitializeComponent();
        }
        //declare variables
        public string name , description , venue , type;
        public  int capacity;
        public double fee;
        public DateTime date = DateTime.Now;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bttnInsert_Click(object sender, EventArgs e)
        {
            
            
                errorProvider1.SetError(txtCapacity, " ");
                errorProvider2.SetError(txtFee, " ");
                

                

                if (double.TryParse(txtFee.Text, out fee))
                {
                    if (int.TryParse(txtCapacity.Text, out capacity))
                    {
                        
                            //asigning variables to textbox
                            name = txtName.Text;
                            description = txtDescription.Text;
                            venue = txtVenue.Text;
                            type = txtType.Text;
                    // Assign the DateTime value to the TextBox.Text property
                    txtDate.Text = date.ToString();

                    this.Close();
                        
                    }
                    else
                    {
                        txtCapacity.Text = "";
                        errorProvider1.SetError(txtCapacity, "Please enter a valid Capacity");
                    }
                }
                else
                {
                    txtFee.Text = "";
                    errorProvider2.SetError(txtFee, "Please enter a valid fee");
                }
        }
    }
}
