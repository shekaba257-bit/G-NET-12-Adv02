namespace Assignment_Session02_AdvencedC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task( 01)
            //        List<Product> catalog = new List<Product>
            //{
            //    new Product{Id=1,Name="Laptop",Category="Electronics",Price=1200,Stock=10},
            //    new Product{Id=2,Name="Phone",Category="Electronics",Price=800,Stock=25},
            //    new Product{Id=3,Name="T-shirt",Category="Clothing",Price=30,Stock=100},
            //    new Product{Id=4,Name="jeans",Category="Clothing",Price=60,Stock=50},
            //    new Product{Id=5,Name="Chocolate",Category="Food",Price=5,Stock=200},
            //    new Product{Id=6,Name="CoffeeBeans",Category="Food",Price=15,Stock=80},
            //    new Product{Id=7,Name="C#Book",Category="Books",Price=45,Stock=30},
            //    new Product{Id=8,Name="Novel",Category="Electronics",Price=20,Stock=60},
            //    new Product{Id=9,Name="HeadPhones",Category="Electronics",Price=150,Stock=40},
            //    new Product{Id=10,Name="Jacket",Category="Clothing",Price=120,Stock=15}
            //};
            //        var electronics = Product.SearchProducts(catalog, p => p.Category == "Electronics");


            //        var cheapProducts = Product.SearchProducts(catalog, p => p.Price < 50);

            //        var inStock = Product.SearchProducts(catalog, p => p.Stock > 0);


            //        var clothingUnder100 = Product.SearchProducts(catalog, p => p.Category == "Clothing" && p.Price < 100);


            //        Product.PrintProducts("Electronics", electronics);
            //        Product.PrintProducts("Cheap (<50)", cheapProducts);
            //        Product.PrintProducts("In Stock", inStock);
            //        Product.PrintProducts("Clothing < 100", clothingUnder100); 
            #endregion


            #region Task02
            //        List<Product> catalog = new List<Product>
            //{
            //    new Product{Id=1,Name="Laptop",Category="Electronics",Price=1200,Stock=10},
            //    new Product{Id=2,Name="Phone",Category="Electronics",Price=800,Stock=25},
            //    new Product{Id=3,Name="T-shirt",Category="Clothing",Price=30,Stock=100},
            //    new Product{Id=4,Name="jeans",Category="Clothing",Price=60,Stock=50},
            //    new Product{Id=5,Name="Chocolate",Category="Food",Price=5,Stock=200}
            //   };

            //        // Scenario 1: Short Report
            //        Console.WriteLine("\n--- Short Report ---");
            //        Product.PrintReport(catalog, p => Console.WriteLine($"{p.Name} - ${p.Price}"));


            //        // Scenario 2: Detailed Report
            //        Console.WriteLine("\n--- Detailed Report ---");
            //        Product.PrintReport(catalog, p =>
            //            Console.WriteLine($"[{p.Category}] {p.Name} | Price: ${p.Price} | Stock: {p.Stock}")
            //        );
            #endregion
            #region Task03
            //List<Product> catalog = new List<Product>
            //{
            //    new Product{Id=1,Name="Laptop",Category="Electronics",Price=1200,Stock=10},
            //    new Product{Id=2,Name="Phone",Category="Electronics",Price=800,Stock=25},
            //    new Product{Id=3,Name="T-shirt",Category="Clothing",Price=30,Stock=100},
            //    new Product{Id=4,Name="jeans",Category="Clothing",Price=60,Stock=50},
            //    new Product{Id=5,Name="Chocolate",Category="Food",Price=5,Stock=200},
            //    new Product{Id=6,Name="CoffeeBeans",Category="Food",Price=15,Stock=80},
            //    new Product{Id=7,Name="C#Book",Category="Books",Price=45,Stock=30},
            //    new Product{Id=8,Name="Novel",Category="Electronics",Price=20,Stock=60},
            //    new Product{Id=9,Name="HeadPhones",Category="Electronics",Price=150,Stock=40},
            //    new Product{Id=10,Name="Jacket",Category="Clothing",Price=120,Stock=15}
            //};


            //Console.WriteLine("=== Short Report ===");
            //Product.PrintReport(catalog, p =>
            //     Console.WriteLine($"{p.Name} - ${p.Price}")
            // );


            //Console.WriteLine("\n=== Detailed Report ===");
            //Product.PrintReport(catalog, p =>
            //    Console.WriteLine($"[{p.Category}] {p.Name} | Price: ${p.Price} | Stock: {p.Stock}")
            //);
            #endregion
        }
    }

}