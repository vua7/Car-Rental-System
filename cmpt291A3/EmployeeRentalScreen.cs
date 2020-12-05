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
            int.TryParse(CIDtextBox.Text, out i);
            if (i == 0)
            {
                CIDErrorMessg.Visible = true;
            }
            else {
                CIDErrorMessg.Visible = false;
            }
            CIDtextBox.Text = "";
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
    }
}
