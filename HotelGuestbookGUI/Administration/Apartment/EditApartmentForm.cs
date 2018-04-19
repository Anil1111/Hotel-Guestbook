using HotelGuestbook.Classes.Apartment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HotelGuestbookGUI.Administration.Apartment
{
    public partial class EditApartmentForm : Form
    {
        private ApartmentInfo _selectedApartment;
        private readonly List<ApartmentInfo> _apartments;


        public EditApartmentForm()
        {
            InitializeComponent();

            _apartments = ApartmentProvider.GetAllApartments().ToList();
            _apartments.ForEach(apartment => selectApartmentComboBox.Items.Add(apartment.ToDropDownString()));
        }


        #region Events


        private void SelectApartmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedApartment = _apartments.ElementAt(selectApartmentComboBox.SelectedIndex);

            roomNumberTextBox.Text = _selectedApartment.Number.ToString();
            roomNumberTextBox.Enabled = true;

            priceTextBox.Text = _selectedApartment.Price.ToString();
            priceTextBox.Enabled = true;

            capacityComboBox.SelectedIndex = _selectedApartment.Capacity - 1;
            capacityComboBox.Enabled = true;

            doubleBedsComboBox.SelectedIndex = _selectedApartment.DoubleBeds;
            doubleBedsComboBox.Enabled = true;
        }


        private void CancelButton_Click(object sender, EventArgs e) => Close();


        private void SaveButton_Click(object sender, EventArgs e) => ValidateData();


        #endregion


        private void ValidateData()
        {
            var apartments = ApartmentProvider.GetAllApartments().Except(new List<ApartmentInfo> { _selectedApartment }).ToList();

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

            _selectedApartment.Number = int.Parse(roomNumberTextBox.Text);
            _selectedApartment.Price = int.Parse(priceTextBox.Text);
            _selectedApartment.Capacity = capacityComboBox.SelectedIndex + 1;
            _selectedApartment.DoubleBeds = doubleBedsComboBox.SelectedIndex;

            ApartmentProvider.UpdateApartment(_selectedApartment);

            MessageBox.Show(@"Changes succesfully saved.");

            Close();
        }
    }
}
