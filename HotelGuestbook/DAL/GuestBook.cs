using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using HotelGuestbook.Classes.Apartment;
using HotelGuestbook.Classes.Person;
using HotelGuestbook.Classes.Reservation;

namespace HotelGuestbook.DAL
{
    public class GuestBook : DbContext
    {
        /// <summary>
        /// Context of the Guest book. 
        /// </summary>
        public static GuestBook Context {
            get;
            private set;
        }
        

        /// <summary>
        /// Constructor.
        /// </summary>
        public GuestBook(string context) : base(context)
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<GuestBook>());

            Context = this;
        }


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
        public DbSet<PersonInfo> Persons { get; set; }

        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
