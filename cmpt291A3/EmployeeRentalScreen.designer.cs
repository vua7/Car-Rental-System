namespace cmpt291A3
{
    partial class EmployeeRentalScreen
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.return_date_datepicker = new System.Windows.Forms.DateTimePicker();
            this.pickup_date_datepicker = new System.Windows.Forms.DateTimePicker();
            this.confirm_rental_button = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.vin_textbox = new System.Windows.Forms.TextBox();
            this.VIN_label = new System.Windows.Forms.Label();
            this.return_branch_label = new System.Windows.Forms.Label();
            this.customer_ID_textbox = new System.Windows.Forms.TextBox();
            this.rental_Id_textbox = new System.Windows.Forms.TextBox();
            this.Pickup_date_Label = new System.Windows.Forms.Label();
            this.Pickup_branch_label = new System.Windows.Forms.Label();
            this.Return_date_label = new System.Windows.Forms.Label();
            this.Customer_ID_label = new System.Windows.Forms.Label();
            this.Rental_ID_Label = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ReturnBranchRental = new System.Windows.Forms.ComboBox();
            this.PickupBranchRental = new System.Windows.Forms.ComboBox();
            this.VehichleRTab = new System.Windows.Forms.ComboBox();
            this.TimePickupRental = new System.Windows.Forms.DateTimePicker();
            this.TimeReturnRental = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.employee_ID_label = new System.Windows.Forms.Label();
            this.FindCustomerButtn = new System.Windows.Forms.Button();
            this.employee_ID_textbox = new System.Windows.Forms.TextBox();
            this.back_button = new System.Windows.Forms.Button();
            this.CIDErrorMessg = new System.Windows.Forms.Label();
            this.return_branch_ID_textbox = new System.Windows.Forms.TextBox();
            this.pickup_branch_ID_textbox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(342, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(446, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pickup_branch_ID_textbox);
            this.tabPage1.Controls.Add(this.return_branch_ID_textbox);
            this.tabPage1.Controls.Add(this.return_date_datepicker);
            this.tabPage1.Controls.Add(this.pickup_date_datepicker);
            this.tabPage1.Controls.Add(this.confirm_rental_button);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.vin_textbox);
            this.tabPage1.Controls.Add(this.VIN_label);
            this.tabPage1.Controls.Add(this.return_branch_label);
            this.tabPage1.Controls.Add(this.customer_ID_textbox);
            this.tabPage1.Controls.Add(this.rental_Id_textbox);
            this.tabPage1.Controls.Add(this.Pickup_date_Label);
            this.tabPage1.Controls.Add(this.Pickup_branch_label);
            this.tabPage1.Controls.Add(this.Return_date_label);
            this.tabPage1.Controls.Add(this.Customer_ID_label);
            this.tabPage1.Controls.Add(this.Rental_ID_Label);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(438, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rent";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // return_date_datepicker
            // 
            this.return_date_datepicker.Location = new System.Drawing.Point(147, 81);
            this.return_date_datepicker.Name = "return_date_datepicker";
            this.return_date_datepicker.Size = new System.Drawing.Size(285, 26);
            this.return_date_datepicker.TabIndex = 18;
            // 
            // pickup_date_datepicker
            // 
            this.pickup_date_datepicker.Location = new System.Drawing.Point(147, 51);
            this.pickup_date_datepicker.Name = "pickup_date_datepicker";
            this.pickup_date_datepicker.Size = new System.Drawing.Size(285, 26);
            this.pickup_date_datepicker.TabIndex = 17;
            // 
            // confirm_rental_button
            // 
            this.confirm_rental_button.Location = new System.Drawing.Point(6, 351);
            this.confirm_rental_button.Name = "confirm_rental_button";
            this.confirm_rental_button.Size = new System.Drawing.Size(426, 36);
            this.confirm_rental_button.TabIndex = 16;
            this.confirm_rental_button.Text = "Confirm Rental";
            this.confirm_rental_button.UseVisualStyleBackColor = true;
            this.confirm_rental_button.Click += new System.EventHandler(this.confirm_rental_button_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(147, 277);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(285, 26);
            this.textBox3.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 283);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 20);
            this.label14.TabIndex = 14;
            this.label14.Text = "Final Price:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // vin_textbox
            // 
            this.vin_textbox.Location = new System.Drawing.Point(147, 213);
            this.vin_textbox.Name = "vin_textbox";
            this.vin_textbox.Size = new System.Drawing.Size(285, 26);
            this.vin_textbox.TabIndex = 13;
            // 
            // VIN_label
            // 
            this.VIN_label.AutoSize = true;
            this.VIN_label.Location = new System.Drawing.Point(6, 219);
            this.VIN_label.Name = "VIN_label";
            this.VIN_label.Size = new System.Drawing.Size(40, 20);
            this.VIN_label.TabIndex = 12;
            this.VIN_label.Text = "VIN:";
            // 
            // return_branch_label
            // 
            this.return_branch_label.AutoSize = true;
            this.return_branch_label.Location = new System.Drawing.Point(6, 187);
            this.return_branch_label.Name = "return_branch_label";
            this.return_branch_label.Size = new System.Drawing.Size(138, 20);
            this.return_branch_label.TabIndex = 10;
            this.return_branch_label.Text = "Return Branch ID:";
            // 
            // customer_ID_textbox
            // 
            this.customer_ID_textbox.Location = new System.Drawing.Point(147, 113);
            this.customer_ID_textbox.Name = "customer_ID_textbox";
            this.customer_ID_textbox.Size = new System.Drawing.Size(285, 26);
            this.customer_ID_textbox.TabIndex = 8;
            // 
            // rental_Id_textbox
            // 
            this.rental_Id_textbox.Location = new System.Drawing.Point(147, 19);
            this.rental_Id_textbox.Name = "rental_Id_textbox";
            this.rental_Id_textbox.Size = new System.Drawing.Size(285, 26);
            this.rental_Id_textbox.TabIndex = 5;
            // 
            // Pickup_date_Label
            // 
            this.Pickup_date_Label.AutoSize = true;
            this.Pickup_date_Label.Location = new System.Drawing.Point(6, 55);
            this.Pickup_date_Label.Name = "Pickup_date_Label";
            this.Pickup_date_Label.Size = new System.Drawing.Size(95, 20);
            this.Pickup_date_Label.TabIndex = 4;
            this.Pickup_date_Label.Text = "Pickup Date";
            // 
            // Pickup_branch_label
            // 
            this.Pickup_branch_label.AutoSize = true;
            this.Pickup_branch_label.Location = new System.Drawing.Point(6, 153);
            this.Pickup_branch_label.Name = "Pickup_branch_label";
            this.Pickup_branch_label.Size = new System.Drawing.Size(136, 20);
            this.Pickup_branch_label.TabIndex = 3;
            this.Pickup_branch_label.Text = "Pickup Branch ID:";
            // 
            // Return_date_label
            // 
            this.Return_date_label.AutoSize = true;
            this.Return_date_label.Location = new System.Drawing.Point(6, 87);
            this.Return_date_label.Name = "Return_date_label";
            this.Return_date_label.Size = new System.Drawing.Size(101, 20);
            this.Return_date_label.TabIndex = 2;
            this.Return_date_label.Text = "Return Date:";
            // 
            // Customer_ID_label
            // 
            this.Customer_ID_label.AutoSize = true;
            this.Customer_ID_label.Location = new System.Drawing.Point(6, 119);
            this.Customer_ID_label.Name = "Customer_ID_label";
            this.Customer_ID_label.Size = new System.Drawing.Size(103, 20);
            this.Customer_ID_label.TabIndex = 1;
            this.Customer_ID_label.Text = "Customer ID:";
            // 
            // Rental_ID_Label
            // 
            this.Rental_ID_Label.AutoSize = true;
            this.Rental_ID_Label.Location = new System.Drawing.Point(6, 24);
            this.Rental_ID_Label.Name = "Rental_ID_Label";
            this.Rental_ID_Label.Size = new System.Drawing.Size(82, 20);
            this.Rental_ID_Label.TabIndex = 0;
            this.Rental_ID_Label.Text = "Rental_ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ReturnBranchRental);
            this.tabPage2.Controls.Add(this.PickupBranchRental);
            this.tabPage2.Controls.Add(this.VehichleRTab);
            this.tabPage2.Controls.Add(this.TimePickupRental);
            this.tabPage2.Controls.Add(this.TimeReturnRental);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(438, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Return";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ReturnBranchRental
            // 
            this.ReturnBranchRental.FormattingEnabled = true;
            this.ReturnBranchRental.Items.AddRange(new object[] {
            "North",
            "South",
            "West ",
            "East"});
            this.ReturnBranchRental.Location = new System.Drawing.Point(200, 294);
            this.ReturnBranchRental.Name = "ReturnBranchRental";
            this.ReturnBranchRental.Size = new System.Drawing.Size(200, 28);
            this.ReturnBranchRental.TabIndex = 11;
            // 
            // PickupBranchRental
            // 
            this.PickupBranchRental.FormattingEnabled = true;
            this.PickupBranchRental.Items.AddRange(new object[] {
            "North",
            "South",
            "West ",
            "East"});
            this.PickupBranchRental.Location = new System.Drawing.Point(200, 241);
            this.PickupBranchRental.Name = "PickupBranchRental";
            this.PickupBranchRental.Size = new System.Drawing.Size(200, 28);
            this.PickupBranchRental.TabIndex = 10;
            // 
            // VehichleRTab
            // 
            this.VehichleRTab.FormattingEnabled = true;
            this.VehichleRTab.Items.AddRange(new object[] {
            "Car",
            "Truck",
            "Van"});
            this.VehichleRTab.Location = new System.Drawing.Point(200, 57);
            this.VehichleRTab.Name = "VehichleRTab";
            this.VehichleRTab.Size = new System.Drawing.Size(200, 28);
            this.VehichleRTab.TabIndex = 8;
            // 
            // TimePickupRental
            // 
            this.TimePickupRental.Location = new System.Drawing.Point(200, 116);
            this.TimePickupRental.Name = "TimePickupRental";
            this.TimePickupRental.Size = new System.Drawing.Size(200, 26);
            this.TimePickupRental.TabIndex = 7;
            // 
            // TimeReturnRental
            // 
            this.TimeReturnRental.Location = new System.Drawing.Point(200, 174);
            this.TimeReturnRental.Name = "TimeReturnRental";
            this.TimeReturnRental.Size = new System.Drawing.Size(200, 26);
            this.TimeReturnRental.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(47, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "Pickup Date:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Return Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 302);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Return Branch:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Pickup Branch:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Vehichle Type:";
            // 
            // employee_ID_label
            // 
            this.employee_ID_label.AutoSize = true;
            this.employee_ID_label.Location = new System.Drawing.Point(12, 66);
            this.employee_ID_label.Name = "employee_ID_label";
            this.employee_ID_label.Size = new System.Drawing.Size(143, 20);
            this.employee_ID_label.TabIndex = 1;
            this.employee_ID_label.Text = "Enter Employee ID";
            this.employee_ID_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // FindCustomerButtn
            // 
            this.FindCustomerButtn.Location = new System.Drawing.Point(12, 399);
            this.FindCustomerButtn.Name = "FindCustomerButtn";
            this.FindCustomerButtn.Size = new System.Drawing.Size(303, 35);
            this.FindCustomerButtn.TabIndex = 2;
            this.FindCustomerButtn.Text = "Find Customer";
            this.FindCustomerButtn.UseVisualStyleBackColor = true;
            this.FindCustomerButtn.Click += new System.EventHandler(this.FindCustomerButtn_Click);
            // 
            // employee_ID_textbox
            // 
            this.employee_ID_textbox.Location = new System.Drawing.Point(177, 59);
            this.employee_ID_textbox.Name = "employee_ID_textbox";
            this.employee_ID_textbox.Size = new System.Drawing.Size(142, 26);
            this.employee_ID_textbox.TabIndex = 3;
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(13, 12);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 31);
            this.back_button.TabIndex = 5;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // CIDErrorMessg
            // 
            this.CIDErrorMessg.AutoSize = true;
            this.CIDErrorMessg.ForeColor = System.Drawing.Color.Red;
            this.CIDErrorMessg.Location = new System.Drawing.Point(52, 108);
            this.CIDErrorMessg.Name = "CIDErrorMessg";
            this.CIDErrorMessg.Size = new System.Drawing.Size(216, 20);
            this.CIDErrorMessg.TabIndex = 4;
            this.CIDErrorMessg.Text = "Error enter valid customerr ID";
            this.CIDErrorMessg.Visible = false;
            // 
            // return_branch_ID_textbox
            // 
            this.return_branch_ID_textbox.Location = new System.Drawing.Point(147, 179);
            this.return_branch_ID_textbox.Name = "return_branch_ID_textbox";
            this.return_branch_ID_textbox.Size = new System.Drawing.Size(285, 26);
            this.return_branch_ID_textbox.TabIndex = 19;
            // 
            // pickup_branch_ID_textbox
            // 
            this.pickup_branch_ID_textbox.Location = new System.Drawing.Point(147, 147);
            this.pickup_branch_ID_textbox.Name = "pickup_branch_ID_textbox";
            this.pickup_branch_ID_textbox.Size = new System.Drawing.Size(285, 26);
            this.pickup_branch_ID_textbox.TabIndex = 20;
            // 
            // EmployeeRentalScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.CIDErrorMessg);
            this.Controls.Add(this.employee_ID_textbox);
            this.Controls.Add(this.FindCustomerButtn);
            this.Controls.Add(this.employee_ID_label);
            this.Controls.Add(this.tabControl1);
            this.Name = "EmployeeRentalScreen";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label employee_ID_label;
        private System.Windows.Forms.Button FindCustomerButtn;
        private System.Windows.Forms.TextBox employee_ID_textbox;
        private System.Windows.Forms.Label Pickup_date_Label;
        private System.Windows.Forms.Label Pickup_branch_label;
        private System.Windows.Forms.Label Return_date_label;
        private System.Windows.Forms.Label Customer_ID_label;
        private System.Windows.Forms.Label Rental_ID_Label;
        private System.Windows.Forms.TextBox customer_ID_textbox;
        private System.Windows.Forms.TextBox rental_Id_textbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker TimePickupRental;
        private System.Windows.Forms.DateTimePicker TimeReturnRental;
        private System.Windows.Forms.ComboBox ReturnBranchRental;
        private System.Windows.Forms.ComboBox PickupBranchRental;
        private System.Windows.Forms.ComboBox VehichleRTab;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label CIDErrorMessg;
        private System.Windows.Forms.Button confirm_rental_button;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox vin_textbox;
        private System.Windows.Forms.Label VIN_label;
        private System.Windows.Forms.Label return_branch_label;
        private System.Windows.Forms.DateTimePicker return_date_datepicker;
        private System.Windows.Forms.DateTimePicker pickup_date_datepicker;
        private System.Windows.Forms.TextBox pickup_branch_ID_textbox;
        private System.Windows.Forms.TextBox return_branch_ID_textbox;
    }
}