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
    
    public partial class Welcome : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public string connectionString;

        public Welcome()
        {
            InitializeComponent();
            connectionString = "Server = localhost; Database = GROUP5291; Trusted_Connection = yes;";

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

        private void addEditCustomer_Click(object sender, EventArgs e)
        {
            //code to switch forms and delete old form
            this.Hide();
            EditCustomer ec = new EditCustomer(connectionString);
            ec.ShowDialog();
            this.Close();

        }


        private void reports_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportForm rf = new ReportForm(connectionString);
            rf.ShowDialog();
            this.Close();
        }
        
        private void rentals_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeRentalScreen er = new EmployeeRentalScreen(connectionString);
            er.ShowDialog();
            this.Close();
        }

        private void branches_Click(object sender, EventArgs e)
        {
            this.Hide();
            Branches er = new Branches(connectionString);
            er.ShowDialog();
            this.Close();
        }

        private void employees_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employees er = new Employees(connectionString);
            er.ShowDialog();
            this.Close();
        }
    }
}
