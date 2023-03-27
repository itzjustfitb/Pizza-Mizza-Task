using System.Collections;
using PizzaMIzza.Core.Models.BaseModel;

namespace PizzaMIzza.Core.Models
{
    public class Pizza:FastaFood
    {
        public static int _id = 0;
        public readonly int Id;
        public string Name { get; set; }
        public int Price { get; set; }
        public string Ingredient { get; set; }
        public PizzaSize Size { get; set; }
        public enum PizzaSize { small,medium,large}


        public Pizza(Pizza pizza)
        {
            _id++;
            Id = _id;
        }
        public override string ToString()
        {
            return ($"ID: {Id}    Name: {Name}    Size: {Size}    Price: {Price}");
        }

    }
}