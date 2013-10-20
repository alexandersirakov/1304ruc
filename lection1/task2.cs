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
            int number1;
            int number2;
            int number3;
            int sum; 

            Console.WriteLine("Enter the first number: ");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second numebr: ");
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            number3=int.Parse(Console.ReadLine());

            sum=number1+number2+number3;

            Console.WriteLine("The sum of the numbers is: {0}.", sum);

        }
    }
}
