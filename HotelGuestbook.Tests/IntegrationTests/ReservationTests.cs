using HotelGuestbook.Classes.Reservation;
using HotelGuestbook.Tests.TestsBase;
using NUnit.Framework;
using System;
using System.Linq;

namespace HotelGuestbook.Tests.IntegrationTests
{
    public class ReservationTests : IntegrationTestsBase
    {
        [Test]
        public void DataInitializer_GeneratesCorrectAmountOfReservations()
        {
            Assert.That(GuestBookContext.Reservations.ToList().Count, Is.EqualTo(5));
        }


        [Test]
        public void GetAllApartments_ReturnsAllReservations()
        {
            var count = GuestBookContext.Reservations.Count();

            Assert.That(ReservationProvider.GetAllReservations().Count(), Is.EqualTo(count));
        }


        [Test]
        [Ignore("Depends on current DB state")]
        public void GetAllReservationsFrom_RetursCorrectNumberOfReservations()
        {
            var from = new DateTime(year: 2018, month: 2, day: 1);
            var reservationsFrom = ReservationProvider.GetAllReservationsFrom(from);

            Assert.That(reservationsFrom.Count(), Is.EqualTo(2));
        }


        [Test]
        [Ignore("Depends on current DB state")]
        public void GetAllReservationsTill_RetursCorrectNumberOfReservations()
        {
            var till = new DateTime(year: 2018, month: 2, day: 1);
            var reservationsFrom = ReservationProvider.GetAllReservationsTill(till);

            Assert.That(reservationsFrom.Count(), Is.EqualTo(2));
        }


        [Test]
        public void SetReservation_ReservationIsSavedToDb()
        {
            var reservation = new ReservationInfo(5, 5, DateTime.Now, DateTime.Now);
            var count = ReservationProvider.GetAllReservations().Count();

            ReservationProvider.SetReservation(reservation);

            Assert.That(ReservationProvider.GetAllReservations().Count(), Is.EqualTo(count + 1));
        }


        [Test]
        public void DeleteReservation_ReservationIsDeletedFromDb()
        {
            var reservation = ReservationProvider.GetAllReservations().First();
            var count = ReservationProvider.GetAllReservations().Count();

            ReservationProvider.DeleteReservation(reservation);

            Assert.That(ReservationProvider.GetAllReservations().Count(), Is.EqualTo(count - 1));
        }
    }
}
