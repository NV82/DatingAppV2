using DatingAppV2.API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace DatingAppV2.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {       
        }

        public DbSet<AppUser> Users { get; set; }

        internal Task<bool> AddAsync()
        {
            throw new NotImplementedException();
        }
    }
}
