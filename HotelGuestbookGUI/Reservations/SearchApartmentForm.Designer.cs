namespace HotelGuestbookGUI.Reservations
{
    partial class SearchApartmentForm
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
            this.apartmentsListBox = new System.Windows.Forms.ListBox();
            this.backButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // apartmentsListBox
            // 
            this.apartmentsListBox.FormattingEnabled = true;
            this.apartmentsListBox.Location = new System.Drawing.Point(13, 13);
            this.apartmentsListBox.Name = "apartmentsListBox";
            this.apartmentsListBox.Size = new System.Drawing.Size(775, 394);
            this.apartmentsListBox.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(13, 413);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(713, 413);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 2;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            // 
            // SearchApartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 444);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.apartmentsListBox);
            this.Name = "SearchApartmentForm";
            this.Text = "Apartment search";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox apartmentsListBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button selectButton;
    }
}