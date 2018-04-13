namespace HotelGuestbookGUI.GDPR
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.CloseButton = new System.Windows.Forms.Button();
            this.generalInfoLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.rightToAccessLabel = new System.Windows.Forms.Label();
            this.rightToBeForgottenlabel = new System.Windows.Forms.Label();
            this.collectingLabel = new System.Windows.Forms.Label();
            this.deleteingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(502, 275);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // generalInfoLabel
            // 
            this.generalInfoLabel.AutoSize = true;
            this.generalInfoLabel.Location = new System.Drawing.Point(13, 13);
            this.generalInfoLabel.Name = "generalInfoLabel";
            this.generalInfoLabel.Size = new System.Drawing.Size(0, 13);
            this.generalInfoLabel.TabIndex = 1;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(12, 9);
            this.infoLabel.MaximumSize = new System.Drawing.Size(570, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(565, 65);
            this.infoLabel.TabIndex = 2;
            this.infoLabel.Text = resources.GetString("infoLabel.Text");
            // 
            // rightToAccessLabel
            // 
            this.rightToAccessLabel.AutoSize = true;
            this.rightToAccessLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rightToAccessLabel.Location = new System.Drawing.Point(13, 92);
            this.rightToAccessLabel.Name = "rightToAccessLabel";
            this.rightToAccessLabel.Size = new System.Drawing.Size(120, 13);
            this.rightToAccessLabel.TabIndex = 3;
            this.rightToAccessLabel.Text = "Collecting personal data";
            // 
            // rightToBeForgottenlabel
            // 
            this.rightToBeForgottenlabel.AutoSize = true;
            this.rightToBeForgottenlabel.Location = new System.Drawing.Point(12, 176);
            this.rightToBeForgottenlabel.Name = "rightToBeForgottenlabel";
            this.rightToBeForgottenlabel.Size = new System.Drawing.Size(109, 13);
            this.rightToBeForgottenlabel.TabIndex = 4;
            this.rightToBeForgottenlabel.Text = "Erasing personal data";
            // 
            // collectingLabel
            // 
            this.collectingLabel.AutoSize = true;
            this.collectingLabel.Location = new System.Drawing.Point(13, 115);
            this.collectingLabel.MaximumSize = new System.Drawing.Size(570, 0);
            this.collectingLabel.Name = "collectingLabel";
            this.collectingLabel.Size = new System.Drawing.Size(548, 26);
            this.collectingLabel.TabIndex = 5;
            this.collectingLabel.Text = resources.GetString("collectingLabel.Text");
            // 
            // deleteingLabel
            // 
            this.deleteingLabel.AutoSize = true;
            this.deleteingLabel.Location = new System.Drawing.Point(13, 198);
            this.deleteingLabel.MaximumSize = new System.Drawing.Size(570, 0);
            this.deleteingLabel.Name = "deleteingLabel";
            this.deleteingLabel.Size = new System.Drawing.Size(564, 39);
            this.deleteingLabel.TabIndex = 6;
            this.deleteingLabel.Text = resources.GetString("deleteingLabel.Text");
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 310);
            this.Controls.Add(this.deleteingLabel);
            this.Controls.Add(this.collectingLabel);
            this.Controls.Add(this.rightToBeForgottenlabel);
            this.Controls.Add(this.rightToAccessLabel);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.generalInfoLabel);
            this.Controls.Add(this.CloseButton);
            this.Name = "HelpForm";
            this.Text = "GDPR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label generalInfoLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label rightToAccessLabel;
        private System.Windows.Forms.Label rightToBeForgottenlabel;
        private System.Windows.Forms.Label collectingLabel;
        private System.Windows.Forms.Label deleteingLabel;
    }
}