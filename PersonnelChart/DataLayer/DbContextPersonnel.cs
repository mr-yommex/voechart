using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using PersonnelChart.Models;

namespace PersonnelChart.DataLayer
{
    public class DbContextPersonnel : DbContext
    {
        public DbContextPersonnel(DbContextOptions options) : base(options)
        {
        }

        public DbSet<PerEntity> personnel { get; set; }

    }
}
