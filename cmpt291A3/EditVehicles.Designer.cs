
namespace cmpt291A3
{
    partial class EditVehicles
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
            this.carBranchTextBox = new System.Windows.Forms.TextBox();
            this.carColorTextBox = new System.Windows.Forms.TextBox();
            this.carModelTextBox = new System.Windows.Forms.TextBox();
            this.carTypeTextBox = new System.Windows.Forms.TextBox();
            this.carTypeLabel = new System.Windows.Forms.Label();
            this.carModelLabel = new System.Windows.Forms.Label();
            this.carBranchLabel = new System.Windows.Forms.Label();
            this.carColorLabel = new System.Windows.Forms.Label();
            this.carUpdateButton = new System.Windows.Forms.Button();
            this.carAddButton = new System.Windows.Forms.Button();
            this.carDeleteButton = new System.Windows.Forms.Button();
            this.carBackButton = new System.Windows.Forms.Button();
            this.carConfirmationLabel = new System.Windows.Forms.Label();
            this.carVINLabel = new System.Windows.Forms.Label();
            this.carVINTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // carBranchTextBox
            // 
            this.carBranchTextBox.Location = new System.Drawing.Point(139, 199);
            this.carBranchTextBox.Name = "carBranchTextBox";
            this.carBranchTextBox.Size = new System.Drawing.Size(150, 20);
            this.carBranchTextBox.TabIndex = 7;
            // 
            // carColorTextBox
            // 
            this.carColorTextBox.Location = new System.Drawing.Point(443, 49);
            this.carColorTextBox.Name = "carColorTextBox";
            this.carColorTextBox.Size = new System.Drawing.Size(150, 20);
            this.carColorTextBox.TabIndex = 8;
            // 
            // carModelTextBox
            // 
            this.carModelTextBox.Location = new System.Drawing.Point(139, 124);
            this.carModelTextBox.Name = "carModelTextBox";
            this.carModelTextBox.Size = new System.Drawing.Size(150, 20);
            this.carModelTextBox.TabIndex = 9;
            // 
            // carTypeTextBox
            // 
            this.carTypeTextBox.Location = new System.Drawing.Point(443, 124);
            this.carTypeTextBox.Name = "carTypeTextBox";
            this.carTypeTextBox.Size = new System.Drawing.Size(150, 20);
            this.carTypeTextBox.TabIndex = 10;
            // 
            // carTypeLabel
            // 
            this.carTypeLabel.AutoSize = true;
            this.carTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carTypeLabel.Location = new System.Drawing.Point(361, 125);
            this.carTypeLabel.Name = "carTypeLabel";
            this.carTypeLabel.Size = new System.Drawing.Size(76, 16);
            this.carTypeLabel.TabIndex = 11;
            this.carTypeLabel.Text = "Car Type:";
            // 
            // carModelLabel
            // 
            this.carModelLabel.AutoSize = true;
            this.carModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carModelLabel.Location = new System.Drawing.Point(50, 125);
            this.carModelLabel.Name = "carModelLabel";
            this.carModelLabel.Size = new System.Drawing.Size(83, 16);
            this.carModelLabel.TabIndex = 12;
            this.carModelLabel.Text = "Car Model:";
            // 
            // carBranchLabel
            // 
            this.carBranchLabel.AutoSize = true;
            this.carBranchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carBranchLabel.Location = new System.Drawing.Point(50, 200);
            this.carBranchLabel.Name = "carBranchLabel";
            this.carBranchLabel.Size = new System.Drawing.Size(60, 16);
            this.carBranchLabel.TabIndex = 13;
            this.carBranchLabel.Text = "Branch:";
            // 
            // carColorLabel
            // 
            this.carColorLabel.AutoSize = true;
            this.carColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carColorLabel.Location = new System.Drawing.Point(361, 50);
            this.carColorLabel.Name = "carColorLabel";
            this.carColorLabel.Size = new System.Drawing.Size(49, 16);
            this.carColorLabel.TabIndex = 14;
            this.carColorLabel.Text = "Color:";
            // 
            // carUpdateButton
            // 
            this.carUpdateButton.Location = new System.Drawing.Point(229, 276);
            this.carUpdateButton.Name = "carUpdateButton";
            this.carUpdateButton.Size = new System.Drawing.Size(75, 50);
            this.carUpdateButton.TabIndex = 15;
            this.carUpdateButton.Text = "Update";
            this.carUpdateButton.UseVisualStyleBackColor = true;
            this.carUpdateButton.Click += new System.EventHandler(this.carUpdateButton_Click);
            // 
            // carAddButton
            // 
            this.carAddButton.Location = new System.Drawing.Point(364, 276);
            this.carAddButton.Name = "carAddButton";
            this.carAddButton.Size = new System.Drawing.Size(75, 50);
            this.carAddButton.TabIndex = 16;
            this.carAddButton.Text = "Add";
            this.carAddButton.UseVisualStyleBackColor = true;
            this.carAddButton.Click += new System.EventHandler(this.carAddButton_Click);
            // 
            // carDeleteButton
            // 
            this.carDeleteButton.Location = new System.Drawing.Point(502, 276);
            this.carDeleteButton.Name = "carDeleteButton";
            this.carDeleteButton.Size = new System.Drawing.Size(75, 50);
            this.carDeleteButton.TabIndex = 17;
            this.carDeleteButton.Text = "Delete";
            this.carDeleteButton.UseVisualStyleBackColor = true;
            this.carDeleteButton.Click += new System.EventHandler(this.carDeleteButton_Click);
            // 
            // carBackButton
            // 
            this.carBackButton.Location = new System.Drawing.Point(12, 413);
            this.carBackButton.Name = "carBackButton";
            this.carBackButton.Size = new System.Drawing.Size(75, 25);
            this.carBackButton.TabIndex = 18;
            this.carBackButton.Text = "Back";
            this.carBackButton.UseVisualStyleBackColor = true;
            this.carBackButton.Click += new System.EventHandler(this.carBackButton_Click);
            // 
            // carConfirmationLabel
            // 
            this.carConfirmationLabel.AutoSize = true;
            this.carConfirmationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carConfirmationLabel.Location = new System.Drawing.Point(298, 357);
            this.carConfirmationLabel.Name = "carConfirmationLabel";
            this.carConfirmationLabel.Size = new System.Drawing.Size(208, 20);
            this.carConfirmationLabel.TabIndex = 19;
            this.carConfirmationLabel.Text = "<Confirmation Message>";
            this.carConfirmationLabel.Visible = false;
            // 
            // carVINLabel
            // 
            this.carVINLabel.AutoSize = true;
            this.carVINLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carVINLabel.Location = new System.Drawing.Point(50, 50);
            this.carVINLabel.Name = "carVINLabel";
            this.carVINLabel.Size = new System.Drawing.Size(37, 16);
            this.carVINLabel.TabIndex = 20;
            this.carVINLabel.Text = "VIN:";
            // 
            // carVINTextBox
            // 
            this.carVINTextBox.Location = new System.Drawing.Point(139, 49);
            this.carVINTextBox.Name = "carVINTextBox";
            this.carVINTextBox.Size = new System.Drawing.Size(150, 20);
            this.carVINTextBox.TabIndex = 21;
            // 
            // EditVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.carVINTextBox);
            this.Controls.Add(this.carVINLabel);
            this.Controls.Add(this.carConfirmationLabel);
            this.Controls.Add(this.carBackButton);
            this.Controls.Add(this.carDeleteButton);
            this.Controls.Add(this.carAddButton);
            this.Controls.Add(this.carUpdateButton);
            this.Controls.Add(this.carColorLabel);
            this.Controls.Add(this.carBranchLabel);
            this.Controls.Add(this.carModelLabel);
            this.Controls.Add(this.carTypeLabel);
            this.Controls.Add(this.carTypeTextBox);
            this.Controls.Add(this.carModelTextBox);
            this.Controls.Add(this.carColorTextBox);
            this.Controls.Add(this.carBranchTextBox);
            this.Name = "EditVehicles";
            this.Text = "Car Lookup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox carBranchTextBox;
        private System.Windows.Forms.TextBox carColorTextBox;
        private System.Windows.Forms.TextBox carModelTextBox;
        private System.Windows.Forms.TextBox carTypeTextBox;
        private System.Windows.Forms.Label carTypeLabel;
        private System.Windows.Forms.Label carModelLabel;
        private System.Windows.Forms.Label carBranchLabel;
        private System.Windows.Forms.Label carColorLabel;
        private System.Windows.Forms.Button carUpdateButton;
        private System.Windows.Forms.Button carAddButton;
        private System.Windows.Forms.Button carDeleteButton;
        private System.Windows.Forms.Button carBackButton;
        private System.Windows.Forms.Label carConfirmationLabel;
        private System.Windows.Forms.Label carVINLabel;
        private System.Windows.Forms.TextBox carVINTextBox;
    }
}