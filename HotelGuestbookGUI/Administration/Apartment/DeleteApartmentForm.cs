using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HotelGuestbook.Classes.Apartment;

namespace HotelGuestbookGUI.Administration.Apartment
{
    public partial class DeleteApartmentForm : Form
    {
        private ApartmentInfo _selectedApartment;
        private readonly List<ApartmentInfo> _apartments = ApartmentProvider.GetAllApartments().ToList();


        public DeleteApartmentForm()
        {
            InitializeComponent();

            _apartments.ForEach(apartment => selectedApartmentComboBox.Items.Add(apartment.ToDropDownString()));
        }


        #region Events


        private void DeleteButton_Click(object sender, System.EventArgs e)
        {
            ApartmentProvider.DeleteApartment(_selectedApartment);

            MessageBox.Show(@"Apartment succesfully deleted");

            Close();
        }

        private void SelectedApartmentComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            _selectedApartment = _apartments.ElementAt(selectedApartmentComboBox.SelectedIndex);

            deleteButton.Enabled = true;
        }


        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }


        #endregion
    }
}
