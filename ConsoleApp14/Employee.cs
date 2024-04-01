using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Employee
    {
        int Id;
        string Name;
        int Emekhaqqi;


        public Employee(int id,string name,int emekhaqqi)
        {
           this. Id=id;
           this. Name=name;
           this. Emekhaqqi=emekhaqqi;
            
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Id{Id}Name {Name}Emekhaqqi {Emekhaqqi}");
        }

    }
}
