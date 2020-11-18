
namespace cmpt291A3
{
    partial class actionSelectionForm
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
            this.actionSelectionLabel = new System.Windows.Forms.Label();
            this.rentalButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.editCustomerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // actionSelectionLabel
            // 
            this.actionSelectionLabel.AutoSize = true;
            this.actionSelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionSelectionLabel.Location = new System.Drawing.Point(277, 54);
            this.actionSelectionLabel.Name = "actionSelectionLabel";
            this.actionSelectionLabel.Size = new System.Drawing.Size(252, 25);
            this.actionSelectionLabel.TabIndex = 0;
            this.actionSelectionLabel.Text = "Please Select an Option:";
            this.actionSelectionLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // rentalButton
            // 
            this.rentalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalButton.Location = new System.Drawing.Point(270, 141);
            this.rentalButton.Name = "rentalButton";
            this.rentalButton.Size = new System.Drawing.Size(100, 50);
            this.rentalButton.TabIndex = 1;
            this.rentalButton.Text = "Car Rental";
            this.rentalButton.UseVisualStyleBackColor = true;
            // 
            // returnButton
            // 
            this.returnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.Location = new System.Drawing.Point(429, 141);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(100, 50);
            this.returnButton.TabIndex = 2;
            this.returnButton.Text = "Car Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // editCustomerButton
            // 
            this.editCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCustomerButton.Location = new System.Drawing.Point(300, 233);
            this.editCustomerButton.Name = "editCustomerButton";
            this.editCustomerButton.Size = new System.Drawing.Size(200, 50);
            this.editCustomerButton.TabIndex = 3;
            this.editCustomerButton.Text = "Edit Customer Information";
            this.editCustomerButton.UseVisualStyleBackColor = true;
            this.editCustomerButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // actionSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editCustomerButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.rentalButton);
            this.Controls.Add(this.actionSelectionLabel);
            this.Name = "actionSelectionForm";
            this.Text = "Action Selection";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label actionSelectionLabel;
        private System.Windows.Forms.Button rentalButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button editCustomerButton;
    }
}

