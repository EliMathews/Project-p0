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
            foreach (var store in _sql.ReadAllStores())
            {
                System.Console.WriteLine(store);
            }
        }

        static void PrintAllPizzasWithEF()
        {
            foreach (var pizza in _sql.ReadAllPizzas())
            {
                System.Console.WriteLine(pizza.Name);
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
                PrintAllPizzasWithEF();
                Console.WriteLine("Select a pizza where 1 selects Cheese Pizza and 5 selects Veggie Pizza");
                user.SelectedStore.CreateOrder();
                //user.Orders.Add(user.SelectedStore.Orders.Last());
                //user.Orders.Last().MakeMeatPizza();
                //_sql.Update(user.SelectedStore);
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