using ManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace ManagementSystem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options) 
        {

        }
        //defining the creation of table Categories in sql server here.
        public DbSet<Category> Categories { get; set; }

    }
}
