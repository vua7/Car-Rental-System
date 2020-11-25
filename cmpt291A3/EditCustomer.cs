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
    public partial class EditCustomer : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;


        public EditCustomer()
        {
            InitializeComponent();
            String connectionString = "Server = localhost; Database = GROUP5291; Trusted_Connection = yes;";

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

        private void updateCustomerButton_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                //String city = "'Calgary'";

                //String CustID = "1";
                myCommand.CommandText = "UPDATE Customers SET city= '" + customerCityTextBox.Text + "' where CustomerID= " + customerIDTextBox.Text + ";";
                MessageBox.Show(myCommand.CommandText);

                myCommand.ExecuteNonQuery();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }




            customerEditConfirmationLabel.Show();
            customerEditConfirmationLabel.Text = "Hello World";
        }

        private void addCustomerButton_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                //String variables for all textbox feilds
                String CustomerID = customerIDTextBox.Text;
                String first_name = customerFirstNameTextBox.Text;
                String last_name = customerLastNameTextBox.Text;
                String driving_license = customerDrivingLicenseTextBox.Text;
                String membership = customerMembershipComboBox.Text;
                String street_name = customerStreetNameTextBox.Text;
                String street_number = customerStreetNumberTextBox.Text;
                String apt_number = customerApartmentNumberTextBox.Text;
                String city = customerCityTextBox.Text;
                String province = customerProvinceTextBox.Text;
                String zip = customerZIPTextBox.Text;
                String phone_number = customerPhoneNumberTextBox.Text;

                //SQL statment to add new customer
                myCommand.CommandText = "insert into Customers values("+CustomerID+", '"+first_name+"', '"+last_name+"', "+driving_license+", "+membership+", '"+street_name+"', "+street_number+", "+apt_number+", '"+city+"', '"+province+"', '"+zip+"', "+phone_number+");";
                MessageBox.Show(myCommand.CommandText);
                myCommand.ExecuteNonQuery();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
                customerEditConfirmationLabel.Text = "Enter valid customer information!";
                customerEditConfirmationLabel.Show();
            }
        }

        private void removeCustomerButton_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {

                myCommand.CommandText = "delete from Customers where CustomerID= " + customerIDTextBox.Text;
                MessageBox.Show(myCommand.CommandText);

                myCommand.ExecuteNonQuery();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "select * from Customers";

            try
            {
                MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();
                customerGridView.Rows.Clear();
                while (myReader.Read())
                {
                    customerGridView.Rows.Add(myReader["CustomerID"].ToString(), myReader["first_name"].ToString());
                }
                myReader.Close();

            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }
    }
}
