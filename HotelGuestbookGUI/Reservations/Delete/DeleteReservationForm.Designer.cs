namespace HotelGuestbookGUI.Reservations.Delete
{
    partial class DeleteReservationForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.personalDetailsLabel = new System.Windows.Forms.Label();
            this.reservationDetailsLabel = new System.Windows.Forms.Label();
            this.roomLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.deleteCheckBox = new System.Windows.Forms.CheckBox();
            this.nameTextLabel = new System.Windows.Forms.Label();
            this.emailTextLabel = new System.Windows.Forms.Label();
            this.roomNumberLabel = new System.Windows.Forms.Label();
            this.fromTextLabel = new System.Windows.Forms.Label();
            this.toTextLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(12, 415);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(220, 415);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(29, 52);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(29, 82);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Email:";
            // 
            // personalDetailsLabel
            // 
            this.personalDetailsLabel.AutoSize = true;
            this.personalDetailsLabel.Location = new System.Drawing.Point(13, 23);
            this.personalDetailsLabel.Name = "personalDetailsLabel";
            this.personalDetailsLabel.Size = new System.Drawing.Size(84, 13);
            this.personalDetailsLabel.TabIndex = 4;
            this.personalDetailsLabel.Text = "Personal details:";
            // 
            // reservationDetailsLabel
            // 
            this.reservationDetailsLabel.AutoSize = true;
            this.reservationDetailsLabel.Location = new System.Drawing.Point(13, 126);
            this.reservationDetailsLabel.Name = "reservationDetailsLabel";
            this.reservationDetailsLabel.Size = new System.Drawing.Size(100, 13);
            this.reservationDetailsLabel.TabIndex = 5;
            this.reservationDetailsLabel.Text = "Reservation details:";
            // 
            // roomLabel
            // 
            this.roomLabel.AutoSize = true;
            this.roomLabel.Location = new System.Drawing.Point(32, 160);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(76, 13);
            this.roomLabel.TabIndex = 6;
            this.roomLabel.Text = "Room number:";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(32, 192);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(33, 13);
            this.fromLabel.TabIndex = 7;
            this.fromLabel.Text = "From:";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(32, 224);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(23, 13);
            this.toLabel.TabIndex = 8;
            this.toLabel.Text = "To:";
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Location = new System.Drawing.Point(13, 309);
            this.warningLabel.MaximumSize = new System.Drawing.Size(3000, 0);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(282, 39);
            this.warningLabel.TabIndex = 9;
            this.warningLabel.Text = "WARNING:\r\nDeleting a reservation destroys the record in the database.\r\nThis actio" +
    "n cannot be undone.";
            // 
            // deleteCheckBox
            // 
            this.deleteCheckBox.AutoSize = true;
            this.deleteCheckBox.Location = new System.Drawing.Point(16, 366);
            this.deleteCheckBox.Name = "deleteCheckBox";
            this.deleteCheckBox.Size = new System.Drawing.Size(287, 17);
            this.deleteCheckBox.TabIndex = 10;
            this.deleteCheckBox.Text = "I understand the consequences, delete the reservation.";
            this.deleteCheckBox.UseVisualStyleBackColor = true;
            this.deleteCheckBox.CheckedChanged += new System.EventHandler(this.DeleteCheckBox_CheckedChanged);
            // 
            // nameTextLabel
            // 
            this.nameTextLabel.AutoSize = true;
            this.nameTextLabel.Location = new System.Drawing.Point(129, 52);
            this.nameTextLabel.Name = "nameTextLabel";
            this.nameTextLabel.Size = new System.Drawing.Size(118, 13);
            this.nameTextLabel.TabIndex = 11;
            this.nameTextLabel.Text = this.Name;
            // 
            // emailTextLabel
            // 
            this.emailTextLabel.AutoSize = true;
            this.emailTextLabel.Location = new System.Drawing.Point(129, 82);
            this.emailTextLabel.Name = "emailTextLabel";
            this.emailTextLabel.Size = new System.Drawing.Size(32, 13);
            this.emailTextLabel.TabIndex = 12;
            this.emailTextLabel.Text = "Email";
            // 
            // roomNumberLabel
            // 
            this.roomNumberLabel.AutoSize = true;
            this.roomNumberLabel.Location = new System.Drawing.Point(129, 160);
            this.roomNumberLabel.Name = "roomNumberLabel";
            this.roomNumberLabel.Size = new System.Drawing.Size(35, 13);
            this.roomNumberLabel.TabIndex = 13;
            this.roomNumberLabel.Text = "Room";
            // 
            // fromTextLabel
            // 
            this.fromTextLabel.AutoSize = true;
            this.fromTextLabel.Location = new System.Drawing.Point(129, 192);
            this.fromTextLabel.Name = "fromTextLabel";
            this.fromTextLabel.Size = new System.Drawing.Size(30, 13);
            this.fromTextLabel.TabIndex = 14;
            this.fromTextLabel.Text = "From";
            // 
            // toTextLabel
            // 
            this.toTextLabel.AutoSize = true;
            this.toTextLabel.Location = new System.Drawing.Point(129, 224);
            this.toTextLabel.Name = "toTextLabel";
            this.toTextLabel.Size = new System.Drawing.Size(20, 13);
            this.toTextLabel.TabIndex = 15;
            this.toTextLabel.Text = "To";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // DeleteReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toTextLabel);
            this.Controls.Add(this.fromTextLabel);
            this.Controls.Add(this.roomNumberLabel);
            this.Controls.Add(this.emailTextLabel);
            this.Controls.Add(this.nameTextLabel);
            this.Controls.Add(this.deleteCheckBox);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.roomLabel);
            this.Controls.Add(this.reservationDetailsLabel);
            this.Controls.Add(this.personalDetailsLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cancelButton);
            this.Name = "DeleteReservationForm";
            this.Text = "Delete reservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label personalDetailsLabel;
        private System.Windows.Forms.Label reservationDetailsLabel;
        private System.Windows.Forms.Label roomLabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.CheckBox deleteCheckBox;
        private System.Windows.Forms.Label nameTextLabel;
        private System.Windows.Forms.Label emailTextLabel;
        private System.Windows.Forms.Label roomNumberLabel;
        private System.Windows.Forms.Label fromTextLabel;
        private System.Windows.Forms.Label toTextLabel;
        private System.Windows.Forms.Label label1;
    }
}