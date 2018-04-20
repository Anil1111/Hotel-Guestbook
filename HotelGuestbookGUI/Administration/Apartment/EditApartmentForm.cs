using HotelGuestbook.Classes.Apartment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HotelGuestbookGUI.Administration.Apartment
{
    public partial class EditApartmentForm : Form
    {
        private ApartmentInfo SelectedApartment;
        private readonly List<ApartmentInfo> Apartments;


        public EditApartmentForm()
        {
            InitializeComponent();

            Apartments = ApartmentProvider.GetAllApartments().ToList();
            Apartments.ForEach(apartment => selectApartmentComboBox.Items.Add(apartment.ToDropDownString()));
        }


        #region Events


        private void SelectApartmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedApartment = Apartments.ElementAt(selectApartmentComboBox.SelectedIndex);

            roomNumberTextBox.Text = SelectedApartment.Number.ToString();
            roomNumberTextBox.Enabled = true;

            priceTextBox.Text = SelectedApartment.Price.ToString();
            priceTextBox.Enabled = true;

            capacityComboBox.SelectedIndex = SelectedApartment.Capacity - 1;
            capacityComboBox.Enabled = true;

            doubleBedsComboBox.SelectedIndex = SelectedApartment.DoubleBeds;
            doubleBedsComboBox.Enabled = true;
        }


        private void CancelButton_Click(object sender, EventArgs e) => Close();


        private void SaveButton_Click(object sender, EventArgs e) => ValidateData();


        #endregion


        private void ValidateData()
        {
            var apartments = ApartmentProvider.GetAllApartments().Except(new List<ApartmentInfo> { SelectedApartment }).ToList();

            if (!int.TryParse(roomNumberTextBox.Text, out var roomNumber))
            {
                MessageBox.Show(@"Please enter a valid room number");

                return;
            }

            if (apartments.Any(apartment => apartment.Number.Equals(roomNumber)))
            {
                MessageBox.Show(@"An apartment with this number already exists. Please enter a different number.");

                return;
            }

            if (!int.TryParse(priceTextBox.Text, out var price))
            {
                MessageBox.Show(@"Please enter a valid price");

                return;
            }

            if (price <= 0)
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
                MessageBox.Show(@"The capacity is not enough to accommodate this number of double beds.");

                return;
            }

            SelectedApartment.Number = int.Parse(roomNumberTextBox.Text);
            SelectedApartment.Price = int.Parse(priceTextBox.Text);
            SelectedApartment.Capacity = capacityComboBox.SelectedIndex + 1;
            SelectedApartment.DoubleBeds = doubleBedsComboBox.SelectedIndex;

            ApartmentProvider.UpdateApartment(SelectedApartment);

            MessageBox.Show(@"Changes successfully saved.");

            Close();
        }
    }
}
