using System.Data.Entity;
using System.Data.SqlClient;

namespace HotelGuestbook.Tests.TestsBase
{
    public static class DatabaseExtensions
    {
        public static void ForceDropDatabase(this Database db)
        {
            using (SqlConnection sqlConnection = new SqlConnection(db.Connection.ConnectionString))
            {
                sqlConnection.Open();
                string dbName = db.Connection.Database;

                SqlCommand cmd = new SqlCommand(($@"
USE MASTER;
ALTER DATABASE [{dbName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
DROP DATABASE [{dbName}];"), sqlConnection);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
