using Microsoft.EntityFrameworkCore;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Storing
{
    public class PizzaWorldContext : DbContext
    {
        public DbSet<Store> Stores { get; set; }
        public DbSet<User> Users { get; set; }
        //public DbSet<APizzaModel> Pizzas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=tcp:elipizzaworld.database.windows.net,1433;Initial Catalog=PizzaWorldDB;User ID=sqladmin;Password=;"); //Add Password
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Store>().HasKey(s => s.EntityID);
            builder.Entity<User>().HasKey(u => u.EntityID);
            builder.Entity<Order>().HasKey(o => o.EntityID);
            builder.Entity<APizzaModel>().HasKey(p => p.EntityID);
            
        }
    }
}