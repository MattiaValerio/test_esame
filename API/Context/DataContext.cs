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
        modelBuilder.Entity<Person>().HasData(
            new Person(1,"Mattia", "Valerio", new DateOnly(2002, 11, 19)),
            new Person(2,"Mario", "Rossi", new DateOnly(1991, 1, 1)),
            new Person(3, "Luca", "Bianchi", new DateOnly(1996, 5, 5)),
            new Person(4,"Luca", "Verdi", new DateOnly(1981, 2, 2)),
            new Person(5,"John", "Doe", new DateOnly(1996, 10, 10)),
            new Person(6,"Jane", "Doe", new DateOnly(1999, 5, 5))
        );
    }

    // Add your DbSets here
    public DbSet<Person> People { get; set; }
}