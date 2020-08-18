namespace WebAPI.Data
{
using Microsoft.EntityFrameworkCore;
using Core.Entities;

public class StoreContext : DbContext {
            public StoreContext() { }
            public StoreContext(DbContextOptions<StoreContext> options) : base (options) {

             }
    
            public DbSet<Product> Products { get; set; }
        }
}

