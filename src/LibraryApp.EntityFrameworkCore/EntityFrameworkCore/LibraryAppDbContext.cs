using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LibraryApp.Authorization.Roles;
using LibraryApp.Authorization.Users;
using LibraryApp.MultiTenancy;

namespace LibraryApp.EntityFrameworkCore
{
    public class LibraryAppDbContext : AbpZeroDbContext<Tenant, Role, User, LibraryAppDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public LibraryAppDbContext(DbContextOptions<LibraryAppDbContext> options)
            : base(options)
        {
        }
    }
}
