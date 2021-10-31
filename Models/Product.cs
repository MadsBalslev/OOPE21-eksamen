using System;

namespace Stregsystem.Models
{
  public class Product
  {
    public Product(int id, string name, decimal price, int active)
    {
      this._id = id;
      this.Name = name;
      this.Price = price;
      this.Active = Convert.ToBoolean(active);
    }
    private int _id;
    public string Name { get; set; }
    public decimal Price { get; private set; }
    public bool Active { get; private set; }

    public override string ToString() => $"{_id} {Name} ({Price})";
  }
}