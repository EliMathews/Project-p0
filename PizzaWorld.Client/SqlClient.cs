using System;
using System.Collections.Generic;
using System.Linq;
using PizzaWorld.Domain.Models;
using PizzaWorld.Storing;

namespace PizzaWorld.Client
{
    public class SqlClient
    {
        private readonly PizzaWorldContext _db = new PizzaWorldContext();
        public SqlClient()
        {
          
        }
        public IEnumerable<Store> ReadAll()
        {
           return _db.Stores;
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
    }
}