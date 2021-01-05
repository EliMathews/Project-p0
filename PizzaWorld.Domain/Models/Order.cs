using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Factories;

namespace PizzaWorld.Domain.Models
{
  public class Order : AEntity
  {
    private GenericPizzaFactory _pizzaFactory = new GenericPizzaFactory();

    public List<APizzaModel> Pizzas { get; set; }

    public Order()
    {
      Pizzas = new List<APizzaModel>();
    }

    public void MakeMeatPizza()
    {
      Pizzas.Add(_pizzaFactory.Make<MeatPizza>());
    }
        public void MakeCheesePizza()
    {
      Pizzas.Add(_pizzaFactory.Make<CheesePizza>());
    }
        public void MakeHawaiianPizza()
    {
      Pizzas.Add(_pizzaFactory.Make<HawaiianPizza>());
    }
        public void MakePepperoniPizza()
    {
      Pizzas.Add(_pizzaFactory.Make<PepperoniPizza>());
    }
        public void MakeVeggiePizza()
    {
      Pizzas.Add(_pizzaFactory.Make<VeggiePizza>());
    }
  }
}