
namespace cmpt291A3
{
    partial class Branches
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
            this.addEditPage = new System.Windows.Forms.TabPage();
            this.queryPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.branchIDTextBox = new System.Windows.Forms.TextBox();
            this.streetNameTextBox = new System.Windows.Forms.TextBox();
            this.StreetNumberTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.provinceTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.addEditPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.addEditPage);
            this.tabControl1.Controls.Add(this.queryPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // addEditPage
            // 
            this.addEditPage.Controls.Add(this.deleteButton);
            this.addEditPage.Controls.Add(this.addButton);
            this.addEditPage.Controls.Add(this.updateButton);
            this.addEditPage.Controls.Add(this.phoneNumberTextBox);
            this.addEditPage.Controls.Add(this.zipTextBox);
            this.addEditPage.Controls.Add(this.provinceTextBox);
            this.addEditPage.Controls.Add(this.cityTextBox);
            this.addEditPage.Controls.Add(this.StreetNumberTextBox);
            this.addEditPage.Controls.Add(this.streetNameTextBox);
            this.addEditPage.Controls.Add(this.branchIDTextBox);
            this.addEditPage.Controls.Add(this.label7);
            this.addEditPage.Controls.Add(this.label6);
            this.addEditPage.Controls.Add(this.label5);
            this.addEditPage.Controls.Add(this.label4);
            this.addEditPage.Controls.Add(this.label3);
            this.addEditPage.Controls.Add(this.label2);
            this.addEditPage.Controls.Add(this.label1);
            this.addEditPage.Location = new System.Drawing.Point(4, 25);
            this.addEditPage.Name = "addEditPage";
            this.addEditPage.Padding = new System.Windows.Forms.Padding(3);
            this.addEditPage.Size = new System.Drawing.Size(768, 397);
            this.addEditPage.TabIndex = 0;
            this.addEditPage.Text = "Add/Edit";
            this.addEditPage.UseVisualStyleBackColor = true;
            // 
            // queryPage
            // 
            this.queryPage.Location = new System.Drawing.Point(4, 25);
            this.queryPage.Name = "queryPage";
            this.queryPage.Padding = new System.Windows.Forms.Padding(3);
            this.queryPage.Size = new System.Drawing.Size(768, 397);
            this.queryPage.TabIndex = 1;
            this.queryPage.Text = "Query";
            this.queryPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Branch ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Street Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Street Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "City:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(429, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Province:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(429, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "ZIP:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(429, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Phone Number:";
            // 
            // branchIDTextBox
            // 
            this.branchIDTextBox.Location = new System.Drawing.Point(192, 50);
            this.branchIDTextBox.Name = "branchIDTextBox";
            this.branchIDTextBox.Size = new System.Drawing.Size(177, 22);
            this.branchIDTextBox.TabIndex = 7;
            // 
            // streetNameTextBox
            // 
            this.streetNameTextBox.Location = new System.Drawing.Point(192, 96);
            this.streetNameTextBox.Name = "streetNameTextBox";
            this.streetNameTextBox.Size = new System.Drawing.Size(177, 22);
            this.streetNameTextBox.TabIndex = 8;
            // 
            // StreetNumberTextBox
            // 
            this.StreetNumberTextBox.Location = new System.Drawing.Point(192, 142);
            this.StreetNumberTextBox.Name = "StreetNumberTextBox";
            this.StreetNumberTextBox.Size = new System.Drawing.Size(177, 22);
            this.StreetNumberTextBox.TabIndex = 9;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(192, 193);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(177, 22);
            this.cityTextBox.TabIndex = 10;
            // 
            // provinceTextBox
            // 
            this.provinceTextBox.Location = new System.Drawing.Point(573, 50);
            this.provinceTextBox.Name = "provinceTextBox";
            this.provinceTextBox.Size = new System.Drawing.Size(177, 22);
            this.provinceTextBox.TabIndex = 11;
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(573, 98);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(177, 22);
            this.zipTextBox.TabIndex = 12;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(573, 144);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(177, 22);
            this.phoneNumberTextBox.TabIndex = 13;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(136, 280);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(134, 59);
            this.updateButton.TabIndex = 14;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(325, 280);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(134, 59);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(507, 280);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(134, 59);
            this.deleteButton.TabIndex = 16;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // Branches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Branches";
            this.Text = "Branches";
            this.tabControl1.ResumeLayout(false);
            this.addEditPage.ResumeLayout(false);
            this.addEditPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage addEditPage;
        private System.Windows.Forms.TabPage queryPage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.TextBox provinceTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox StreetNumberTextBox;
        private System.Windows.Forms.TextBox streetNameTextBox;
        private System.Windows.Forms.TextBox branchIDTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
    }
}