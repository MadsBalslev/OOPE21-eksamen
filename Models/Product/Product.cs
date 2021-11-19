using System;

namespace stregsystem.Models
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
        private string _name;

        public string Name { 
          get => _name; 
          set {
            if(value == null)
              throw new ArgumentNullException("Name can't be null");
            _name = value;
          } 
        }
        public decimal Price { get; set; }
        public bool Active { get; private set; }

        public override string ToString() => $"{_id} {Name} ({Price})";
    }
}