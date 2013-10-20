using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double h;
            double s;

            Console.WriteLine("Enter a: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter b: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter h: ");
            h = int.Parse(Console.ReadLine());

            s = ((a + b) / 2) * h;
            Console.WriteLine("S= {0}", s);
            Console.ReadKey();


        }
    }
}
