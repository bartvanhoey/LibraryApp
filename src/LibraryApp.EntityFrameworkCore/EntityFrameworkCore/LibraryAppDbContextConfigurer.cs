using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.EntityFrameworkCore
{
    public static class LibraryAppDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<LibraryAppDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<LibraryAppDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
