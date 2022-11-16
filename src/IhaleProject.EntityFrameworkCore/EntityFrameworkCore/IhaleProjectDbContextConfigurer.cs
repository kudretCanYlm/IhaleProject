using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace IhaleProject.EntityFrameworkCore
{
    public static class IhaleProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<IhaleProjectDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<IhaleProjectDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
