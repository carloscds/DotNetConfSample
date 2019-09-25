using LibraryCoreStandard;
using LibraryEF;
using System;

namespace ConsoleCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a Console .NET Core 3");
            Console.WriteLine("*****************************\n\n");
            var service = new CustomerService();
            service.Add(new Customer() { ID = 1, Name = "Carlos" });
            service.Add(new Customer() { ID = 2, Name = "John" });
            service.Add(new Customer() { ID = 3, Name = "Mary" });

            Console.WriteLine("Calling Library from .NET Standard 2");
            Console.WriteLine("------------------------------------");
            foreach (var s in service.GetAll())
            {
                Console.WriteLine($"{s.ID} - {s.Name}");
            }

            var serviceEF = new CustomerServiceEF();
            Console.WriteLine("\n\nCalling Library with EF Core");
            Console.WriteLine("----------------------------");
            foreach (var s in serviceEF.GetAll())
            {
                Console.WriteLine($"{s.CustomerID} - {s.CompanyName}");
            }
        }
    }
}
