using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using HotelGuestbook.Classes.Apartment;
using HotelGuestbook.Classes.Person;
using HotelGuestbook.Classes.Reservation;

namespace HotelGuestbook.DAL
{
    public class GuestBookContext : DbContext
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public GuestBookContext() : base("GuestBookContext") { }

        /// <summary>
        /// DB set of apartments.
        /// </summary>
        public DbSet<ApartmentInfo> Apartments { get; set; }

        /// <summary>
        /// DB set of reservations.
        /// </summary>
        public DbSet<ReservationInfo> Reservations { get; set; }

        /// <summary>
        /// DB set of employees.
        /// </summary>
        public DbSet<EmployeeInfo> Employees { get; set; }

        /// <summary>
        /// DB set of guests.
        /// </summary>
        public DbSet<GuestInfo> Guests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
