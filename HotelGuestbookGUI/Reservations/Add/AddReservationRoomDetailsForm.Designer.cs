namespace HotelGuestbookGUI.Reservations.Add
{
    partial class AddReservationRoomDetailsForm
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
            this.minimalCapacityLabel = new System.Windows.Forms.Label();
            this.minimalCapacityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.doubleBddsLabel = new System.Windows.Forms.Label();
            this.doubleBedsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.roomNumberLabel = new System.Windows.Forms.Label();
            this.actualRoomNumberLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.stepLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.dateOfBirth = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.proceedButton = new System.Windows.Forms.Button();
            this.availableApartmentsComboBox = new System.Windows.Forms.ComboBox();
            this.availableLabel = new System.Windows.Forms.Label();
            this.availableApartmentsLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.minimalCapacityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleBedsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // minimalCapacityLabel
            // 
            this.minimalCapacityLabel.AutoSize = true;
            this.minimalCapacityLabel.Location = new System.Drawing.Point(12, 140);
            this.minimalCapacityLabel.Name = "minimalCapacityLabel";
            this.minimalCapacityLabel.Size = new System.Drawing.Size(88, 13);
            this.minimalCapacityLabel.TabIndex = 0;
            this.minimalCapacityLabel.Text = "Minimal capacity:";
            // 
            // minimalCapacityNumericUpDown
            // 
            this.minimalCapacityNumericUpDown.Location = new System.Drawing.Point(107, 138);
            this.minimalCapacityNumericUpDown.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.minimalCapacityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minimalCapacityNumericUpDown.Name = "minimalCapacityNumericUpDown";
            this.minimalCapacityNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.minimalCapacityNumericUpDown.TabIndex = 1;
            this.minimalCapacityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minimalCapacityNumericUpDown.ValueChanged += new System.EventHandler(this.MinimalCapacityNumericUpDown_ValueChanged);
            // 
            // doubleBddsLabel
            // 
            this.doubleBddsLabel.AutoSize = true;
            this.doubleBddsLabel.Location = new System.Drawing.Point(12, 166);
            this.doubleBddsLabel.Name = "doubleBddsLabel";
            this.doubleBddsLabel.Size = new System.Drawing.Size(70, 13);
            this.doubleBddsLabel.TabIndex = 2;
            this.doubleBddsLabel.Text = "Double beds:";
            // 
            // doubleBedsNumericUpDown
            // 
            this.doubleBedsNumericUpDown.Location = new System.Drawing.Point(107, 164);
            this.doubleBedsNumericUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.doubleBedsNumericUpDown.Name = "doubleBedsNumericUpDown";
            this.doubleBedsNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.doubleBedsNumericUpDown.TabIndex = 3;
            this.doubleBedsNumericUpDown.ValueChanged += new System.EventHandler(this.DoubleBedsNumericUpDown_ValueChanged);
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(12, 196);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(33, 13);
            this.fromLabel.TabIndex = 5;
            this.fromLabel.Text = "From:";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(12, 222);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(23, 13);
            this.toLabel.TabIndex = 6;
            this.toLabel.Text = "To:";
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Location = new System.Drawing.Point(107, 190);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fromDateTimePicker.TabIndex = 7;
            this.fromDateTimePicker.ValueChanged += new System.EventHandler(this.FromDateTimePicker_ValueChanged);
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Location = new System.Drawing.Point(107, 216);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.toDateTimePicker.TabIndex = 8;
            this.toDateTimePicker.ValueChanged += new System.EventHandler(this.ToDateTimePicker_ValueChanged);
            // 
            // roomNumberLabel
            // 
            this.roomNumberLabel.AutoSize = true;
            this.roomNumberLabel.Location = new System.Drawing.Point(12, 313);
            this.roomNumberLabel.Name = "roomNumberLabel";
            this.roomNumberLabel.Size = new System.Drawing.Size(76, 13);
            this.roomNumberLabel.TabIndex = 9;
            this.roomNumberLabel.Text = "Room number:";
            // 
            // actualRoomNumberLabel
            // 
            this.actualRoomNumberLabel.AutoSize = true;
            this.actualRoomNumberLabel.Location = new System.Drawing.Point(104, 313);
            this.actualRoomNumberLabel.Name = "actualRoomNumberLabel";
            this.actualRoomNumberLabel.Size = new System.Drawing.Size(0, 13);
            this.actualRoomNumberLabel.TabIndex = 10;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(15, 464);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "< < Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // stepLabel
            // 
            this.stepLabel.AutoSize = true;
            this.stepLabel.Location = new System.Drawing.Point(144, 469);
            this.stepLabel.Name = "stepLabel";
            this.stepLabel.Size = new System.Drawing.Size(49, 13);
            this.stepLabel.TabIndex = 14;
            this.stepLabel.Text = "Step 2/3";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(12, 9);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(38, 13);
            this.name.TabIndex = 15;
            this.name.Text = "Name:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(104, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(67, 13);
            this.nameLabel.TabIndex = 16;
            this.nameLabel.Text = "FULL NAME";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(12, 34);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(35, 13);
            this.email.TabIndex = 17;
            this.email.Text = "Email:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(104, 34);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.emailLabel.Size = new System.Drawing.Size(39, 13);
            this.emailLabel.TabIndex = 18;
            this.emailLabel.Text = "EMAIL";
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.AutoSize = true;
            this.dateOfBirth.Location = new System.Drawing.Point(12, 58);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(68, 13);
            this.dateOfBirth.TabIndex = 19;
            this.dateOfBirth.Text = "Date of birth:";
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(104, 58);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(89, 13);
            this.dateOfBirthLabel.TabIndex = 20;
            this.dateOfBirthLabel.Text = "DATE OF BIRTH";
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSize = true;
            this.totalPrice.Location = new System.Drawing.Point(12, 348);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(60, 13);
            this.totalPrice.TabIndex = 21;
            this.totalPrice.Text = "Total price:";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(104, 348);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(0, 13);
            this.totalPriceLabel.TabIndex = 22;
            // 
            // proceedButton
            // 
            this.proceedButton.Location = new System.Drawing.Point(238, 464);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(75, 23);
            this.proceedButton.TabIndex = 23;
            this.proceedButton.Text = "Proceed > >";
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.ProceedButton_Click);
            // 
            // availableApartmentsComboBox
            // 
            this.availableApartmentsComboBox.FormattingEnabled = true;
            this.availableApartmentsComboBox.Location = new System.Drawing.Point(15, 277);
            this.availableApartmentsComboBox.Name = "availableApartmentsComboBox";
            this.availableApartmentsComboBox.Size = new System.Drawing.Size(292, 21);
            this.availableApartmentsComboBox.TabIndex = 24;
            this.availableApartmentsComboBox.SelectedIndexChanged += new System.EventHandler(this.AvailableApartmentsComboBox_SelectedIndexChanged);
            // 
            // availableLabel
            // 
            this.availableLabel.AutoSize = true;
            this.availableLabel.Location = new System.Drawing.Point(12, 249);
            this.availableLabel.Name = "availableLabel";
            this.availableLabel.Size = new System.Drawing.Size(108, 13);
            this.availableLabel.TabIndex = 25;
            this.availableLabel.Text = "Available apartments:";
            // 
            // availableApartmentsLabel
            // 
            this.availableApartmentsLabel.AutoSize = true;
            this.availableApartmentsLabel.Location = new System.Drawing.Point(126, 249);
            this.availableApartmentsLabel.Name = "availableApartmentsLabel";
            this.availableApartmentsLabel.Size = new System.Drawing.Size(13, 13);
            this.availableApartmentsLabel.TabIndex = 26;
            this.availableApartmentsLabel.Text = "0";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(12, 377);
            this.infoLabel.MaximumSize = new System.Drawing.Size(330, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(290, 39);
            this.infoLabel.TabIndex = 27;
            this.infoLabel.Text = "Selected reservation dates for this room collide with another reservation.\r\n\r\n";
            // 
            // AddReservationRoomDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 499);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.availableApartmentsLabel);
            this.Controls.Add(this.availableLabel);
            this.Controls.Add(this.availableApartmentsComboBox);
            this.Controls.Add(this.proceedButton);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.dateOfBirth);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.email);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.name);
            this.Controls.Add(this.stepLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.actualRoomNumberLabel);
            this.Controls.Add(this.roomNumberLabel);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.doubleBedsNumericUpDown);
            this.Controls.Add(this.doubleBddsLabel);
            this.Controls.Add(this.minimalCapacityNumericUpDown);
            this.Controls.Add(this.minimalCapacityLabel);
            this.Name = "AddReservationRoomDetailsForm";
            this.Text = "Add reservation - Step 2/3";
            ((System.ComponentModel.ISupportInitialize)(this.minimalCapacityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleBedsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label minimalCapacityLabel;
        private System.Windows.Forms.NumericUpDown minimalCapacityNumericUpDown;
        private System.Windows.Forms.Label doubleBddsLabel;
        private System.Windows.Forms.NumericUpDown doubleBedsNumericUpDown;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.Label roomNumberLabel;
        private System.Windows.Forms.Label actualRoomNumberLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label stepLabel;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label dateOfBirth;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Button proceedButton;
        private System.Windows.Forms.ComboBox availableApartmentsComboBox;
        private System.Windows.Forms.Label availableLabel;
        private System.Windows.Forms.Label availableApartmentsLabel;
        private System.Windows.Forms.Label infoLabel;
    }
}