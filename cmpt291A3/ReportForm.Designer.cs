
namespace cmpt291A3
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GROUP5291DataSet = new cmpt291A3.GROUP5291DataSet();
            this.BranchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BranchesTableAdapter = new cmpt291A3.GROUP5291DataSetTableAdapters.BranchesTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.GROUP5291DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetGroup5291";
            reportDataSource1.Value = this.BranchesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "cmpt291A3.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(24, 28);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(740, 397);
            this.reportViewer1.TabIndex = 1;
            // 
            // GROUP5291DataSet
            // 
            this.GROUP5291DataSet.DataSetName = "GROUP5291DataSet";
            this.GROUP5291DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BranchesBindingSource
            // 
            this.BranchesBindingSource.DataMember = "Branches";
            this.BranchesBindingSource.DataSource = this.GROUP5291DataSet;
            // 
            // BranchesTableAdapter
            // 
            this.BranchesTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSetGroup5291";
            reportDataSource2.Value = this.BranchesBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "cmpt291A3.Report1.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(51, 83);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(8, 28);
            this.reportViewer2.TabIndex = 2;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ReportForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GROUP5291DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BranchesBindingSource;
        private GROUP5291DataSet GROUP5291DataSet;
        private GROUP5291DataSetTableAdapters.BranchesTableAdapter BranchesTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
    }
}