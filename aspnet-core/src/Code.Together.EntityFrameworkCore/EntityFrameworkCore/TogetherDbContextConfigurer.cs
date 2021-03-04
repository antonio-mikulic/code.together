using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Code.Together.EntityFrameworkCore
{
    public static class TogetherDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TogetherDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<TogetherDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
