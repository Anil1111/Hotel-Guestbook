namespace HotelGuestbookGUI.Administration.Apartment
{
    partial class EditApartmentForm
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
            this.selectApartmentLabel = new System.Windows.Forms.Label();
            this.selectApartmentComboBox = new System.Windows.Forms.ComboBox();
            this.roomNumberLabel = new System.Windows.Forms.Label();
            this.roomNumberTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.capacityLabel = new System.Windows.Forms.Label();
            this.doubleBedsLabel = new System.Windows.Forms.Label();
            this.capacityComboBox = new System.Windows.Forms.ComboBox();
            this.doubleBedsComboBox = new System.Windows.Forms.ComboBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectApartmentLabel
            // 
            this.selectApartmentLabel.AutoSize = true;
            this.selectApartmentLabel.Location = new System.Drawing.Point(13, 13);
            this.selectApartmentLabel.Name = "selectApartmentLabel";
            this.selectApartmentLabel.Size = new System.Drawing.Size(90, 13);
            this.selectApartmentLabel.TabIndex = 0;
            this.selectApartmentLabel.Text = "Select apartment:";
            // 
            // selectApartmentComboBox
            // 
            this.selectApartmentComboBox.FormattingEnabled = true;
            this.selectApartmentComboBox.Location = new System.Drawing.Point(109, 10);
            this.selectApartmentComboBox.Name = "selectApartmentComboBox";
            this.selectApartmentComboBox.Size = new System.Drawing.Size(351, 21);
            this.selectApartmentComboBox.TabIndex = 1;
            this.selectApartmentComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectApartmentComboBox_SelectedIndexChanged);
            // 
            // roomNumberLabel
            // 
            this.roomNumberLabel.AutoSize = true;
            this.roomNumberLabel.Location = new System.Drawing.Point(13, 52);
            this.roomNumberLabel.Name = "roomNumberLabel";
            this.roomNumberLabel.Size = new System.Drawing.Size(76, 13);
            this.roomNumberLabel.TabIndex = 2;
            this.roomNumberLabel.Text = "Room number:";
            // 
            // roomNumberTextBox
            // 
            this.roomNumberTextBox.Enabled = false;
            this.roomNumberTextBox.Location = new System.Drawing.Point(109, 49);
            this.roomNumberTextBox.Name = "roomNumberTextBox";
            this.roomNumberTextBox.Size = new System.Drawing.Size(172, 20);
            this.roomNumberTextBox.TabIndex = 3;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Enabled = false;
            this.priceTextBox.Location = new System.Drawing.Point(109, 93);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(172, 20);
            this.priceTextBox.TabIndex = 4;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(13, 96);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(34, 13);
            this.priceLabel.TabIndex = 5;
            this.priceLabel.Text = "Price:";
            // 
            // capacityLabel
            // 
            this.capacityLabel.AutoSize = true;
            this.capacityLabel.Location = new System.Drawing.Point(13, 141);
            this.capacityLabel.Name = "capacityLabel";
            this.capacityLabel.Size = new System.Drawing.Size(51, 13);
            this.capacityLabel.TabIndex = 6;
            this.capacityLabel.Text = "Capacity:";
            // 
            // doubleBedsLabel
            // 
            this.doubleBedsLabel.AutoSize = true;
            this.doubleBedsLabel.Location = new System.Drawing.Point(13, 188);
            this.doubleBedsLabel.Name = "doubleBedsLabel";
            this.doubleBedsLabel.Size = new System.Drawing.Size(70, 13);
            this.doubleBedsLabel.TabIndex = 7;
            this.doubleBedsLabel.Text = "Double beds:";
            // 
            // capacityComboBox
            // 
            this.capacityComboBox.Enabled = false;
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
            this.capacityComboBox.Location = new System.Drawing.Point(109, 138);
            this.capacityComboBox.Name = "capacityComboBox";
            this.capacityComboBox.Size = new System.Drawing.Size(172, 21);
            this.capacityComboBox.TabIndex = 8;
            // 
            // doubleBedsComboBox
            // 
            this.doubleBedsComboBox.Enabled = false;
            this.doubleBedsComboBox.FormattingEnabled = true;
            this.doubleBedsComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.doubleBedsComboBox.Location = new System.Drawing.Point(109, 185);
            this.doubleBedsComboBox.Name = "doubleBedsComboBox";
            this.doubleBedsComboBox.Size = new System.Drawing.Size(172, 21);
            this.doubleBedsComboBox.TabIndex = 9;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(16, 233);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(385, 233);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // EditApartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 268);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.doubleBedsComboBox);
            this.Controls.Add(this.capacityComboBox);
            this.Controls.Add(this.doubleBedsLabel);
            this.Controls.Add(this.capacityLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.roomNumberTextBox);
            this.Controls.Add(this.roomNumberLabel);
            this.Controls.Add(this.selectApartmentComboBox);
            this.Controls.Add(this.selectApartmentLabel);
            this.Name = "EditApartmentForm";
            this.Text = "Edit apartment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectApartmentLabel;
        private System.Windows.Forms.ComboBox selectApartmentComboBox;
        private System.Windows.Forms.Label roomNumberLabel;
        private System.Windows.Forms.TextBox roomNumberTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label capacityLabel;
        private System.Windows.Forms.Label doubleBedsLabel;
        private System.Windows.Forms.ComboBox capacityComboBox;
        private System.Windows.Forms.ComboBox doubleBedsComboBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
    }
}