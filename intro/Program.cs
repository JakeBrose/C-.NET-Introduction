using System;

namespace bangazon
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------ 
            DateTime purchaseDate=DateTime.Now;
            string lastName="Brose";
            var firstName="Jake";
            Console.WriteLine($"{firstName} {lastName} purchased on {purchaseDate}");
            // ------

            // ------
            string[] products = new string[] {
                "Motorcycle",
                "Sofa",
                "Sandals",
                "Omega Watch",
                "iPhone"
            };
            foreach (string product in products) {
                Console.WriteLine(product);
            };
            foreach (string product in products) {
                if (product.Length > 5) {
                    Console.WriteLine(product);
                }
            };
            // ------
        }
    }
}