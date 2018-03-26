using HotelGuestbook.DAL;
using NUnit.Framework;

namespace HotelGuestbook.Tests.TestsBase
{
    public class IntegrationTestsBase : DataInitializer
    {
        protected GuestBook GuestBookContext
        {
            get;
            private set;
        }


        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            GuestBookContext = new GuestBook("GuestBookTests");
        }


        [SetUp]
        public void SetUp()
        {
            GenerateTestData(GuestBookContext, true);
        }


        [TearDown]
        public void TearDown()
        {
            GuestBookContext.Database.ExecuteSqlCommand("DELETE FROM Persons");
            GuestBookContext.Database.ExecuteSqlCommand("DELETE FROM Apartments");
            GuestBookContext.Database.ExecuteSqlCommand("DELETE FROM Reservations");
        }


        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            GuestBookContext.Database.Connection.Close();
            GuestBookContext.Database.ForceDropDatabase();

            GuestBookContext.Dispose();
        }
    }
}
