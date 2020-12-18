using System;
using System.Collections.Generic;
using PizzaWorld.Domain.Models;
using PizzaWorld.Domain.Singletons;

namespace PizzaWorld.Client
{
    class Program
    {
        private static readonly ClientSingleton _client = ClientSingleton.Instance;   // readonly only creates value for this field when application is running.
        static void Main(string[] args)
        {
            _client.MakeStore();

            PrintAllStores();
        }

        static void PrintAllStores()
        {
            foreach (var store in _client.Stores)
            {
                System.Console.WriteLine(store);
            }
        }
    }
}
