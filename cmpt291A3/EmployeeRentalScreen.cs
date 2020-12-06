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

namespace cmpt291A3
{
    public partial class EmployeeRentalScreen : Form
    { 
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public string connectionString;


        public EmployeeRentalScreen(string connectionString)
        {
            InitializeComponent();
            SqlConnection myConnection = new SqlConnection(connectionString); // Timeout in seconds

            try
            {
                myConnection.Open(); // Open connection
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection; // Link the command stream to the connection
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FindCustomerButtn_Click(object sender, EventArgs e)
        {
            int i = 0;
            int.TryParse(employee_ID_textbox.Text, out i);
            if (i == 0)
            {
                CIDErrorMessg.Visible = true;
            }
            else {
                CIDErrorMessg.Visible = false;
            }
            employee_ID_textbox.Text = "";
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome ws = new Welcome();
            ws.ShowDialog();
            this.Close();
        }

        private void confirm_rental_button_Click(object sender, EventArgs e)
        {
            string rental_ID = rental_Id_textbox.Text;
            DateTime pickup_date = pickup_date_datepicker.Value;
            DateTime return_date = return_date_datepicker.Value;
            string price = "";
            string customer_ID = customer_ID_textbox.Text;
            string employee_ID = employee_ID_textbox.Text;
            string pickup_branch_ID = pickup_branch_ID_textbox.Text;
            string return_branch_ID = return_branch_ID_textbox.Text;
            string vin = vin_textbox.Text;

            if (rental_ID == "") {
                CIDErrorMessg.Text = "enter valid information";
                CIDErrorMessg.Visible = true;
            }
            if (pickup_date.Date == return_date.Date)
            {
                CIDErrorMessg.Text = "enter valid information";
                CIDErrorMessg.Visible = true;
            }
            if (customer_ID == "") {
                CIDErrorMessg.Text = "enter valid information";
                CIDErrorMessg.Visible = true;
            }
        }
    }
}
