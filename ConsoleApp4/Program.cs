using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static double Func(int x)
        {
            return 12 * (Math.Pow(x, 2)) + 7 * x - 6;
        }

        static void Main(string[] args)
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine($"b={Func(a):f2}");
            Console.ReadKey();
        }
    }
}
