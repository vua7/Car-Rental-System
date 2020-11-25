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
                myCommand.CommandText = "UPDATE Customers SET " +
                    "first_name = '" + customerFirstNameTextBox.Text + "', last_name = '" + customerLastNameTextBox.Text +
                    "', driving_license = '" + customerDrivingLicenseTextBox.Text + "', phone_number = '" + customerPhoneNumberTextBox.Text + 
                    "', membership = '" + customerMembershipComboBox.SelectedIndex + "', street_name = '" + customerStreetNameTextBox.Text + 
                    "', street_number = '" + customerStreetNumberTextBox.Text + "', apt_number = '" + customerApartmentNumberTextBox.Text + 
                    "', city= '" + customerCityTextBox.Text + "', province = '" + customerProvinceTextBox.Text + 
                    "', zip = '" + customerZIPTextBox.Text + "' where CustomerID= " + customerIDTextBox.Text + ";";
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
                
                myCommand.CommandText = "insert into Customers values(2, 'Jane', 'Doe', 123456799, 12346, 'oldStreet', 16, 1, 'Regina', 'Saskatchewan', 'A1B 2C3', 5874567890);";
                MessageBox.Show(myCommand.CommandText);

                myCommand.ExecuteNonQuery();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
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
    }
}
