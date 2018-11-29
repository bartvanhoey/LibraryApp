using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LibraryApp.Authorization.Roles;
using LibraryApp.Authorization.Users;
using LibraryApp.Models;
using LibraryApp.MultiTenancy;

namespace LibraryApp.EntityFrameworkCore
{
    public class LibraryAppDbContext : AbpZeroDbContext<Tenant, Role, User, LibraryAppDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories{ get; set; }
        
        public LibraryAppDbContext(DbContextOptions<LibraryAppDbContext> options)
            : base(options)
        {
        }
    }
}
