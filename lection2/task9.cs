using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task9
{
    class Program
    {
        static void Main(string[] args)
        {
            int name;

            Console.WriteLine("Enter a digit from 1 to 7.");
            name = int.Parse(Console.ReadLine());

            switch (name)
            {
                case 1: Console.WriteLine("Name of the day: Monday"); break;
                case 2: Console.WriteLine("Name of the day: Tuesday"); break;
                case 3: Console.WriteLine("Name of the day: Wednesday"); break;
                case 4: Console.WriteLine("Name of the day: Thursday"); break;
                case 5: Console.WriteLine("Name of the day: Friday"); break;
                case 6: Console.WriteLine("Name of the day: Saturday"); break;
                case 7: Console.WriteLine("Name of the day: Sunday"); break;
            }

        }
    }
}
