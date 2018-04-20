using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HotelGuestbook.Classes.Apartment;

namespace HotelGuestbookGUI.Administration.Apartment
{
    public partial class DeleteApartmentForm : Form
    {
        private ApartmentInfo SelectedApartment;
        private readonly List<ApartmentInfo> Apartments = ApartmentProvider.GetAllApartments().ToList();


        public DeleteApartmentForm()
        {
            InitializeComponent();

            Apartments.ForEach(apartment => selectedApartmentComboBox.Items.Add(apartment.ToDropDownString()));
        }


        #region Events


        private void DeleteButton_Click(object sender, System.EventArgs e)
        {
            ApartmentProvider.DeleteApartment(SelectedApartment);

            MessageBox.Show(@"Apartment successfully deleted");

            Close();
        }

        private void SelectedApartmentComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            SelectedApartment = Apartments.ElementAt(selectedApartmentComboBox.SelectedIndex);

            deleteButton.Enabled = true;
        }


        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }


        #endregion
    }
}
