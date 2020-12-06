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
    public partial class Branches : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public Branches(string connectionString)
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

        private void Branches_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gROUP5291DataSet.Branches' table. You can move, or remove it, as needed.
            this.branchesTableAdapter.Fill(this.gROUP5291DataSet.Branches);

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome welcome = new Welcome();
            welcome.ShowDialog();
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
            string[] values = new string[7];
            values[0] = verifyInt(branchIDTextBox);
            values[1] = verifyString(streetNameTextBox);
            values[2] = verifyInt(StreetNumberTextBox);
            values[3] = verifyString(cityTextBox);
            values[4] = verifyString(provinceTextBox);
            values[5] = verifyString(zipTextBox);
            values[6] = verifyString(phoneNumberTextBox);
            string valuesString = string.Join(", ", values);

            myCommand.CommandText = "insert into Branches values(" + valuesString + ");";
            try
            {
                int rowsAffected = myCommand.ExecuteNonQuery();
                branchConfirmationLabel.Text = "Successfully Added " + rowsAffected + " Row(s)";
                branchConfirmationLabel.Show();
                //update the gridview on query page
                Branches_Load(sender, e);
            }
            catch (Exception)
            {
                branchConfirmationLabel.Text = "Enter valid information!";
                branchConfirmationLabel.Show();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
           
            string[] values = new string[6];
            values[0] = updateString(streetNameTextBox, "street_name");
            values[1] = updateInt(StreetNumberTextBox, "street_number");
            values[2] = updateString(cityTextBox, "city");
            values[3] = updateString(provinceTextBox, "province");
            values[4] = updateString(zipTextBox, "zip");
            values[5] = updateString(phoneNumberTextBox, "phone_number");
            string where = updateInt(branchIDTextBox, "Branch_ID");
            string valuesString = string.Join(", ", values.Where(s => !string.IsNullOrEmpty(s)));
                
            if (string.IsNullOrEmpty(valuesString) || string.IsNullOrEmpty(where))
            {
                branchConfirmationLabel.Text = "No Changes specified";
                branchConfirmationLabel.Show();
                return;
            }

            myCommand.CommandText = "UPDATE Branches SET " + valuesString + " where " + where + ";";
            try
            {
                int rowsAffected = myCommand.ExecuteNonQuery();
                branchConfirmationLabel.Text = "Successfully Updated " + rowsAffected + " Row(s)";
                branchConfirmationLabel.Show();
                //update the gridview on query page
                Branches_Load(sender, e);
            }
            catch (Exception)
            {
                branchConfirmationLabel.Text = "Enter valid information!";
                branchConfirmationLabel.Show();
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            string[] values = new string[7];
            values[0] = updateInt(branchIDTextBox, "Branch_ID");
            values[1] = updateString(streetNameTextBox, "street_name");
            values[2] = updateInt(StreetNumberTextBox, "street_number");
            values[3] = updateString(cityTextBox, "city");
            values[4] = updateString(provinceTextBox, "province");
            values[5] = updateString(zipTextBox, "zip");
            values[6] = updateString(phoneNumberTextBox, "phone_number");
            string valuesString = string.Join(", ", values.Where(s => !string.IsNullOrEmpty(s)));

            if (string.IsNullOrEmpty(valuesString))
            {
                branchConfirmationLabel.Text = "No values specified";
                branchConfirmationLabel.Show();
                return;
            }

            myCommand.CommandText = "delete from Branches where " + valuesString + ";";
            try 
            {
                int rowsAffected = myCommand.ExecuteNonQuery();
                branchConfirmationLabel.Text = "Successfully Deleted " + rowsAffected + " Row(s)";
                branchConfirmationLabel.Show();
                //update the gridview on query page
                Branches_Load(sender, e);
            }
            catch (Exception)
            {
                branchConfirmationLabel.Text = "Enter Valid Information";
                branchConfirmationLabel.Show();
            }
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
            return field + " = " +textBox.Text;
        }
       
    }
}
