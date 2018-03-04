using System;

namespace HotelGuestbook.ExtensionMethods.Reservation
{
    public class ReservationInfo
    {
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
    }
}