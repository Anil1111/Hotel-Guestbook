using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelGuestbook.Classes.Apartment
{
    [Table("Apartments")]
    public class ApartmentInfo
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="capacity">Capacity of the apartment.</param>
        /// <param name="doubleBeds">Numbe rof double beds in an apartment.</param>
        public ApartmentInfo(int capacity, int doubleBeds)
        {
            Capacity = capacity;
            DoubleBeds = doubleBeds;
        }

        protected ApartmentInfo() { }

        /// <summary>
        /// ID of the apartment.
        /// </summary>
        [Key]
        public int ApartmentId { get; set; }

        /// <summary>
        /// Apartment's capacity.
        /// </summary>
        public int Capacity { get; set; }

        /// <summary>
        /// Number of double beds in capacity.
        /// </summary>
        public int DoubleBeds { get; set; }
    }
}
