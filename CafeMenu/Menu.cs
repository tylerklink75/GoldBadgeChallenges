using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu
{
    public class Menu
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public decimal Price { get; set; }

        public Menu(string name, int number, string description, string ingredients, decimal price)
        {
            Name = name;
            Number = number;
            Description = description;
            Ingredients = ingredients;
            Price = price;

        }
        public Menu() { }
    }

   
}
