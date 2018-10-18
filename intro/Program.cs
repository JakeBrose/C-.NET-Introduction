using System;

namespace bangazon
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime purchaseDate=DateTime.Now;
            string lastName="Brose";
            var firstName="Jake";
            Console.WriteLine($"{firstName} {lastName} purchased on {purchaseDate}");
        }
    }
}