using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Code.Together.Configuration;
using Code.Together.Web;

namespace Code.Together.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class TogetherDbContextFactory : IDesignTimeDbContextFactory<TogetherDbContext>
    {
        public TogetherDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<TogetherDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            TogetherDbContextConfigurer.Configure(builder, configuration.GetConnectionString(TogetherConsts.ConnectionStringName));

            return new TogetherDbContext(builder.Options);
        }
    }
}
