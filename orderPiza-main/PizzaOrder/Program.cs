using System;
using PizzaOrder.Core.Services;
using PizzaOrder.Core.enums;

namespace PizzaOrder
{
    class Program
    {
        static PizzaShop shop = null;
        static PizzaTypes PizzaType;
        static void Main(string[] args)
        {
            Console.WriteLine("Please select your pizza Style:");
            Console.WriteLine("1. Special");
            Console.WriteLine("2. Standard");
            Console.WriteLine("3. Family");

            TryParseInput(Console.ReadLine());

            Console.WriteLine("Please select your pizza Type:");
            Console.WriteLine("1. Peperoni(1#)");
            Console.WriteLine("2. Meat(2#)");

            TryParseInput(Console.ReadLine());

            shop.OrderPizza(PizzaType);
           
            Console.WriteLine();

        }

        static void TryParseInput(string input)
        {
            var firstChar = input.Substring(0, 1);
            if (shop == null)
            {
                switch (firstChar)
                {
                    case "1": { shop = new SpecialPizzaShop(); break; }
                    case "2": { shop = new StandardPizzaShop(); break; }
                    case "3": { shop = new FamilyPizzaShop(); break; }
                    default: Environment.Exit(0); break;
                }
            }
            else
            {
                switch (firstChar)
                {
                    case "1": { PizzaType = PizzaTypes.Peperoni; break; }
                    case "2": { PizzaType = PizzaTypes.Meat; break; }
                    default: Environment.Exit(0); break;
                }
            }
        }
    }
}

