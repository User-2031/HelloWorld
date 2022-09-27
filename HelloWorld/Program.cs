using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS;
namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World !");
            Console.WriteLine("Today is Tuesday");
            Emp emp = new Emp { Id = 20, Name = "Tom", Salary = 40000 };
            Console.WriteLine($"{emp.Id} {emp.Name} {emp.Salary}");
            Console.WriteLine("Tomorrow is Wednesday");
        }
    }
}
