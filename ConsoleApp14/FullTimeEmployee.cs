using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp14
{
    internal class FullTimeEmployee:Employee
    {
        int VacationDays;

        public FullTimeEmployee(int Id,string Name,int Emekhaqqi,int vacationdays) : base(Id,Name,Emekhaqqi)
        {
            VacationDays= vacationdays;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"VacationDays {VacationDays}");
        }
    }
}
