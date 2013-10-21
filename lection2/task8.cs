using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            double d;
            double x1;
            double x2;

            Console.WriteLine("Enter a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter c: ");
            c = double.Parse(Console.ReadLine());

            Console.WriteLine("{0}*x^2 + {1}*b + {2} = 0", a, b, c);
            
            d = b * b - 4 * a * c;
            x1 = (-b + Math.Sqrt(d)) / (a*2);
            x2 = (-b - Math.Sqrt(d)) / (a*2);

            Console.WriteLine("X1= {0} and X2= {1}", x1, x2);
            
        }
    }
}
