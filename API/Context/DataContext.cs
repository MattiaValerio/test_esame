using Microsoft.EntityFrameworkCore;

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
    
    // Add your DbSets here
    
}