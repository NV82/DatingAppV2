using DatingAppV2.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatingAppV2.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {       
        }

        public DbSet<AppUser> Users { get; set; }
    }
}
