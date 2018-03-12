using System;
using System.Collections.Generic;

namespace HotelGuestbook.Classes.Reservation
{
    public class ReservationInfo
    {
        /// <summary>
        /// Constructor.
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
        /// ID of a reservation.
        /// </summary>
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
        /// Date indicating the day from which is the reservation.
        /// </summary>
        public DateTime From { get; set; }

        /// <summary>
        /// Date indicating the day till which is the reservation.
        /// </summary>
        public DateTime To { get; set; }

        /// <summary>
        /// Collection of reservations.
        /// </summary>
        public ICollection<ReservationInfo> Reservations { get; set; }
    }
}