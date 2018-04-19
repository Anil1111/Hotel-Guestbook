﻿using System;
using System.Linq;
using System.Windows.Forms;
using HotelGuestbook.Classes.Apartment;

namespace HotelGuestbookGUI.Administration.Apartment
{
    public partial class AddApartmentForm : Form
    {
       public AddApartmentForm()
        {
            InitializeComponent();
        }


        #region Events


        private void CancelButton_Click(object sender, EventArgs e) => Close();


        private void SaveButton_Click(object sender, EventArgs e) => ValidateData();


        #endregion


        /// <summary>
        /// Validates data from the input boxes.
        /// </summary>
        private void ValidateData()
        {
            var apartments = ApartmentProvider.GetAllApartments().ToList();

            if (apartments.Any(apartment => apartment.Number.Equals(int.Parse(roomNumberTextBox.Text))))
            {
                MessageBox.Show(@"An apartment with this number already exists. Please enter a different number.");

                return;
            }

            if (int.Parse(priceTextBox.Text) <= 0)
            {
                MessageBox.Show(@"Please enter a correct price.");

                return;
            }

            if (capacityComboBox.SelectedIndex < 0)
            {
                MessageBox.Show(@"Please select capacity.");

                return;
            }

            if (doubleBedsComboBox.SelectedIndex < 0)
            {
                MessageBox.Show(@"Please select the number of double beds.");

                return;
            }

            if (int.Parse(doubleBedsComboBox.SelectedItem.ToString()) * 2 > int.Parse(capacityComboBox.SelectedItem.ToString()))
            {
                MessageBox.Show(@"The capacity is not enough to accomodate this number of double beds.");

                return;
            }

            var newApartment = new ApartmentInfo(int.Parse(roomNumberTextBox.Text), int.Parse(priceTextBox.Text),
                int.Parse(capacityComboBox.SelectedItem.ToString()),
                int.Parse(doubleBedsComboBox.SelectedItem.ToString()));

            ApartmentProvider.SetApartment(newApartment);

            MessageBox.Show(@"Apartment succesfully created.");

            Close();
        }
    }
}
