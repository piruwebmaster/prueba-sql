
using Microsoft.EntityFrameworkCore;

public class EmployeeDbContext : DbContext
{

    //Constructor with DbContextOptions and the context class itself
    public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
    {
    }
    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     var configuration = new ConfigurationBuilder()
    //         .SetBasePath(Directory.GetCurrentDirectory())
    //         .AddJsonFile("appsettings.json")
    //         .Build();

    //     var connectionString = configuration.GetConnectionString("SISE");
    //     optionsBuilder.UseSqlServer(connectionString);
    // }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Personas>().HasNoKey();
    }
    //Create the DataSet for the Employee         
    public DbSet<Personas> Personas { get; set; }
}

public class Personas
{


    public string? nombre { get; set; }

}