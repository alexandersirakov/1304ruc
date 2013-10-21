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

            Console.WriteLine("Enter a digit: ");
            name = int.Parse(Console.ReadLine());

            switch (name)
            {
                case 0: Console.WriteLine("Name of digit: ZERO "); break;
                case 1: Console.WriteLine("Name of digit: ONE "); break;
                case 2: Console.WriteLine("Name of digit: TWO "); break;
                case 3: Console.WriteLine("Name of digit: THREE "); break;
                case 4: Console.WriteLine("Name of digit: FOUR "); break;
                case 5: Console.WriteLine("Name of digit: FIVE"); break;
                case 6: Console.WriteLine("Name of digit: SIX "); break;
                case 7: Console.WriteLine("Name of digit: SEVEN "); break;
                case 8: Console.WriteLine("Name of digit: NINE "); break;
                case 9: Console.WriteLine("Name of digit: TEN "); break;

            }

        }
    }
}
