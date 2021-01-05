using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Storing
{
    public class PizzaWorldContext : DbContext
    {
        public DbSet<Store> Stores { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<APizzaModel> Pizzas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=tcp:elipizzaworld.database.windows.net,1433;Initial Catalog=PizzaWorldDB;User ID=sqladmin;Password=Password12345;"); //Add Password
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Store>().HasKey(s => s.EntityID);
            builder.Entity<User>().HasKey(u => u.EntityID);
            builder.Entity<Order>().HasKey(o => o.EntityID);
            builder.Entity<APizzaModel>().HasKey(p => p.EntityID);
           /*  builder.Entity<CheesePizza>().HasKey(cp => cp.EntityID);
            builder.Entity<HawaiianPizza>().HasKey(hp => hp.EntityID);
            builder.Entity<MeatPizza>().HasKey(mp => mp.EntityID);
            builder.Entity<PepperoniPizza>().HasKey(pp => pp.EntityID);
            builder.Entity<VeggiePizza>().HasKey(vp => vp.EntityID); */
            //ADD DIFFERENT PIZZA MODELS.. TOPPINGS?

            SeedData(builder); // can do the same thing with pizzas, orders, etc (populates tables with stores)
            
        }
        protected void SeedData(ModelBuilder builder)  // see comment above
        {
            builder.Entity<Store>().HasData(new List<Store>
                {
                    new Store() { EntityID = 2, Name = "One"},
                    new Store() { EntityID = 3, Name = "Two"}
                }
            );
            builder.Entity<APizzaModel>().HasData(new List<APizzaModel>
                {
                    new APizzaModel() { EntityID = 1, Name = "Cheese Pizza"},
                    new APizzaModel() { EntityID = 2, Name = "Hawaiian Pizza"},
                    new APizzaModel() { EntityID = 3, Name = "Meat Pizza"},
                    new APizzaModel() { EntityID = 4, Name = "Pepperoni Pizza"},
                    new APizzaModel() { EntityID = 5, Name = "Veggie Pizza"}
                }
            );
        } 
    }
}

