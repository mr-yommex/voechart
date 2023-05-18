using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Personnel.Models;

namespace Personnel.DataLayer
{
    public class DbContextPersonnel : DbContext
    {
        public DbContextPersonnel(DbContextOptions options) : base(options)
        {
        }

        public DbSet<PerEntity> personnel { get; set; }

    }
}
