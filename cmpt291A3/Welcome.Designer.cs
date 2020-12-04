
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
            this.addEditCustomer = new System.Windows.Forms.Button();
            this.addEditCar = new System.Windows.Forms.Button();
            this.addEditBranch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.viewRentalOptions = new System.Windows.Forms.Button();
            this.addEditEmployee = new System.Windows.Forms.Button();
            this.beginEditRental = new System.Windows.Forms.Button();
            this.returnRental = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addEditCustomer
            // 
            this.addEditCustomer.Location = new System.Drawing.Point(68, 73);
            this.addEditCustomer.Name = "addEditCustomer";
            this.addEditCustomer.Size = new System.Drawing.Size(163, 55);
            this.addEditCustomer.TabIndex = 0;
            this.addEditCustomer.Text = "Add/Edit Customer";
            this.addEditCustomer.UseVisualStyleBackColor = true;
            this.addEditCustomer.Click += new System.EventHandler(this.addEditCustomer_Click);
            // 
            // addEditCar
            // 
            this.addEditCar.Location = new System.Drawing.Point(68, 155);
            this.addEditCar.Name = "addEditCar";
            this.addEditCar.Size = new System.Drawing.Size(163, 55);
            this.addEditCar.TabIndex = 1;
            this.addEditCar.Text = "Add/Edit Car";
            this.addEditCar.UseVisualStyleBackColor = true;
            // 
            // addEditBranch
            // 
            this.addEditBranch.Location = new System.Drawing.Point(68, 245);
            this.addEditBranch.Name = "addEditBranch";
            this.addEditBranch.Size = new System.Drawing.Size(163, 55);
            this.addEditBranch.TabIndex = 2;
            this.addEditBranch.Text = "Add/Edit Branch";
            this.addEditBranch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee area";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(615, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Customer Area";
            // 
            // viewRentalOptions
            // 
            this.viewRentalOptions.Location = new System.Drawing.Point(620, 155);
            this.viewRentalOptions.Name = "viewRentalOptions";
            this.viewRentalOptions.Size = new System.Drawing.Size(163, 55);
            this.viewRentalOptions.TabIndex = 5;
            this.viewRentalOptions.Text = "View Rental Options";
            this.viewRentalOptions.UseVisualStyleBackColor = true;
            // 
            // addEditEmployee
            // 
            this.addEditEmployee.Location = new System.Drawing.Point(68, 339);
            this.addEditEmployee.Name = "addEditEmployee";
            this.addEditEmployee.Size = new System.Drawing.Size(163, 55);
            this.addEditEmployee.TabIndex = 6;
            this.addEditEmployee.Text = "Add/Edit employee";
            this.addEditEmployee.UseVisualStyleBackColor = true;
            // 
            // beginEditRental
            // 
            this.beginEditRental.Location = new System.Drawing.Point(255, 73);
            this.beginEditRental.Name = "beginEditRental";
            this.beginEditRental.Size = new System.Drawing.Size(163, 55);
            this.beginEditRental.TabIndex = 7;
            this.beginEditRental.Text = "Begin/Edit Rental";
            this.beginEditRental.UseVisualStyleBackColor = true;
            // 
            // returnRental
            // 
            this.returnRental.Location = new System.Drawing.Point(255, 155);
            this.returnRental.Name = "returnRental";
            this.returnRental.Size = new System.Drawing.Size(163, 55);
            this.returnRental.TabIndex = 8;
            this.returnRental.Text = "Rental Return";
            this.returnRental.UseVisualStyleBackColor = true;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 488);
            this.Controls.Add(this.returnRental);
            this.Controls.Add(this.beginEditRental);
            this.Controls.Add(this.addEditEmployee);
            this.Controls.Add(this.viewRentalOptions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addEditBranch);
            this.Controls.Add(this.addEditCar);
            this.Controls.Add(this.addEditCustomer);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addEditCustomer;
        private System.Windows.Forms.Button addEditCar;
        private System.Windows.Forms.Button addEditBranch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button viewRentalOptions;
        private System.Windows.Forms.Button addEditEmployee;
        private System.Windows.Forms.Button beginEditRental;
        private System.Windows.Forms.Button returnRental;
    }
}