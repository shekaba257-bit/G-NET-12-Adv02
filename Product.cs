using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Session02_AdvencedC_
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public static List<Product> SearchProducts(List<Product> products, Func<Product, bool> filter)
        {
            List<Product> result = new List<Product>();

            foreach (var product in products)
            {
                if (filter(product))
                { 
                    result.Add(product);
                }
            }

            return result;
        }


        public static void PrintProducts(string title, List<Product> products)
        {
            Console.WriteLine($"\n--- {title} ---");
            foreach (var p in products)
            {
                Console.WriteLine($"{p.Name} - {p.Price}$ - Stock: {p.Stock}");
            }


        }


        //Task(2)
        //public static void PrintReport(List<Product> products, Action<Product> printer)
        //{
        //    foreach (var product in products)
        //    {
        //        printer(product);
        //    }
        //}


        //Task(3)

        //public static void PrintReport(List<Product> products, Action<Product> action)
        //{
        //    foreach (var product in products)
        //    {
        //        action(product);
        //    }
        //}

        //Task(3.2)
        public static List<T> TransformProducts<T>(List<Product> products, Func<Product, T> transformer)
        {
            List<T> result = new List<T>();

            foreach (var product in products)
            {
                result.Add(transformer(product));
            }

            return result;
        }
    }
}
