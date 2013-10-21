using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            int sum1;
            int sum2;
            int sum3;

            Console.WriteLine("Enter a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter c: ");
            c = int.Parse(Console.ReadLine());

            sum1= b + c;
            sum2= a + c;
            sum3= a + b;


            if (sum1 > a && sum2 > b && sum3 > c) 
            { 
                
                Console.WriteLine("IT IS POSSIBLE TO FORM A TRIANGLE");
                
                if (a == b && b == c) { Console.WriteLine("RAVNOSTRANEN"); }
                
                else if (a == b || b == c || a == c) { Console.WriteLine("RAVNOBEDREN"); }
                
                else { Console.WriteLine("RAZNOSTRANEN"); }
            }

            else { Console.WriteLine("IT'S NOT POSSIBLE TO FORM A TRIANGLE"); }

            
        }
    }
}
