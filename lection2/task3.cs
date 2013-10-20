using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            int p;
            int s;

            Console.WriteLine("Enter a: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter b: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter c: ");
            c = int.Parse(Console.ReadLine());

            p = (a + b + c)/2;
            Console.WriteLine("p= {0}", p);

            s = (int)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("S= {0}",s);
            Console.ReadKey();


            
        }
    }
}
