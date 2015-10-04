using System.Data.Entity;
using System.Reflection.Emit;
using Domain.Models;

namespace EntityFrameworkConnection.Context
{
    public class ShopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
