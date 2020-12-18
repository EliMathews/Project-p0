using PizzaWorld.Domain.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace PizzaWorld.Domain.Singletons
{
   public class ClientSingleton
    {
        private const string _path = @"./PizzaWorld.xml"; //The @ symbol prevents the '/' from acting as an escape character prefix
        private static ClientSingleton _instance;
        public static ClientSingleton Instance 
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new ClientSingleton();
                }
                return _instance;
            }
        }
        public List<Store> Stores { get; set; }
        private ClientSingleton()
        {
            Read();
        }
        public void MakeStore()
        {
            Stores.Add(new Store());
            Save();
        }
        public Store SelectStore()
        {
            int.TryParse(Console.ReadLine(), out int input); // 0, selection
            return Stores.ElementAt(input);
        }
        private void Save()
        {

            var file = new StreamWriter(_path);
            var xml = new XmlSerializer(typeof(List<Store>));

            xml.Serialize(file, Stores);
        }

        private void Read()
        {
            if (File.Exists(_path))
            {
            
            var file = new StreamReader(_path);
            var xml = new XmlSerializer(typeof(List<Store>)); // Serializer understands the xml is a list of stores

            Stores = xml.Deserialize(file) as List<Store>;

            /*Serializer itself, does not know what a list of stores is, but it does know that 'file' is going to become an object.
            Object is always the data type that deserializer returns. So, we need to explicitly convert the object to what we want 
            the serializer to return, hence 'as List<Store>'.*/
            }
            else
            {
                Stores = new List<Store>();
            }
        }
    }
}