using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ProductdbContext db = new ProductdbContext())
            {
                // получаем объекты из бд и выводим на консоль
                var Products = db.Products.ToList();
                Console.WriteLine("Список объектов:");
                foreach (Product p in Products)
                {
                    Console.WriteLine($"{p.Name}.{p.Price}");
                }
            }
            Console.ReadKey();
        }
    }
}
