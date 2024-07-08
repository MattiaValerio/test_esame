using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace API.Context;

public class DataContext : DbContext
{
    private DbContextOptions<DataContext> _options;
    private IConfiguration _conf;

    public DataContext(DbContextOptions<DataContext> options, IConfiguration configuration) : base(options)
    {
        _options = options;
        _conf = configuration; 
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_conf.GetConnectionString("DefaultConnection")); 
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        // seed data
        modelBuilder.Entity<Person>().HasData(new Person("Mattia", "Valerio", 21, new DateOnly(2002, 11, 19)));
        modelBuilder.Entity<Person>().HasData(new Person("Mario", "Rossi", 30, new DateOnly(1991, 1, 1)));
        modelBuilder.Entity<Person>().HasData(new Person("Luca", "Bianchi", 25, new DateOnly(1996, 5, 5)));
    }

    // Add your DbSets here
    DbSet<Person> People { get; set; }
}