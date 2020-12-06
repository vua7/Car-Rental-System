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


        public EditCustomer(string connectionString)
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

        private void updateCustomerButton_MouseClick(object sender, MouseEventArgs e)
        {
            string[] values = new string[11];
            values[0] =  updateString(customerFirstNameTextBox, "first_name");
            values[1] =  updateString(customerLastNameTextBox, "last_name");
            values[2] =  updateInt(customerDrivingLicenseTextBox, "driving_license");
            values[3] =  updateInt(customerMembershipStatusTextBox, "membership");
            values[4] =  updateString(customerStreetNameTextBox, "street_name");
            values[5] =  updateInt(customerStreetNumberTextBox, "street_number");
            values[6] =  updateInt(customerApartmentNumberTextBox, "apt_number");
            values[7] =  updateString(customerCityTextBox, "city");
            values[8] =  updateString(customerProvinceTextBox, "province");
            values[9] =  updateString(customerZIPTextBox, "zip");
            values[10] = updateString(customerPhoneNumberTextBox, "phone_number");
            string where = updateInt(customerIDTextBox, "CustomerID");
            string valuesString = string.Join(", ", values.Where(s => !string.IsNullOrEmpty(s)));

            if (string.IsNullOrEmpty(valuesString) || string.IsNullOrEmpty(where))
            {
                customerEditConfirmationLabel.Text = "No Changes specified";
                customerEditConfirmationLabel.Show();
                return;
            }

            myCommand.CommandText = "UPDATE Customers SET " + valuesString + " where " + where + ";";
            try
            {
                int rowsAffected = myCommand.ExecuteNonQuery();
                customerEditConfirmationLabel.Text = "Successfully Updated " + rowsAffected + " Row(s)";
                customerEditConfirmationLabel.Show();
                //update the gridview on query page
                EditCustomer_Load(sender, e);
            }
            catch (Exception)
            {
                customerEditConfirmationLabel.Text = "Enter valid information!";
                customerEditConfirmationLabel.Show();
            }
        }

        private void addCustomerButton_MouseClick(object sender, MouseEventArgs e)
        {
            string[] values = new string[12];
            values[0] =  verifyInt(customerIDTextBox);
            values[1] =  verifyString(customerFirstNameTextBox);
            values[2] =  verifyString(customerLastNameTextBox);
            values[3] =  verifyInt(customerDrivingLicenseTextBox);
            values[4] =  verifyInt(customerMembershipStatusTextBox);
            values[5] =  verifyString(customerStreetNameTextBox);
            values[6] =  verifyInt(customerStreetNumberTextBox);
            values[7] =  verifyInt(customerApartmentNumberTextBox);
            values[8] =  verifyString(customerCityTextBox);
            values[9] =  verifyString(customerProvinceTextBox);
            values[10] = verifyString(customerZIPTextBox);
            values[11] = verifyString(customerPhoneNumberTextBox);
            string valuesString = string.Join(", ", values);

            myCommand.CommandText = "insert into Customers values(" + valuesString + ");";
            try
            {
                int rowsAffected = myCommand.ExecuteNonQuery();
                customerEditConfirmationLabel.Text = "Successfully Added " + rowsAffected + " Row(s)";
                customerEditConfirmationLabel.Show();
                //update the gridview on query page
                EditCustomer_Load(sender, e);
            }
            catch (Exception)
            {
                customerEditConfirmationLabel.Text = "Enter valid information!";
                customerEditConfirmationLabel.Show();
            }
        }

        private void removeCustomerButton_MouseClick(object sender, MouseEventArgs e)
        {
            string[] values = new string[12];
            values[0] =  updateInt(customerIDTextBox, "CustomerID");
            values[1] =  updateString(customerFirstNameTextBox, "first_name");
            values[2] =  updateString(customerLastNameTextBox, "last_name");
            values[3] =  updateInt(customerDrivingLicenseTextBox, "driving_license");
            values[4] =  updateInt(customerMembershipStatusTextBox, "membership");
            values[5] =  updateString(customerStreetNameTextBox, "street_name");
            values[6] =  updateInt(customerStreetNumberTextBox, "street_number");
            values[7] =  updateInt(customerApartmentNumberTextBox, "apt_number");
            values[8] =  updateString(customerCityTextBox, "city");
            values[9] =  updateString(customerProvinceTextBox, "province");
            values[10] = updateString(customerZIPTextBox, "zip");
            values[11] = updateString(customerPhoneNumberTextBox, "phone_number");
            string valuesString = string.Join(", ", values.Where(s => !string.IsNullOrEmpty(s)));

            if (string.IsNullOrEmpty(valuesString))
            {
                customerEditConfirmationLabel.Text = "No Values specified";
                customerEditConfirmationLabel.Show();
                return;
            }

            myCommand.CommandText = "delete from Customers where " + valuesString + ";";
            try
            {
                int rowsAffected = myCommand.ExecuteNonQuery();
                customerEditConfirmationLabel.Text = "Successfully Deleted " + rowsAffected + " Row(s)";
                customerEditConfirmationLabel.Show();
                //update the gridview on query page
                EditCustomer_Load(sender, e);
            }
            catch (Exception)
            {
                customerEditConfirmationLabel.Text = "Enter Valid Information";
                customerEditConfirmationLabel.Show();
            }
        }

        private void EditCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gROUP5291DataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.gROUP5291DataSet.Customers);

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome welcome = new Welcome();
            welcome.ShowDialog();
            this.Close();
        }

        private string verifyString(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                return "null";
            }
            return "'" + textBox.Text + "'";
        }

        private string verifyInt(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                return "null";
            }
            return textBox.Text;
        }

        private string updateString(TextBox textBox, string field)
        {
            if (textBox.Text == "")
            {
                return null;
            }
            return field + " = '" + textBox.Text + "'";
        }

        private string updateInt(TextBox textBox, string field)
        {
            if (textBox.Text == "")
            {
                return null;
            }
            return field + " = " + textBox.Text;
        }
    }
}
