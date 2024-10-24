using Casting.Models;
using System.Reflection;

namespace Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple apple1 = new Apple(1m, "Green", 10, 11);
            PineApple pineApple1 = new PineApple(1.5m, "Spanish", 12, 13);
            Orange orange1 = new Orange(2m, "Navel", 14);

            apple1.Taste();
            pineApple1.Taste();
            orange1.Taste();

            Console.WriteLine("");

            Fruit[] basket = { apple1, pineApple1, orange1 };

            foreach (Fruit fruit in basket)
            {
                Type fruitType = fruit.GetType();
                Console.WriteLine($"Type: {fruitType.Name}");

                FieldInfo[] fields = fruitType.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);
                PropertyInfo[] properties = fruitType.GetProperties();

                foreach (var property in properties)
                {
                    Console.WriteLine($"{property.Name}: {property.GetValue(fruit)}");
                }
                foreach (var field in fields)
                {
                    Console.WriteLine($"{field.Name}: {field.GetValue(fruit)}");
                }

                Console.WriteLine();
            }
        }
    }
}
