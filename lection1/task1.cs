using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fisrtName;
            string secondName;
            string thirdName;

            Console.WriteLine("Insert first name: ");
            fisrtName = Console.ReadLine();
            Console.WriteLine("Insert second name: ");
            secondName = Console.ReadLine();
            Console.WriteLine("Insert third name: ");
            thirdName = Console.ReadLine();

            Console.WriteLine("Greetings {0}, {1} and {2}", fisrtName, secondName, thirdName);
        }
    }
}
