using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class PartTimeEmployee:Employee
    {
        int HoursWorked;

        public PartTimeEmployee(int hourseworked, int Id, string Name, int Emekhaqqi):base(Id,Name, Emekhaqqi) 
        {
            HoursWorked= hourseworked;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine(HoursWorked);
        }
    }
}
