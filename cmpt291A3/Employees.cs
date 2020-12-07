using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cmpt291A3
{
    public partial class Employees : Form
    {
        public Employees(string connectionString)
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gROUP5291DataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.gROUP5291DataSet.Employees);

        }

        private void updateButton_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome er = new Welcome();
            er.ShowDialog();
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
