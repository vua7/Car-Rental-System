
namespace cmpt291A3
{
    partial class Welcome
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
            this.customers = new System.Windows.Forms.Button();
            this.cars = new System.Windows.Forms.Button();
            this.branches = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.viewRentalOptions = new System.Windows.Forms.Button();
            this.employees = new System.Windows.Forms.Button();
            this.rentals = new System.Windows.Forms.Button();
            this.reports = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customers
            // 
            this.customers.Location = new System.Drawing.Point(51, 59);
            this.customers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customers.Name = "customers";
            this.customers.Size = new System.Drawing.Size(122, 45);
            this.customers.TabIndex = 0;
            this.customers.Text = "Customers";
            this.customers.UseVisualStyleBackColor = true;
            this.customers.Click += new System.EventHandler(this.addEditCustomer_Click);
            // 
            // cars
            // 
            this.cars.Location = new System.Drawing.Point(51, 126);
            this.cars.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cars.Name = "cars";
            this.cars.Size = new System.Drawing.Size(122, 45);
            this.cars.TabIndex = 1;
            this.cars.Text = "Vehicles";
            this.cars.UseVisualStyleBackColor = true;
            this.cars.Click += new System.EventHandler(this.cars_Click);
            // 
            // branches
            // 
            this.branches.Location = new System.Drawing.Point(51, 199);
            this.branches.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.branches.Name = "branches";
            this.branches.Size = new System.Drawing.Size(122, 45);
            this.branches.TabIndex = 2;
            this.branches.Text = "Branches";
            this.branches.UseVisualStyleBackColor = true;
            this.branches.Click += new System.EventHandler(this.branches_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee area";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(461, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Customer Area";
            // 
            // viewRentalOptions
            // 
            this.viewRentalOptions.Location = new System.Drawing.Point(465, 126);
            this.viewRentalOptions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewRentalOptions.Name = "viewRentalOptions";
            this.viewRentalOptions.Size = new System.Drawing.Size(122, 45);
            this.viewRentalOptions.TabIndex = 5;
            this.viewRentalOptions.Text = "View Rental Options";
            this.viewRentalOptions.UseVisualStyleBackColor = true;
            // 
            // employees
            // 
            this.employees.Location = new System.Drawing.Point(51, 275);
            this.employees.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.employees.Name = "employees";
            this.employees.Size = new System.Drawing.Size(122, 45);
            this.employees.TabIndex = 6;
            this.employees.Text = "Employees";
            this.employees.UseVisualStyleBackColor = true;
            this.employees.Click += new System.EventHandler(this.employees_Click);
            // 
            // rentals
            // 
            this.rentals.Location = new System.Drawing.Point(191, 59);
            this.rentals.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rentals.Name = "rentals";
            this.rentals.Size = new System.Drawing.Size(122, 45);
            this.rentals.TabIndex = 7;
            this.rentals.Text = "Rentals";
            this.rentals.UseVisualStyleBackColor = true;
            this.rentals.Click += new System.EventHandler(this.rentals_Click);
            // 
            // reports
            // 
            this.reports.Location = new System.Drawing.Point(191, 126);
            this.reports.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reports.Name = "reports";
            this.reports.Size = new System.Drawing.Size(122, 45);
            this.reports.TabIndex = 8;
            this.reports.Text = "Reports";
            this.reports.UseVisualStyleBackColor = true;
            this.reports.Click += new System.EventHandler(this.reports_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 350);
            this.Controls.Add(this.reports);
            this.Controls.Add(this.rentals);
            this.Controls.Add(this.employees);
            this.Controls.Add(this.viewRentalOptions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.branches);
            this.Controls.Add(this.cars);
            this.Controls.Add(this.customers);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button customers;
        private System.Windows.Forms.Button cars;
        private System.Windows.Forms.Button branches;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button viewRentalOptions;
        private System.Windows.Forms.Button employees;
        private System.Windows.Forms.Button rentals;
        private System.Windows.Forms.Button reports;
    }
}