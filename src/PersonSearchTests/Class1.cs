using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using PeopleSearch.Models;
using Xunit;

namespace PersonSearchTests
{
    public class Class1
    {
        // I couldn't figure out how to get unit testing working.

        private DbContextOptions<TestPersonContext> options;

        public Class1()
        {
            DbContextOptionsBuilder<TestPersonContext> builder = new DbContextOptionsBuilder<TestPersonContext>();
            SqliteConnection connection = new SqliteConnection((new SqliteConnectionStringBuilder { DataSource = ":memory:" }).ToString());
            builder.UseSqlite(connection);
            options = builder.Options;
        }

        [Fact]
        public void Test1()
        {
            using (TestPersonContext context = new TestPersonContext(options))
            {
                context.Database.OpenConnection();
                Assert.True(context.Database.EnsureCreated());
                context.Database.CloseConnection();
            }
        }
    }
}
