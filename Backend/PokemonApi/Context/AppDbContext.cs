using Microsoft.EntityFrameworkCore;
using UsersApi.Models;

namespace UserApi.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) 
        {}

        public DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string stringConnection = "Server=localhost\MSSQLSERVER02;Database=master;Trusted_Connection=True;";
                optionsBuilder.UseSqlServer(stringConnection);
            }
        }
    }
}
