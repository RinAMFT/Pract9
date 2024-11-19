using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayHello();
            SayBye();
            Console.Read();
        }
        public static void SayHello()
        {
            Console.WriteLine("Hello");
        }
        public static void SayBye()
        {
            Console.WriteLine("Bye");
        }

    }
}
