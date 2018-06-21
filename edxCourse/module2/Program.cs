using System;

namespace Mod2_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiates Employee Objects
            var employee1 = new Employee("Nate", 2000);
            var employee2 = new TechnicalEmployee("Mike");
            var employee3 = new BusinessEmployee("Jeremy");

            // Output to the console
            Console.WriteLine(employee1.employeeStatus() + "..." + employee2.employeeStatus() + "..." + employee3.employeeStatus());
        }
    }
}
