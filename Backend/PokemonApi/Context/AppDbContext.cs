using Configuration.AppSettings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using UsersApi.Models;

namespace UserApi.Context;

public class AppDbContext : DbContext
{

    public DbSet<Users> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            string stringConnection = "Server=localhost\\MSSQLSERVER02;Database=master;Trusted_Connection=True;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(stringConnection);
        }
    }
}
