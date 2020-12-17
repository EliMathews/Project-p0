using PizzaWorld.Domain.Models;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace PizzaWorld.Domain.Singletons
{
   public class ClientSingleton
    {
        private ClientSingleton _instance;
        public ClientSingleton Instance 
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
            
        }
        public void GetAllStores()
        {
            Stores = new List<Store>();
            
        }
        public void MakeStore()
        {
            var s = new Store();

            Stores.Add(s);
            Save();
        }
        private void Save()
        {
            string path = @"PizzaWorld.xml";
            var file = new StreamWriter(path);
            var xml = new XmlSerializer(typeof(List<Store>));

            xml.Serialize(file, Stores);
        }
    }
}