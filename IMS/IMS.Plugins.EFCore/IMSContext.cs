using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Microsoft.EntityFrameworkCore;
using IMS.CoreBusiness;

namespace IMS.Plugins.EFCore
{

    public class IMSContext : DbContext
    {
        public IMSContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Inventory> Inventories { get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Inventory>().HasData(
                
            new Inventory {  InventoryId=1, InventoryName="Engine", Price=1000, Quantity=1},
            new Inventory { InventoryId=2, InventoryName="Body", Price=400, Quantity=1},
             new Inventory { InventoryId = 3, InventoryName = "Wheels", Price = 100, Quantity = 4 },
             new Inventory { InventoryId=4, InventoryName="Seats", Price=50, Quantity=5}

            );
        }
    }
}
