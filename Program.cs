using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsole
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("hello world");
            Console.WriteLine("hello class");
            Console.WriteLine("wat is uw naam?");
            var ingevuld = Console.ReadLine();
            Console.WriteLine($"hallo {ingevuld}");
            Console.ReadLine();

        }
    }
}
