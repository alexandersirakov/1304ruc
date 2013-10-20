using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int number1;
            int number2;
            int number3;
            int number4;
            int number5;

            Console.WriteLine("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            
            number1 = number % 10;
            number2 = (number % 100) / 10;
            number3 = (number % 1000) / 100;
            number4 = (number % 10000) / 1000;
            number5 = (number % 100000) / 10000;
            
            Console.WriteLine("The inverted number is: {0}{1}{2}{3}{4}", number1, number2, number3, number4, number5);
            Console.WriteLine("The sum of the number's digits is: {0}", number1+number2+number3+number4+number5);
            Console.WriteLine("Number/sum= {0}", number / (number1 + number2 + number3 + number4 + number5));
            Console.WriteLine("Invert second and third digits of the inverted number: {0}{1}{2}{3}{4}", number1, number3, number2, number4, number5);

            Console.ReadKey();
         }
    }
}
