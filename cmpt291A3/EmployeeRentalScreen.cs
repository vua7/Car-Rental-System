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
    public partial class EmployeeRentalScreen : Form
    {
        public EmployeeRentalScreen()
        {
            InitializeComponent();
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
    }
}
