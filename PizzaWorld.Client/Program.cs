using System;
using System.Collections.Generic;
using System.Linq;
using PizzaWorld.Domain.Models;
using PizzaWorld.Domain.Singletons;

namespace PizzaWorld.Client
{
    class Program
    {
        private static readonly ClientSingleton _client = ClientSingleton.Instance;   // readonly only creates value for this field when application is running.
        private readonly ClientSingleton _client2;
        private static readonly SqlClient _sql = new SqlClient();
        public Program()
        {
            _client2 = ClientSingleton.Instance;
        }
        static void Main(string[] args)
        {
            Options.CustomerOrStorePrompt();
            Options.UserChoice();
            

            UserView();
            
            
            //_client.MakeStore();
            //PrintAllStores();
            //Console.WriteLine(_client.SelectStore());
        }

        static void PrintAllStores()
        {
            foreach (var store in _client.Stores)
            {
                System.Console.WriteLine(store);
            }
        }
        static void PrintAllStoresWithEF()
        {
            foreach (var store in _sql.ReadAll())
            {
                System.Console.WriteLine(store);
            }
        }

        static void UserView()
        {
            var user = new User();

            PrintAllStoresWithEF();

            user.SelectedStore = _sql.SelectStore();
            user.SelectedStore.CreateOrder();
            user.Orders.Add(user.SelectedStore.Orders.Last());
            user.Orders.Last().MakeMeatPizza();
            user.Orders.Last().MakeMeatPizza();
            _sql.Update(user.SelectedStore);

            //System.Console.WriteLine(user);
        }
    }
}
