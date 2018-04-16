using HotelGuestbook.Classes.Reservation;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelGuestbook.Classes.Apartment
{
    [Table("Apartments")]
    public class ApartmentInfo
    {
        /// <summary>
        /// Creates a new instance of ApartmentInfo.
        /// </summary>
        /// <param name="capacity">Capacity of the apartment.</param>
        /// <param name="doubleBeds">Number of double beds in an apartment.</param>
        public ApartmentInfo(int number, int price, int capacity, int doubleBeds)
        {
            Number = number;
            Price = price;
            Capacity = capacity;
            DoubleBeds = doubleBeds;
        }


        /// <summary>
        /// Creates a new instance of ApartmentInfo.
        /// </summary>
        public ApartmentInfo() { }


        /// <summary>
        /// ID of the apartment.
        /// </summary>
        [Key]
        public int ApartmentId { get; set; }


        /// <summary>
        /// Number of the room.
        /// </summary>
        public int Number { get; set; }


        /// <summary>
        /// Price of the apartment for one night.
        /// </summary>
        public int Price { get; set; }


        /// <summary>
        /// Apartment's capacity.
        /// </summary>
        public int Capacity { get; set; }


        /// <summary>
        /// Number of double beds in capacity.
        /// </summary>
        public int DoubleBeds { get; set; }


        /// <summary>
        /// Holds a list of reservations to this apartment.
        /// </summary>
        public virtual ICollection<ReservationInfo> Reservations { get; set; }


        /// <summary>
        /// ToString() method for dropdown apartment selection.
        /// </summary>
        public string ToDropDownString()
        {
            return $"Number: {Number.ToString()}, Capacity: {Capacity.ToString()}, Double beds: {DoubleBeds.ToString()}, Price: {Price.ToString()} EUR";
        }


        public override string ToString()
        {
            return $"{Number.ToString()}";
        }
    }
}
