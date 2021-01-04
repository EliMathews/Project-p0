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
        Program()
        {
            _client2 = ClientSingleton.Instance;
        }
        static void Main(string[] args)
        {
            Options.StoreSelectionPrompt();
            UserView();
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
            
            Console.WriteLine("Would you like to access the store as an employee or a customer?");
            Console.WriteLine("Enter '1' for employee or '2' for customer");
            
            int Access = int.Parse(Console.ReadLine());
            
            if (Access == 2)
            {
                Console.WriteLine("You selected customer access.");
                user.SelectedStore.CreateOrder();
                user.Orders.Add(user.SelectedStore.Orders.Last());
                user.Orders.Last().MakeMeatPizza();
                _sql.Update(user.SelectedStore);
            }
            if (Access == 1)
            {
                Console.WriteLine("You selected employee access.");
                //Employee store access
            }
            if (Access != 1 & Access != 2)
            {
                Console.WriteLine("Please start over and provide a valid entry.");
            }
            //System.Console.WriteLine(user);
        }
        
    }
}