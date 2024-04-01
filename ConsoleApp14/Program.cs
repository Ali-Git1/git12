using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(1, "Valeh", 1000);

            employee.DisplayInfo();

            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee(2, "Namiq", 1100, 21);

            fullTimeEmployee.DisplayInfo();

            PartTimeEmployee partTimeEmployee = new PartTimeEmployee(48, 3, "Mehman", 1150);

            partTimeEmployee.DisplayInfo();

            Employee[] employees =
            {
                employee,
                fullTimeEmployee,
                partTimeEmployee

            };

            foreach (var item in employees)
            {
                item.DisplayInfo();
            }


        }
    }
}
