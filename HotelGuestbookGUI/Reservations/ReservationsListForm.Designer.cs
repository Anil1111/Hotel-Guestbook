namespace HotelGuestbookGUI.Reservations
{
    partial class ReservationsListForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gDPRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightToAccessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightToBeForgottenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationsLabel = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reservationsListView = new System.Windows.Forms.ListView();
            this.pastReservationsLabel = new System.Windows.Forms.Label();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.searchCheckBox = new System.Windows.Forms.CheckBox();
            this.pastReservationsCheckBox = new System.Windows.Forms.CheckBox();
            this.fromCheckBox = new System.Windows.Forms.CheckBox();
            this.toCheckBox = new System.Windows.Forms.CheckBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.endEditOrDeleteModeButton = new System.Windows.Forms.Button();
            this.modeLabel = new System.Windows.Forms.Label();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.generateSampleDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.reservationToolStripMenuItem,
            this.gDPRToolStripMenuItem,
            this.administrationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.toolStripMenuItem3,
            this.generateSampleDataToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.ExportToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(185, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // reservationToolStripMenuItem
            // 
            this.reservationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.editToolStripMenuItem1,
            this.deleteToolStripMenuItem1});
            this.reservationToolStripMenuItem.Name = "reservationToolStripMenuItem";
            this.reservationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.reservationToolStripMenuItem.Text = "Reservation";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.AddToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem1.Text = "Edit";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.EditToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.DeleteToolStripMenuItem1_Click);
            // 
            // gDPRToolStripMenuItem
            // 
            this.gDPRToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rightToAccessToolStripMenuItem,
            this.rightToBeForgottenToolStripMenuItem,
            this.toolStripMenuItem2,
            this.helpToolStripMenuItem});
            this.gDPRToolStripMenuItem.Name = "gDPRToolStripMenuItem";
            this.gDPRToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.gDPRToolStripMenuItem.Text = "GDPR";
            // 
            // rightToAccessToolStripMenuItem
            // 
            this.rightToAccessToolStripMenuItem.Name = "rightToAccessToolStripMenuItem";
            this.rightToAccessToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.rightToAccessToolStripMenuItem.Text = "Right to access";
            this.rightToAccessToolStripMenuItem.Click += new System.EventHandler(this.RightToAccessToolStripMenuItem_Click);
            // 
            // rightToBeForgottenToolStripMenuItem
            // 
            this.rightToBeForgottenToolStripMenuItem.Name = "rightToBeForgottenToolStripMenuItem";
            this.rightToBeForgottenToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.rightToBeForgottenToolStripMenuItem.Text = "Right to be forgotten";
            this.rightToBeForgottenToolStripMenuItem.Click += new System.EventHandler(this.RightToBeForgottenToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(182, 6);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // administrationToolStripMenuItem
            // 
            this.administrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apartmentToolStripMenuItem});
            this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            this.administrationToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.administrationToolStripMenuItem.Text = "Administration";
            // 
            // apartmentToolStripMenuItem
            // 
            this.apartmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.apartmentToolStripMenuItem.Name = "apartmentToolStripMenuItem";
            this.apartmentToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.apartmentToolStripMenuItem.Text = "Apartment";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // reservationsLabel
            // 
            this.reservationsLabel.AutoSize = true;
            this.reservationsLabel.Location = new System.Drawing.Point(12, 530);
            this.reservationsLabel.Name = "reservationsLabel";
            this.reservationsLabel.Size = new System.Drawing.Size(119, 13);
            this.reservationsLabel.TabIndex = 1;
            this.reservationsLabel.Text = "Number of reservations:";
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(137, 530);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(13, 13);
            this.countLabel.TabIndex = 2;
            this.countLabel.Text = "0";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(713, 520);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(205, 28);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(370, 20);
            this.searchTextBox.TabIndex = 6;
            this.searchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Location = new System.Drawing.Point(78, 57);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fromDateTimePicker.TabIndex = 7;
            this.fromDateTimePicker.ValueChanged += new System.EventHandler(this.FromDateTimePicker_ValueChanged);
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Location = new System.Drawing.Point(78, 87);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.toDateTimePicker.TabIndex = 8;
            this.toDateTimePicker.ValueChanged += new System.EventHandler(this.ToDateTimePicker_ValueChanged);
            // 
            // reservationsListView
            // 
            this.reservationsListView.Location = new System.Drawing.Point(15, 150);
            this.reservationsListView.Name = "reservationsListView";
            this.reservationsListView.Size = new System.Drawing.Size(775, 364);
            this.reservationsListView.TabIndex = 11;
            this.reservationsListView.UseCompatibleStateImageBehavior = false;
            this.reservationsListView.SelectedIndexChanged += new System.EventHandler(this.ReservationsListView_SelectedIndexChanged);
            // 
            // pastReservationsLabel
            // 
            this.pastReservationsLabel.AutoSize = true;
            this.pastReservationsLabel.Location = new System.Drawing.Point(12, 130);
            this.pastReservationsLabel.Name = "pastReservationsLabel";
            this.pastReservationsLabel.Size = new System.Drawing.Size(158, 13);
            this.pastReservationsLabel.TabIndex = 12;
            this.pastReservationsLabel.Text = "Show reservations from the past";
            // 
            // searchComboBox
            // 
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Items.AddRange(new object[] {
            "First name",
            "Last name",
            "Email",
            "Room number"});
            this.searchComboBox.Location = new System.Drawing.Point(78, 28);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(121, 21);
            this.searchComboBox.TabIndex = 14;
            this.searchComboBox.SelectedValueChanged += new System.EventHandler(this.SearchComboBox_SelectedValueChanged);
            // 
            // searchCheckBox
            // 
            this.searchCheckBox.AutoSize = true;
            this.searchCheckBox.Location = new System.Drawing.Point(12, 30);
            this.searchCheckBox.Name = "searchCheckBox";
            this.searchCheckBox.Size = new System.Drawing.Size(60, 17);
            this.searchCheckBox.TabIndex = 15;
            this.searchCheckBox.Text = "Search";
            this.searchCheckBox.UseVisualStyleBackColor = true;
            this.searchCheckBox.CheckedChanged += new System.EventHandler(this.SearchCheckBox_CheckedChanged);
            // 
            // pastReservationsCheckBox
            // 
            this.pastReservationsCheckBox.AutoSize = true;
            this.pastReservationsCheckBox.Location = new System.Drawing.Point(176, 130);
            this.pastReservationsCheckBox.Name = "pastReservationsCheckBox";
            this.pastReservationsCheckBox.Size = new System.Drawing.Size(15, 14);
            this.pastReservationsCheckBox.TabIndex = 13;
            this.pastReservationsCheckBox.UseVisualStyleBackColor = true;
            this.pastReservationsCheckBox.CheckedChanged += new System.EventHandler(this.PastReservationsCheckBox_CheckedChanged);
            // 
            // fromCheckBox
            // 
            this.fromCheckBox.AutoSize = true;
            this.fromCheckBox.Enabled = false;
            this.fromCheckBox.Location = new System.Drawing.Point(12, 62);
            this.fromCheckBox.Name = "fromCheckBox";
            this.fromCheckBox.Size = new System.Drawing.Size(52, 17);
            this.fromCheckBox.TabIndex = 18;
            this.fromCheckBox.Text = "From:";
            this.fromCheckBox.UseVisualStyleBackColor = true;
            this.fromCheckBox.CheckedChanged += new System.EventHandler(this.FromCheckBox_CheckedChanged);
            // 
            // toCheckBox
            // 
            this.toCheckBox.AutoSize = true;
            this.toCheckBox.Enabled = false;
            this.toCheckBox.Location = new System.Drawing.Point(12, 92);
            this.toCheckBox.Name = "toCheckBox";
            this.toCheckBox.Size = new System.Drawing.Size(42, 17);
            this.toCheckBox.TabIndex = 19;
            this.toCheckBox.Text = "To:";
            this.toCheckBox.UseVisualStyleBackColor = true;
            this.toCheckBox.CheckedChanged += new System.EventHandler(this.ToCheckBox_CheckedChanged);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(713, 30);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 21;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // endEditOrDeleteModeButton
            // 
            this.endEditOrDeleteModeButton.Location = new System.Drawing.Point(646, 120);
            this.endEditOrDeleteModeButton.Name = "endEditOrDeleteModeButton";
            this.endEditOrDeleteModeButton.Size = new System.Drawing.Size(142, 23);
            this.endEditOrDeleteModeButton.TabIndex = 22;
            this.endEditOrDeleteModeButton.Text = "End edit or delete mode";
            this.endEditOrDeleteModeButton.UseVisualStyleBackColor = true;
            this.endEditOrDeleteModeButton.Click += new System.EventHandler(this.EndEditOrDeleteModeButton_Click);
            // 
            // modeLabel
            // 
            this.modeLabel.AutoSize = true;
            this.modeLabel.Location = new System.Drawing.Point(465, 125);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(0, 13);
            this.modeLabel.TabIndex = 23;
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(185, 6);
            // 
            // generateSampleDataToolStripMenuItem
            // 
            this.generateSampleDataToolStripMenuItem.Name = "generateSampleDataToolStripMenuItem";
            this.generateSampleDataToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.generateSampleDataToolStripMenuItem.Text = "Generate sample data";
            this.generateSampleDataToolStripMenuItem.Click += new System.EventHandler(this.GenerateSampleDataToolStripMenuItem_Click);
            // 
            // ReservationsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.modeLabel);
            this.Controls.Add(this.endEditOrDeleteModeButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.toCheckBox);
            this.Controls.Add(this.fromCheckBox);
            this.Controls.Add(this.searchCheckBox);
            this.Controls.Add(this.searchComboBox);
            this.Controls.Add(this.pastReservationsCheckBox);
            this.Controls.Add(this.pastReservationsLabel);
            this.Controls.Add(this.reservationsListView);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.reservationsLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ReservationsListForm";
            this.Text = "Manage reservations";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gDPRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightToAccessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightToBeForgottenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label reservationsLabel;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.ListView reservationsListView;
        private System.Windows.Forms.Label pastReservationsLabel;
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.CheckBox searchCheckBox;
        private System.Windows.Forms.CheckBox pastReservationsCheckBox;
        private System.Windows.Forms.CheckBox fromCheckBox;
        private System.Windows.Forms.CheckBox toCheckBox;
        private System.Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button endEditOrDeleteModeButton;
        private System.Windows.Forms.ToolStripMenuItem reservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.Label modeLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem generateSampleDataToolStripMenuItem;
    }
}

