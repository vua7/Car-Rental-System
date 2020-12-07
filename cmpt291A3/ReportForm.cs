using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cmpt291A3
{
    public partial class ReportForm : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public ReportForm(string connectionString)
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

        private void ReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GROUP5291DataSet.Branches' table. You can move, or remove it, as needed.
            //this.BranchesTableAdapter.Fill(this.GROUP5291DataSet.Branches);
            // TODO: This line of code loads data into the 'GROUP5291DataSet.Branches' table. You can move, or remove it, as needed.
            //this.BranchesTableAdapter.Fill(this.GROUP5291DataSet.Branches);

            //this.reportViewer1.RefreshReport();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            this.BranchesTableAdapter.Fill(this.GROUP5291DataSet.Branches);

            this.reportViewer1.RefreshReport();
        }
    }
}
