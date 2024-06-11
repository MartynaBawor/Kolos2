using Kolos2.Models;
using Microsoft.EntityFrameworkCore;

namespace Kolos2.Data;

public class DatabaseContext : DbContext
{
    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Item> Items { get; set; }
    public DbSet<Title> Titles { get; set; }
    public DbSet<Character> Characters { get; set; }
    public DbSet<CharacterTitle> CharacterTitles { get; set; }
    public DbSet<Backpack> CharacterItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Item>().HasData(new List<Item>
        {
            new Item()
            {
                Id = 1,
                Name = "Sword",
                Weight = 10
            },
            new Item()
            {
                Id = 2,
                Name = "Shield",
                Weight = 15
            },

        });
        modelBuilder.Entity<Title>().HasData(new List<Title>
        {
            new Title()
            {
                Id = 1,
                Name = "Knight"
            },
            new Title()
            {
                Id = 2,
                Name = "Barbarian"
            },
        });
        modelBuilder.Entity<Character>().HasData(new List<Character>
        {
            new Character()
            {
                Id = 1,
                FirstName = "Jan",
                LastName = "Kowalski",
                CurrentWeight = 10,
                MaxWeight = 100
            },
            new Character()
            {
                Id = 2,
                FirstName = "Anna",
                LastName = "Nowak",
                CurrentWeight = 40,
                MaxWeight = 200
            },
        });
        modelBuilder.Entity<CharacterTitle>().HasData(new List<CharacterTitle>
        {
            new CharacterTitle()
            {
                CharacterId = 1,
                TitleId = 1,
                AcquiredAt = DateTime.Parse("2023-09-04"),

            },
            new CharacterTitle()
            {
                CharacterId = 2,
                TitleId = 2,
                AcquiredAt = DateTime.Parse("2022-11-23"),
            },
            new CharacterTitle()
            {
                CharacterId = 1,
                TitleId = 2,
                AcquiredAt = DateTime.Parse("2010-08-11"),
            }
        });
        modelBuilder.Entity<Backpack>().HasData(new List<Backpack>
        {
            new Backpack()
            {
                CharacterId = 1,
                ItemId = 1,
                Amount = 30,

            },
            new Backpack()
            {
                CharacterId = 1,
                ItemId = 2,
                Amount = 40,
            },
            new Backpack()
            {
                CharacterId = 2,
                ItemId = 1,
                Amount = 22,
            },
            new Backpack()
            {
                CharacterId = 2,
                ItemId = 2,
                Amount = 34,
            },
        });

    }
}