using LibraryCoreStandard;
using LibraryEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFull
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** Console .NET Framework 4.8 **");
            Console.WriteLine("--------------------------------\n\n");

            var service = new CustomerService();
            service.Add(new Customer() { ID = 1, Name = "Carlos" });
            service.Add(new Customer() { ID = 2, Name = "John" });
            service.Add(new Customer() { ID = 3, Name = "Mary" });

            Console.WriteLine("Chamando a Library em .NET Standard");
            Console.WriteLine("-----------------------------------");
            foreach (var s in service.GetAll())
            {
                Console.WriteLine($"{s.ID} - {s.Name}");
            }

            var serviceEF = new CustomerServiceEF();
            Console.WriteLine("\n\n");
            Console.WriteLine("Chamando a Library com EF Core");
            Console.WriteLine("------------------------------");
            foreach (var s in serviceEF.GetAll())
            {
                Console.WriteLine($"{s.CustomerID} - {s.CompanyName}");
            }
        }
    }
}
