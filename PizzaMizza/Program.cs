
using System.Collections;
using PizzaMizza.Interfaces;
using PizzaMizza.Services;
using PizzaMIzza.Core.Models;

public class Program
{
    private static void Main(string[] args)
    {
        PizzaService service = new PizzaService();
        Pizza pizza = new Pizza(pizza);
        List<Pizza> pizzaList = new List<Pizza>();

        Console.ForegroundColor= ConsoleColor.Green;
        Console.WriteLine("--------------------");
        Console.WriteLine("0:Left");
        Console.WriteLine("1:Show Pizza");
        Console.WriteLine("2:Create Pizza");
        Console.WriteLine("--------------------");
        Console.ForegroundColor = ConsoleColor.White;
        string request = Console.ReadLine();

        while (request != "0")
        {
            switch (request)
            {
                case "1":
                    service.ShowPizza(pizza);
                    break;
                case "2":
                    service.CreatePizza(pizza);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Only 3 operation is available!");
                    break;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------");
            Console.WriteLine("0:Left");
            Console.WriteLine("1:Show Pizza");
            Console.WriteLine("2:Create Pizza");
            Console.WriteLine("--------------------");
            Console.ForegroundColor = ConsoleColor.White;

            request = Console.ReadLine();
            Console.ReadKey();
        }
    }
}