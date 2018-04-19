namespace HotelGuestbookGUI.Administration.Apartment
{
    partial class AddApartmentForm
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
            this.roomNumberLabel = new System.Windows.Forms.Label();
            this.capacityLabel = new System.Windows.Forms.Label();
            this.doubleBedsLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.roomNumberTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.capacityComboBox = new System.Windows.Forms.ComboBox();
            this.doubleBedsComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // roomNumberLabel
            // 
            this.roomNumberLabel.AutoSize = true;
            this.roomNumberLabel.Location = new System.Drawing.Point(12, 9);
            this.roomNumberLabel.Name = "roomNumberLabel";
            this.roomNumberLabel.Size = new System.Drawing.Size(76, 13);
            this.roomNumberLabel.TabIndex = 0;
            this.roomNumberLabel.Text = "Room number:";
            // 
            // capacityLabel
            // 
            this.capacityLabel.AutoSize = true;
            this.capacityLabel.Location = new System.Drawing.Point(12, 96);
            this.capacityLabel.Name = "capacityLabel";
            this.capacityLabel.Size = new System.Drawing.Size(51, 13);
            this.capacityLabel.TabIndex = 1;
            this.capacityLabel.Text = "Capacity:";
            // 
            // doubleBedsLabel
            // 
            this.doubleBedsLabel.AutoSize = true;
            this.doubleBedsLabel.Location = new System.Drawing.Point(12, 137);
            this.doubleBedsLabel.Name = "doubleBedsLabel";
            this.doubleBedsLabel.Size = new System.Drawing.Size(70, 13);
            this.doubleBedsLabel.TabIndex = 2;
            this.doubleBedsLabel.Text = "Double beds:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(12, 52);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(66, 13);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Price (EUR):";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(15, 176);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(168, 176);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // roomNumberTextBox
            // 
            this.roomNumberTextBox.Location = new System.Drawing.Point(94, 6);
            this.roomNumberTextBox.Name = "roomNumberTextBox";
            this.roomNumberTextBox.Size = new System.Drawing.Size(149, 20);
            this.roomNumberTextBox.TabIndex = 6;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(94, 49);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(149, 20);
            this.priceTextBox.TabIndex = 7;
            // 
            // capacityComboBox
            // 
            this.capacityComboBox.FormattingEnabled = true;
            this.capacityComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.capacityComboBox.Location = new System.Drawing.Point(94, 93);
            this.capacityComboBox.Name = "capacityComboBox";
            this.capacityComboBox.Size = new System.Drawing.Size(149, 21);
            this.capacityComboBox.TabIndex = 8;
            // 
            // doubleBedsComboBox
            // 
            this.doubleBedsComboBox.FormattingEnabled = true;
            this.doubleBedsComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.doubleBedsComboBox.Location = new System.Drawing.Point(94, 134);
            this.doubleBedsComboBox.Name = "doubleBedsComboBox";
            this.doubleBedsComboBox.Size = new System.Drawing.Size(149, 21);
            this.doubleBedsComboBox.TabIndex = 9;
            // 
            // AddApartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 212);
            this.Controls.Add(this.doubleBedsComboBox);
            this.Controls.Add(this.capacityComboBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.roomNumberTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.doubleBedsLabel);
            this.Controls.Add(this.capacityLabel);
            this.Controls.Add(this.roomNumberLabel);
            this.Name = "AddApartmentForm";
            this.Text = "Add apartment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label roomNumberLabel;
        private System.Windows.Forms.Label capacityLabel;
        private System.Windows.Forms.Label doubleBedsLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox roomNumberTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.ComboBox capacityComboBox;
        private System.Windows.Forms.ComboBox doubleBedsComboBox;
    }
}