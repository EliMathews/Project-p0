using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
  public class CheesePizza : APizzaModel
  {
    protected override void AddCrust()
    {
      Crust = "regular";
    }
    protected override void AddSize()
    {
      Size = "small";
    }

    protected override void AddToppings()
    {
      Toppings = new List<string>
      {
        "cheese",
        "extra cheese"
      };
    }
  }
}