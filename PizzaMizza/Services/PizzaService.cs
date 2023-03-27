using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using PizzaMizza.Interfaces;
using PizzaMIzza.Core.Models;

namespace PizzaMizza.Services
{
    public class PizzaService : IPizza
    {

        public void CreatePizza(Pizza pizza)
        {
            List<Pizza> list = new List<Pizza>();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Add Pizza Name:  ");
            string name = Console.ReadLine();

            while (!char.IsUpper(name[0]) || name.Any(char.IsDigit) || name == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter the name properly!");
                name = Console.ReadLine();
            }
            pizza.Name = name;
            list.Add(pizza);

            Console.Clear();
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("Choose Size:  ");
            Console.WriteLine("1-Large");
            Console.WriteLine("2-Medium");
            Console.WriteLine("3-Small");
            Console.ForegroundColor=ConsoleColor.White;
            string size = Console.ReadLine();


            while (size != null)
            {
                switch (size)
                {
                    case "1":
                        pizza.Size = Pizza.PizzaSize.large;
                        break;
                    case "2":
                        pizza.Size = Pizza.PizzaSize.medium;
                        break;
                    case "3":
                        pizza.Size = Pizza.PizzaSize.small;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Only 1,2,3 are available!");
                        break;
                }
                break;
            }
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter Pizza's Price:  ");
            int price = int.Parse(Console.ReadLine());
            pizza.Price = price;
            list.Add(pizza);
            list[list.Count-1] = pizza;


        }

        public void ShowPizza(Pizza pizza)
        {
            List<Pizza> list = new List<Pizza>();

            foreach (var i in list)
            {
                if (i != null)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(i.ToString());

                    Console.WriteLine("0-left");
                    Console.WriteLine("1-Get more information about pizza");

                    string request = Console.ReadLine();
                    if (request == "1")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Enter ID:  ");
                        int id = int.Parse(Console.ReadLine());
                        foreach (var item in list)
                        {
                            if (pizza.Id == id)
                            {
                                Console.WriteLine(item.ToString());
                            }
                        }
                    }
                }
            }
            if (list.Capacity == 0)
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("There is no Pizza!");
            }

        } 
    }
}
