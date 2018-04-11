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

            if (!GuestBookContext.Database.Exists())
            {
                GenerateTestData(GuestBookContext, true);
            }
        }


        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            GuestBookContext.Database.Connection.Close();
            //GuestBookContext.Database.ForceDropDatabase();

            GuestBookContext.Dispose();
        }
    }
}
