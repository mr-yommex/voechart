using Microsoft.EntityFrameworkCore;
using VoeChart.Models;

namespace VoeChart.DataLayer
{
    public class DbContextAccomodation : DbContext
    {
        public DbContextAccomodation(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AccEntity> accomodation { get; set; }
   
    }
}
