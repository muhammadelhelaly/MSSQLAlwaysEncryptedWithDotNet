using AlwaysEncrypted.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace AlwaysEncrypted.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Employee> Employees { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>()
            .HasData(new Employee[]
            {
                new Employee { Id = 1, SSN = "795-73-9838", FirstName = "Catherine", LastName = "Abel", Salary = 31692 },
                new Employee { Id = 2, SSN = "990-00-6818", FirstName = "Kim", LastName = "Abercrombie", Salary = 55415 }
            });

        base.OnModelCreating(modelBuilder);
    }
}