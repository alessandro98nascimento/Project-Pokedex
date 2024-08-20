using Microsoft.EntityFrameworkCore;
using PokedexApi.Models;
using UsersApi.Models;
using TypesApi.Models;
using SuperEffectiveApi.Models;
using WeaknessesApi.Models;

namespace UserApi.Context;

public class AppDbContext : DbContext
{

    public DbSet<Users> Users { get; set; }
    public DbSet<Pokemon> Pokedex {  get; set; }
    public DbSet<PokeType> PokeTypes { get; set; }
    public DbSet<Effective>SuperEffectives { get; set; }
    public DbSet<Weakness> Weaknesses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Users>().HasData
            (
            new Users
            { 
                Email = "alessandro@hotmail.com", 
                UserActive = 1, 
                UserId = 1, 
                UserName = "alessandro", 
                UserPassword = "123456" 
            },
            new Users
            {
                Email = "allan@hotmail.com",
                UserActive = 1,
                UserId = 2,
                UserName = "allan",
                UserPassword = "456789"
            }
            );

        modelBuilder.Entity<PokeType>().HasData
           (
               new PokeType
               {
                    Id = 1,
                    TypeName = "Normal"
               },
               new PokeType
               {
                   Id = 2,
                   TypeName = "Fire"
               },
               new PokeType
               {
                   Id = 3,
                   TypeName = "Fighting"
               },
               new PokeType
               {
                   Id = 4,
                   TypeName = "Water"
               },
               new PokeType
               {
                   Id = 5,
                   TypeName = "Flying"
               },
               new PokeType
               {
                   Id = 6,
                   TypeName = "Grass"
               },
               new PokeType
               {
                   Id = 7,
                   TypeName = "Poison"
               },
               new PokeType
               {
                   Id = 8,
                   TypeName = "Electric"
               },
               new PokeType
               {
                   Id = 9,
                   TypeName = "Ground"
               },
               new PokeType
               {
                   Id = 10,
                   TypeName = "Psychic"
               },
               new PokeType
               {
                   Id = 11,
                   TypeName = "Rock"
               },
               new PokeType
               {
                   Id = 12,
                   TypeName = "Ice"
               },
               new PokeType
               {
                   Id = 13,
                   TypeName = "Bug"
               },
               new PokeType
               {
                   Id = 14,
                   TypeName = "Dragon"
               },
               new PokeType
               {
                   Id = 15,
                   TypeName = "Ghost"
               },
               new PokeType
               {
                   Id = 16,
                   TypeName = "Dark"
               },
               new PokeType
               {
                   Id = 17,
                   TypeName = "Steel"
               },
               new PokeType
               {
                   Id = 18,
                   TypeName = "Fairy"
               }
           );
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            string stringConnection = "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(stringConnection);
        }
    }
}
