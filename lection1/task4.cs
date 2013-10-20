using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int number3;

            Console.WriteLine("Enter number 1: ");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2: ");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Before switch: number 1= {0} and number 2= {1}.", number1, number2);
            
            number3 = number1;
            number1 = number2;
            number2 = number3;
            
            Console.WriteLine("After switch: number 1= {0} and number 2= {1}.", number1, number2);
            Console.ReadKey();
        }
    }
}
