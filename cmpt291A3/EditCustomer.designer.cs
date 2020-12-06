
namespace cmpt291A3
{
    partial class EditCustomer
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
            this.customerIDLabel = new System.Windows.Forms.Label();
            this.customerFirstNameLabel = new System.Windows.Forms.Label();
            this.customerDrivingLicenseLabel = new System.Windows.Forms.Label();
            this.customerMembershipLabel = new System.Windows.Forms.Label();
            this.customerLastNameLabel = new System.Windows.Forms.Label();
            this.customerStreetNumberLabel = new System.Windows.Forms.Label();
            this.customerStreetNameLabel = new System.Windows.Forms.Label();
            this.customerApartmentNumberLabel = new System.Windows.Forms.Label();
            this.customerCityLabel = new System.Windows.Forms.Label();
            this.customerProvinceLabel = new System.Windows.Forms.Label();
            this.customerZIPLabel = new System.Windows.Forms.Label();
            this.customerPhoneNumberLabel = new System.Windows.Forms.Label();
            this.updateCustomerButton = new System.Windows.Forms.Button();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.removeCustomerButton = new System.Windows.Forms.Button();
            this.customerZIPTextBox = new System.Windows.Forms.TextBox();
            this.customerProvinceTextBox = new System.Windows.Forms.TextBox();
            this.customerFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.customerCityTextBox = new System.Windows.Forms.TextBox();
            this.customerApartmentNumberTextBox = new System.Windows.Forms.TextBox();
            this.customerStreetNameTextBox = new System.Windows.Forms.TextBox();
            this.customerStreetNumberTextBox = new System.Windows.Forms.TextBox();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.customerLastNameTextBox = new System.Windows.Forms.TextBox();
            this.customerDrivingLicenseTextBox = new System.Windows.Forms.TextBox();
            this.customerPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.customerEditConfirmationLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.customerGridView = new System.Windows.Forms.DataGridView();
            this.gROUP5291DataSet = new cmpt291A3.GROUP5291DataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new cmpt291A3.GROUP5291DataSetTableAdapters.CustomersTableAdapter();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drivinglicenseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membershipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aptnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerMembershipStatusTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP5291DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customerIDLabel
            // 
            this.customerIDLabel.AutoSize = true;
            this.customerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDLabel.Location = new System.Drawing.Point(28, 18);
            this.customerIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 25);
            this.customerIDLabel.Name = "customerIDLabel";
            this.customerIDLabel.Size = new System.Drawing.Size(121, 20);
            this.customerIDLabel.TabIndex = 0;
            this.customerIDLabel.Text = "Customer ID:";
            // 
            // customerFirstNameLabel
            // 
            this.customerFirstNameLabel.AutoSize = true;
            this.customerFirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerFirstNameLabel.Location = new System.Drawing.Point(28, 49);
            this.customerFirstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 25);
            this.customerFirstNameLabel.Name = "customerFirstNameLabel";
            this.customerFirstNameLabel.Size = new System.Drawing.Size(108, 20);
            this.customerFirstNameLabel.TabIndex = 1;
            this.customerFirstNameLabel.Text = "First Name:";
            // 
            // customerDrivingLicenseLabel
            // 
            this.customerDrivingLicenseLabel.AutoSize = true;
            this.customerDrivingLicenseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerDrivingLicenseLabel.Location = new System.Drawing.Point(28, 132);
            this.customerDrivingLicenseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 25);
            this.customerDrivingLicenseLabel.Name = "customerDrivingLicenseLabel";
            this.customerDrivingLicenseLabel.Size = new System.Drawing.Size(147, 20);
            this.customerDrivingLicenseLabel.TabIndex = 2;
            this.customerDrivingLicenseLabel.Text = "Driving License:";
            // 
            // customerMembershipLabel
            // 
            this.customerMembershipLabel.AutoSize = true;
            this.customerMembershipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerMembershipLabel.Location = new System.Drawing.Point(28, 224);
            this.customerMembershipLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 25);
            this.customerMembershipLabel.Name = "customerMembershipLabel";
            this.customerMembershipLabel.Size = new System.Drawing.Size(177, 20);
            this.customerMembershipLabel.TabIndex = 3;
            this.customerMembershipLabel.Text = "Membership Status:";
            // 
            // customerLastNameLabel
            // 
            this.customerLastNameLabel.AutoSize = true;
            this.customerLastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLastNameLabel.Location = new System.Drawing.Point(28, 87);
            this.customerLastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 25);
            this.customerLastNameLabel.Name = "customerLastNameLabel";
            this.customerLastNameLabel.Size = new System.Drawing.Size(106, 20);
            this.customerLastNameLabel.TabIndex = 4;
            this.customerLastNameLabel.Text = "Last Name:";
            // 
            // customerStreetNumberLabel
            // 
            this.customerStreetNumberLabel.AutoSize = true;
            this.customerStreetNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerStreetNumberLabel.Location = new System.Drawing.Point(583, 47);
            this.customerStreetNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 25);
            this.customerStreetNumberLabel.Name = "customerStreetNumberLabel";
            this.customerStreetNumberLabel.Size = new System.Drawing.Size(137, 20);
            this.customerStreetNumberLabel.TabIndex = 5;
            this.customerStreetNumberLabel.Text = "Street Number:";
            // 
            // customerStreetNameLabel
            // 
            this.customerStreetNameLabel.AutoSize = true;
            this.customerStreetNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerStreetNameLabel.Location = new System.Drawing.Point(583, 15);
            this.customerStreetNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 25);
            this.customerStreetNameLabel.Name = "customerStreetNameLabel";
            this.customerStreetNameLabel.Size = new System.Drawing.Size(120, 20);
            this.customerStreetNameLabel.TabIndex = 6;
            this.customerStreetNameLabel.Text = "Street Name:";
            // 
            // customerApartmentNumberLabel
            // 
            this.customerApartmentNumberLabel.AutoSize = true;
            this.customerApartmentNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerApartmentNumberLabel.Location = new System.Drawing.Point(583, 92);
            this.customerApartmentNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 25);
            this.customerApartmentNumberLabel.Name = "customerApartmentNumberLabel";
            this.customerApartmentNumberLabel.Size = new System.Drawing.Size(172, 20);
            this.customerApartmentNumberLabel.TabIndex = 7;
            this.customerApartmentNumberLabel.Text = "Apartment Number:";
            // 
            // customerCityLabel
            // 
            this.customerCityLabel.AutoSize = true;
            this.customerCityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerCityLabel.Location = new System.Drawing.Point(583, 137);
            this.customerCityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 25);
            this.customerCityLabel.Name = "customerCityLabel";
            this.customerCityLabel.Size = new System.Drawing.Size(48, 20);
            this.customerCityLabel.TabIndex = 8;
            this.customerCityLabel.Text = "City:";
            // 
            // customerProvinceLabel
            // 
            this.customerProvinceLabel.AutoSize = true;
            this.customerProvinceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerProvinceLabel.Location = new System.Drawing.Point(583, 182);
            this.customerProvinceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 25);
            this.customerProvinceLabel.Name = "customerProvinceLabel";
            this.customerProvinceLabel.Size = new System.Drawing.Size(88, 20);
            this.customerProvinceLabel.TabIndex = 9;
            this.customerProvinceLabel.Text = "Province:";
            // 
            // customerZIPLabel
            // 
            this.customerZIPLabel.AutoSize = true;
            this.customerZIPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerZIPLabel.Location = new System.Drawing.Point(583, 227);
            this.customerZIPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 25);
            this.customerZIPLabel.Name = "customerZIPLabel";
            this.customerZIPLabel.Size = new System.Drawing.Size(42, 20);
            this.customerZIPLabel.TabIndex = 10;
            this.customerZIPLabel.Text = "ZIP:";
            // 
            // customerPhoneNumberLabel
            // 
            this.customerPhoneNumberLabel.AutoSize = true;
            this.customerPhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerPhoneNumberLabel.Location = new System.Drawing.Point(28, 176);
            this.customerPhoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 25);
            this.customerPhoneNumberLabel.Name = "customerPhoneNumberLabel";
            this.customerPhoneNumberLabel.Size = new System.Drawing.Size(138, 20);
            this.customerPhoneNumberLabel.TabIndex = 11;
            this.customerPhoneNumberLabel.Text = "Phone Number:";
            // 
            // updateCustomerButton
            // 
            this.updateCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCustomerButton.Location = new System.Drawing.Point(222, 314);
            this.updateCustomerButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateCustomerButton.Name = "updateCustomerButton";
            this.updateCustomerButton.Size = new System.Drawing.Size(133, 62);
            this.updateCustomerButton.TabIndex = 12;
            this.updateCustomerButton.Text = "Update";
            this.updateCustomerButton.UseVisualStyleBackColor = true;
            this.updateCustomerButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.updateCustomerButton_MouseClick);
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerButton.Location = new System.Drawing.Point(454, 314);
            this.addCustomerButton.Margin = new System.Windows.Forms.Padding(4);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(133, 62);
            this.addCustomerButton.TabIndex = 13;
            this.addCustomerButton.Text = "Add";
            this.addCustomerButton.UseVisualStyleBackColor = true;
            this.addCustomerButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addCustomerButton_MouseClick);
            // 
            // removeCustomerButton
            // 
            this.removeCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeCustomerButton.Location = new System.Drawing.Point(677, 314);
            this.removeCustomerButton.Margin = new System.Windows.Forms.Padding(4);
            this.removeCustomerButton.Name = "removeCustomerButton";
            this.removeCustomerButton.Size = new System.Drawing.Size(133, 62);
            this.removeCustomerButton.TabIndex = 14;
            this.removeCustomerButton.Text = "Delete";
            this.removeCustomerButton.UseVisualStyleBackColor = true;
            this.removeCustomerButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.removeCustomerButton_MouseClick);
            // 
            // customerZIPTextBox
            // 
            this.customerZIPTextBox.Location = new System.Drawing.Point(795, 227);
            this.customerZIPTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.customerZIPTextBox.Name = "customerZIPTextBox";
            this.customerZIPTextBox.Size = new System.Drawing.Size(187, 22);
            this.customerZIPTextBox.TabIndex = 16;
            // 
            // customerProvinceTextBox
            // 
            this.customerProvinceTextBox.Location = new System.Drawing.Point(795, 182);
            this.customerProvinceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.customerProvinceTextBox.Name = "customerProvinceTextBox";
            this.customerProvinceTextBox.Size = new System.Drawing.Size(187, 22);
            this.customerProvinceTextBox.TabIndex = 17;
            // 
            // customerFirstNameTextBox
            // 
            this.customerFirstNameTextBox.Location = new System.Drawing.Point(243, 49);
            this.customerFirstNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.customerFirstNameTextBox.Name = "customerFirstNameTextBox";
            this.customerFirstNameTextBox.Size = new System.Drawing.Size(187, 22);
            this.customerFirstNameTextBox.TabIndex = 18;
            // 
            // customerCityTextBox
            // 
            this.customerCityTextBox.Location = new System.Drawing.Point(795, 137);
            this.customerCityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.customerCityTextBox.Name = "customerCityTextBox";
            this.customerCityTextBox.Size = new System.Drawing.Size(187, 22);
            this.customerCityTextBox.TabIndex = 19;
            // 
            // customerApartmentNumberTextBox
            // 
            this.customerApartmentNumberTextBox.Location = new System.Drawing.Point(795, 92);
            this.customerApartmentNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.customerApartmentNumberTextBox.Name = "customerApartmentNumberTextBox";
            this.customerApartmentNumberTextBox.Size = new System.Drawing.Size(187, 22);
            this.customerApartmentNumberTextBox.TabIndex = 20;
            // 
            // customerStreetNameTextBox
            // 
            this.customerStreetNameTextBox.Location = new System.Drawing.Point(795, 7);
            this.customerStreetNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.customerStreetNameTextBox.Name = "customerStreetNameTextBox";
            this.customerStreetNameTextBox.Size = new System.Drawing.Size(187, 22);
            this.customerStreetNameTextBox.TabIndex = 21;
            // 
            // customerStreetNumberTextBox
            // 
            this.customerStreetNumberTextBox.Location = new System.Drawing.Point(795, 47);
            this.customerStreetNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.customerStreetNumberTextBox.Name = "customerStreetNumberTextBox";
            this.customerStreetNumberTextBox.Size = new System.Drawing.Size(187, 22);
            this.customerStreetNumberTextBox.TabIndex = 22;
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.Location = new System.Drawing.Point(243, 13);
            this.customerIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(187, 22);
            this.customerIDTextBox.TabIndex = 23;
            // 
            // customerLastNameTextBox
            // 
            this.customerLastNameTextBox.Location = new System.Drawing.Point(243, 89);
            this.customerLastNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.customerLastNameTextBox.Name = "customerLastNameTextBox";
            this.customerLastNameTextBox.Size = new System.Drawing.Size(187, 22);
            this.customerLastNameTextBox.TabIndex = 24;
            // 
            // customerDrivingLicenseTextBox
            // 
            this.customerDrivingLicenseTextBox.Location = new System.Drawing.Point(243, 133);
            this.customerDrivingLicenseTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.customerDrivingLicenseTextBox.Name = "customerDrivingLicenseTextBox";
            this.customerDrivingLicenseTextBox.Size = new System.Drawing.Size(187, 22);
            this.customerDrivingLicenseTextBox.TabIndex = 25;
            // 
            // customerPhoneNumberTextBox
            // 
            this.customerPhoneNumberTextBox.Location = new System.Drawing.Point(243, 174);
            this.customerPhoneNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.customerPhoneNumberTextBox.Name = "customerPhoneNumberTextBox";
            this.customerPhoneNumberTextBox.Size = new System.Drawing.Size(187, 22);
            this.customerPhoneNumberTextBox.TabIndex = 26;
            // 
            // customerEditConfirmationLabel
            // 
            this.customerEditConfirmationLabel.AutoSize = true;
            this.customerEditConfirmationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerEditConfirmationLabel.Location = new System.Drawing.Point(334, 422);
            this.customerEditConfirmationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerEditConfirmationLabel.Name = "customerEditConfirmationLabel";
            this.customerEditConfirmationLabel.Size = new System.Drawing.Size(297, 29);
            this.customerEditConfirmationLabel.TabIndex = 27;
            this.customerEditConfirmationLabel.Text = "<Confirmation Message>";
            this.customerEditConfirmationLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customerEditConfirmationLabel.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1018, 519);
            this.tabControl1.TabIndex = 28;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.backButton);
            this.tabPage1.Controls.Add(this.customerMembershipStatusTextBox);
            this.tabPage1.Controls.Add(this.customerEditConfirmationLabel);
            this.tabPage1.Controls.Add(this.customerIDLabel);
            this.tabPage1.Controls.Add(this.removeCustomerButton);
            this.tabPage1.Controls.Add(this.customerZIPTextBox);
            this.tabPage1.Controls.Add(this.addCustomerButton);
            this.tabPage1.Controls.Add(this.customerProvinceTextBox);
            this.tabPage1.Controls.Add(this.updateCustomerButton);
            this.tabPage1.Controls.Add(this.customerCityTextBox);
            this.tabPage1.Controls.Add(this.customerApartmentNumberTextBox);
            this.tabPage1.Controls.Add(this.customerStreetNumberTextBox);
            this.tabPage1.Controls.Add(this.customerPhoneNumberTextBox);
            this.tabPage1.Controls.Add(this.customerStreetNameTextBox);
            this.tabPage1.Controls.Add(this.customerFirstNameLabel);
            this.tabPage1.Controls.Add(this.customerDrivingLicenseTextBox);
            this.tabPage1.Controls.Add(this.customerLastNameLabel);
            this.tabPage1.Controls.Add(this.customerLastNameTextBox);
            this.tabPage1.Controls.Add(this.customerDrivingLicenseLabel);
            this.tabPage1.Controls.Add(this.customerIDTextBox);
            this.tabPage1.Controls.Add(this.customerPhoneNumberLabel);
            this.tabPage1.Controls.Add(this.customerZIPLabel);
            this.tabPage1.Controls.Add(this.customerMembershipLabel);
            this.tabPage1.Controls.Add(this.customerProvinceLabel);
            this.tabPage1.Controls.Add(this.customerFirstNameTextBox);
            this.tabPage1.Controls.Add(this.customerCityLabel);
            this.tabPage1.Controls.Add(this.customerStreetNameLabel);
            this.tabPage1.Controls.Add(this.customerApartmentNumberLabel);
            this.tabPage1.Controls.Add(this.customerStreetNumberLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1010, 490);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add/Edit";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.customerGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1010, 490);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Query";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // customerGridView
            // 
            this.customerGridView.AutoGenerateColumns = false;
            this.customerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.drivinglicenseDataGridViewTextBoxColumn,
            this.membershipDataGridViewTextBoxColumn,
            this.streetnameDataGridViewTextBoxColumn,
            this.streetnumberDataGridViewTextBoxColumn,
            this.aptnumberDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.provinceDataGridViewTextBoxColumn,
            this.zipDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn});
            this.customerGridView.DataSource = this.customersBindingSource;
            this.customerGridView.Location = new System.Drawing.Point(6, 6);
            this.customerGridView.Name = "customerGridView";
            this.customerGridView.RowHeadersWidth = 51;
            this.customerGridView.RowTemplate.Height = 24;
            this.customerGridView.Size = new System.Drawing.Size(998, 478);
            this.customerGridView.TabIndex = 0;
            // 
            // gROUP5291DataSet
            // 
            this.gROUP5291DataSet.DataSetName = "GROUP5291DataSet";
            this.gROUP5291DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.gROUP5291DataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "Customer ID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // drivinglicenseDataGridViewTextBoxColumn
            // 
            this.drivinglicenseDataGridViewTextBoxColumn.DataPropertyName = "driving_license";
            this.drivinglicenseDataGridViewTextBoxColumn.HeaderText = "Drivers License #";
            this.drivinglicenseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.drivinglicenseDataGridViewTextBoxColumn.Name = "drivinglicenseDataGridViewTextBoxColumn";
            this.drivinglicenseDataGridViewTextBoxColumn.Width = 125;
            // 
            // membershipDataGridViewTextBoxColumn
            // 
            this.membershipDataGridViewTextBoxColumn.DataPropertyName = "membership";
            this.membershipDataGridViewTextBoxColumn.HeaderText = "Membership";
            this.membershipDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.membershipDataGridViewTextBoxColumn.Name = "membershipDataGridViewTextBoxColumn";
            this.membershipDataGridViewTextBoxColumn.Width = 125;
            // 
            // streetnameDataGridViewTextBoxColumn
            // 
            this.streetnameDataGridViewTextBoxColumn.DataPropertyName = "street_name";
            this.streetnameDataGridViewTextBoxColumn.HeaderText = "Street Name";
            this.streetnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.streetnameDataGridViewTextBoxColumn.Name = "streetnameDataGridViewTextBoxColumn";
            this.streetnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // streetnumberDataGridViewTextBoxColumn
            // 
            this.streetnumberDataGridViewTextBoxColumn.DataPropertyName = "street_number";
            this.streetnumberDataGridViewTextBoxColumn.HeaderText = "Street Number";
            this.streetnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.streetnumberDataGridViewTextBoxColumn.Name = "streetnumberDataGridViewTextBoxColumn";
            this.streetnumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // aptnumberDataGridViewTextBoxColumn
            // 
            this.aptnumberDataGridViewTextBoxColumn.DataPropertyName = "apt_number";
            this.aptnumberDataGridViewTextBoxColumn.HeaderText = "Appartment Number";
            this.aptnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aptnumberDataGridViewTextBoxColumn.Name = "aptnumberDataGridViewTextBoxColumn";
            this.aptnumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.Width = 125;
            // 
            // provinceDataGridViewTextBoxColumn
            // 
            this.provinceDataGridViewTextBoxColumn.DataPropertyName = "province";
            this.provinceDataGridViewTextBoxColumn.HeaderText = "Province";
            this.provinceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.provinceDataGridViewTextBoxColumn.Name = "provinceDataGridViewTextBoxColumn";
            this.provinceDataGridViewTextBoxColumn.Width = 125;
            // 
            // zipDataGridViewTextBoxColumn
            // 
            this.zipDataGridViewTextBoxColumn.DataPropertyName = "zip";
            this.zipDataGridViewTextBoxColumn.HeaderText = "Zip";
            this.zipDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.zipDataGridViewTextBoxColumn.Name = "zipDataGridViewTextBoxColumn";
            this.zipDataGridViewTextBoxColumn.Width = 125;
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.phonenumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            this.phonenumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerMembershipStatusTextBox
            // 
            this.customerMembershipStatusTextBox.Location = new System.Drawing.Point(243, 222);
            this.customerMembershipStatusTextBox.Name = "customerMembershipStatusTextBox";
            this.customerMembershipStatusTextBox.Size = new System.Drawing.Size(187, 22);
            this.customerMembershipStatusTextBox.TabIndex = 28;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(18, 451);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 29;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // EditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditCustomer";
            this.Text = "Edit Customer";
            this.Load += new System.EventHandler(this.EditCustomer_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP5291DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label customerIDLabel;
        private System.Windows.Forms.Label customerFirstNameLabel;
        private System.Windows.Forms.Label customerDrivingLicenseLabel;
        private System.Windows.Forms.Label customerMembershipLabel;
        private System.Windows.Forms.Label customerLastNameLabel;
        private System.Windows.Forms.Label customerStreetNumberLabel;
        private System.Windows.Forms.Label customerStreetNameLabel;
        private System.Windows.Forms.Label customerApartmentNumberLabel;
        private System.Windows.Forms.Label customerCityLabel;
        private System.Windows.Forms.Label customerProvinceLabel;
        private System.Windows.Forms.Label customerZIPLabel;
        private System.Windows.Forms.Label customerPhoneNumberLabel;
        private System.Windows.Forms.Button updateCustomerButton;
        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.Button removeCustomerButton;
        private System.Windows.Forms.TextBox customerZIPTextBox;
        private System.Windows.Forms.TextBox customerProvinceTextBox;
        private System.Windows.Forms.TextBox customerFirstNameTextBox;
        private System.Windows.Forms.TextBox customerCityTextBox;
        private System.Windows.Forms.TextBox customerApartmentNumberTextBox;
        private System.Windows.Forms.TextBox customerStreetNameTextBox;
        private System.Windows.Forms.TextBox customerStreetNumberTextBox;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.TextBox customerLastNameTextBox;
        private System.Windows.Forms.TextBox customerDrivingLicenseTextBox;
        private System.Windows.Forms.TextBox customerPhoneNumberTextBox;
        private System.Windows.Forms.Label customerEditConfirmationLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView customerGridView;
        private GROUP5291DataSet gROUP5291DataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private GROUP5291DataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drivinglicenseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn membershipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aptnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox customerMembershipStatusTextBox;
    }
}