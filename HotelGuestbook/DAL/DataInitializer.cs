using HotelGuestbook.Classes.Apartment;
using HotelGuestbook.Classes.Person;
using HotelGuestbook.Classes.Reservation;
using System;
using System.Data.Entity;

namespace HotelGuestbook.DAL
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<GuestBookContext>
    {
        protected override void Seed(GuestBookContext context)
        {
            var apartment = new ApartmentInfo(capacity: 4, doubleBeds: 0);
            context.Apartments.Add(apartment);
            context.SaveChanges();

            var employee = new EmployeeInfo("Name", "Surname", new DateTime(2000, 1, 1), "mail@mail.com", isEnabled: true);
            context.Employees.Add(employee);
            context.SaveChanges();

            var guest = new GuestInfo("Guest", "Name", new DateTime(2000, 1, 1), "mail@abc.com");
            context.Guests.Add(guest);
            context.SaveChanges();

            var reservation = new ReservationInfo(1, 1, DateTime.Now, DateTime.Now);
            context.Reservations.Add(reservation);
            context.SaveChanges();
        }
    }
}
