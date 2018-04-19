namespace HotelGuestbookGUI.Administration.Apartment
{
    partial class DeleteApartmentForm
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
            this.selectAabel = new System.Windows.Forms.Label();
            this.selectedApartmentComboBox = new System.Windows.Forms.ComboBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectAabel
            // 
            this.selectAabel.AutoSize = true;
            this.selectAabel.Location = new System.Drawing.Point(12, 9);
            this.selectAabel.Name = "selectAabel";
            this.selectAabel.Size = new System.Drawing.Size(90, 13);
            this.selectAabel.TabIndex = 0;
            this.selectAabel.Text = "Select apartment:";
            // 
            // selectedApartmentComboBox
            // 
            this.selectedApartmentComboBox.FormattingEnabled = true;
            this.selectedApartmentComboBox.Location = new System.Drawing.Point(108, 6);
            this.selectedApartmentComboBox.Name = "selectedApartmentComboBox";
            this.selectedApartmentComboBox.Size = new System.Drawing.Size(442, 21);
            this.selectedApartmentComboBox.TabIndex = 1;
            this.selectedApartmentComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectedApartmentComboBox_SelectedIndexChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(15, 46);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(475, 46);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DeleteApartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 80);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.selectedApartmentComboBox);
            this.Controls.Add(this.selectAabel);
            this.Name = "DeleteApartmentForm";
            this.Text = "Delete apartment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectAabel;
        private System.Windows.Forms.ComboBox selectedApartmentComboBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;
    }
}