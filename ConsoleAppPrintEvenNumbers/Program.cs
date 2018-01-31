using System;
using System.Linq;

namespace ConsoleAppPrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 96, 23 };

            var thatsEven = numbers.Where(n => n % 2 == 0);

            foreach (int i in thatsEven)
            {
                Console.WriteLine(i.ToString());
            }

            Console.ReadLine();
        }        
    }
}
