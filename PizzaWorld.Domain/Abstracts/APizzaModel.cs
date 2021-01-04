using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaWorld.Domain.Abstracts
{
  public class APizzaModel : AEntity
  {
    public string Name { get; set; }
    public string Crust { get; set; }
    public string Size { get; set; }
    [NotMapped]
public List<string> Toppings { get; set; }

    public APizzaModel()
    {
      AddCrust();
      AddSize();
      AddToppings();
    }

    protected virtual void AddCrust() { }
    protected virtual void AddSize() { }
    protected virtual void AddToppings() { }
  }
}