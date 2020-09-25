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
            Console.WriteLine("wat is je naam");
            var ingevuld = Console.ReadLine();
            if (ingevuld == "yoeri")
                Console.WriteLine($"Hallo {ingevuld}");
            else
                Console.WriteLine($"joejoe {ingevuld}");
            
            Console.WriteLine("wat doe je nu?");
            var volgende = Console.ReadLine();
            if (volgende == "aan school werken")
                Console.WriteLine($"{volgende} is goed");
            else
                Console.WriteLine($"{volgende} .ga aan school");
            Console.ReadLine();
        }
    }
}
