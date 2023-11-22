using Microsoft.EntityFrameworkCore;

namespace ManagementSystem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options) 
        {

        }

        
    }
}
