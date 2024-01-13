using StudentDatabase.Models;
using Microsoft.EntityFrameworkCore;

namespace StudentDatabase.Data;
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) // the base keyword is allowing us to access stuff from the base or parent class
    {
        
    }

    public DbSet<Student> Students { get; set; }
}

