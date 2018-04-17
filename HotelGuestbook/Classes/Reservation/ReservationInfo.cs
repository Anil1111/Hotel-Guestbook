using HotelGuestbook.Classes.Apartment;
using HotelGuestbook.Classes.Person;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelGuestbook.Classes.Reservation
{
    [Table("Reservations")]
    public class ReservationInfo
    {
        /// <summary>
        /// Creates a new instance of ReservationInfo.
        /// </summary>
        /// <param name="personId">ID of the person that made the reservation.</param>
        /// <param name="apartmentId">ID of the apartment of the reservation.</param>
        /// <param name="from">Start date.</param>
        /// <param name="to">End date.</param>
        public ReservationInfo(int personId, int apartmentId, DateTime from, DateTime to)
        {
            PersonId = personId;
            ApartmentId = apartmentId;
            From = from;
            To = to;
        }


        /// <summary>
        /// Creates a new instance of ReservationInfo.
        /// </summary>
        public ReservationInfo() { }


        /// <summary>
        /// ID of a reservation.
        /// </summary>
        [Key]
        public int ReservationId { get; set; }


        /// <summary>
        /// ID of the person who made the reservation.
        /// </summary>
        public int PersonId { get; set; }


        /// <summary>
        /// ID of the apartment of this reservation.
        /// </summary>
        public int ApartmentId { get; set; }


        /// <summary>
        /// Person who made the reservation.
        /// </summary>
        [ForeignKey("PersonId")]
        public virtual PersonInfo Person { get; set; }


        /// <summary>
        /// Apartment of this reservation.
        /// </summary>
        [ForeignKey("ApartmentId")]
        public virtual ApartmentInfo Apartment { get; set; }


        /// <summary>
        /// Date indicating the day from which is the reservation.
        /// </summary>
        public DateTime From { get; set; }


        /// <summary>
        /// Date indicating the day till which is the reservation.
        /// </summary>
        public DateTime To { get; set; }


        public override string ToString() => $"{ReservationId};{Person};{Apartment};{From:dd.MM.yyyy};{To:dd.MM.yyyy}";
    }
}