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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GROUP5291DataSet.Branches' table. You can move, or remove it, as needed.
            this.BranchesTableAdapter.Fill(this.GROUP5291DataSet.Branches);
            // TODO: This line of code loads data into the 'GROUP5291DataSet.Branches' table. You can move, or remove it, as needed.
            this.BranchesTableAdapter.Fill(this.GROUP5291DataSet.Branches);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }
    }
}
