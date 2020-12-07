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
    public partial class EditVehicles : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public EditVehicles(string connectionString)
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

        private void carUpdateButton_Click(object sender, EventArgs e)
        {
            string[] values = new string[4];

            values[0] = updateString(carColorTextBox, "Color");
            values[1] = updateString(carModelTextBox, "Model");
            values[2] = updateString(carTypeTextBox, "CarType");
            values[3] = updateInt(carBranchTextBox, "Branch_ID");
            string where = updateString(carVINTextBox, "VIN");
            string valuesString = string.Join(", ", values.Where(s => !string.IsNullOrEmpty(s)));

            if (string.IsNullOrEmpty(valuesString) || string.IsNullOrEmpty(where))
            {
                carConfirmationLabel.Text = "No Changes specified";
                carConfirmationLabel.Show();
                return;
            }

            myCommand.CommandText = "UPDATE Cars SET " + valuesString + " where " + where + ";";
            try
            {
                int rowsAffected = myCommand.ExecuteNonQuery();
                carConfirmationLabel.Text = "Successfully Updated " + rowsAffected + " Row(s)";
                carConfirmationLabel.Show();
            }
            catch (Exception)
            {
                carConfirmationLabel.Text = "Enter valid update information!";
                carConfirmationLabel.Show();
            }
        }

        private void carAddButton_Click(object sender, EventArgs e)
        {
            string[] values = new string[5];
            values[0] = verifyString(carVINTextBox); 
            values[1] = verifyString(carColorTextBox); 
            values[2] = verifyString(carModelTextBox);
            values[3] = verifyString(carTypeTextBox);
            values[4] = verifyInt(carBranchTextBox);
            string valuesString = string.Join(", ", values);

            myCommand.CommandText = "insert into Cars values(" + valuesString + ");";
            try
            {
                int rowsAffected = myCommand.ExecuteNonQuery();
                carConfirmationLabel.Text = "Successfully Added " + rowsAffected + " Row(s)";
                carConfirmationLabel.Show();
            }
            catch (Exception)
            {
                carConfirmationLabel.Text = "Enter valid add information!";
                carConfirmationLabel.Show();
            }
        }

        private void carDeleteButton_Click(object sender, EventArgs e)
        {
            string[] values = new string[5];
            values[0] = updateString(carVINTextBox, "VIN");
            values[1] = updateString(carColorTextBox, "Color");
            values[2] = updateString(carModelTextBox, "Model");
            values[3] = updateString(carTypeTextBox, "CarType");
            values[4] = updateInt(carBranchTextBox, "Branch_ID");
            string valuesString = string.Join(", ", values.Where(s => !string.IsNullOrEmpty(s)));

            if (string.IsNullOrEmpty(valuesString))
            {
                carConfirmationLabel.Text = "No Values specified";
                carConfirmationLabel.Show();
                return;
            }

            myCommand.CommandText = "delete from Cars where " + valuesString + ";";
            try
            {
                int rowsAffected = myCommand.ExecuteNonQuery();
                carConfirmationLabel.Text = "Successfully Deleted " + rowsAffected + " Row(s)";
                carConfirmationLabel.Show();
            }
            catch (Exception)
            {
                carConfirmationLabel.Text = "Enter valid delete information!";
                carConfirmationLabel.Show();
            }
        }

        private void carBackButton_Click(object sender, EventArgs e)
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
