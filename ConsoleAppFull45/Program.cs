using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryCoreStandard;

namespace ConsoleAppFull45
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a Console .NET 4.5.2");
            Console.WriteLine("****************************\n\n");
            var service = new CustomerService();
            service.Add(new Customer() { ID = 1, Name = "Carlos" });
            service.Add(new Customer() { ID = 2, Name = "John" });
            service.Add(new Customer() { ID = 3, Name = "Mary" });

            Console.WriteLine("Calling Library from .NET Standard Project with .NET 4.5.2");
            Console.WriteLine("----------------------------------------------------------");
            foreach (var s in service.GetAll())
            {
                Console.WriteLine($"{s.ID} - {s.Name}");
            }
        }
    }
}
