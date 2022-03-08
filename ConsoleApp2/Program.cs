using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the seed");
            int seed = int.Parse(Console.ReadLine());
            Problem problem = new Problem(n, seed);                       
        }
    }
}
