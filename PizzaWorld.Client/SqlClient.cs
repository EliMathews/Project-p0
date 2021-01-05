using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PizzaWorld.Domain.Models;
using PizzaWorld.Storing;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Client
{
    public class SqlClient
    {
        private static readonly PizzaWorldContext _db = new PizzaWorldContext();
        public SqlClient()
        {
          
        }
        public IEnumerable<Store> ReadAllStores()
        {
           return _db.Stores;
        }

        public IEnumerable<APizzaModel> ReadAllPizzas()
        {
           return _db.Pizzas;
        }

        public Store ReadOne(string name)
        {
            return _db.Stores.FirstOrDefault(s => s.Name == name); //linq predicate
            
        }
        public IEnumerable<Order> ReadOrders(Store store) //we want to make this generic
        {
            var s = ReadOne(store.Name);

            return s.Orders;
        }
        public void Save(Store store)
        {
            _db.Add(store); //git add
            _db.SaveChanges(); //git commit

        }
        public void Update(Store store)
        {
            _db.SaveChanges();
        }
        public Store SelectStore()
        {
            string input = Console.ReadLine();

            return ReadOne(input);
        }
        //repository pattern
        //CRUD for Storage - DML for SQL
/*         public void UserOrderHistory(User user)
        {
            var u = _db.Users
                      .Include(u => u.Orders)
                      .ThenInclude(o => o.Pizzas)
                      .FirstOrDefault(u => u.EntityId == user.EntityId); // explicit loading
            var o = u.Orders.Pizzas;
            var p = _db.Pizzas.Select(s => s.EntityId == u.Pizzas);
        } */
    }
}
