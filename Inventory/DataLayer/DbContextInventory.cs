using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Inventory.Models;

namespace Inventory.DataLayer
{
    public class DbContextInventory : DbContext
    {
        public DbContextInventory(DbContextOptions options) : base(options)
        {
        }

        public DbSet<InvEntity> inventory { get; set; }

    }
}
