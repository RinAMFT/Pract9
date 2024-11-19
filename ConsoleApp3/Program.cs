using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        public static int Sum(int x, int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            Console.Write("x=");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y=");
            int y = int.Parse(Console.ReadLine());
            Console.ReadKey();

        }
    }
}
