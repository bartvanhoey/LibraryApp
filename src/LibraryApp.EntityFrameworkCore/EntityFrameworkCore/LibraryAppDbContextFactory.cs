using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using LibraryApp.Configuration;
using LibraryApp.Web;

namespace LibraryApp.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class LibraryAppDbContextFactory : IDesignTimeDbContextFactory<LibraryAppDbContext>
    {
        public LibraryAppDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<LibraryAppDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            LibraryAppDbContextConfigurer.Configure(builder, configuration.GetConnectionString(LibraryAppConsts.ConnectionStringName));

            return new LibraryAppDbContext(builder.Options);
        }
    }
}
