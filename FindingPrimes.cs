using System;
using System.Collections.Generic;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            if (int.TryParse(input, out int count) == false)
            {
                return;
            }

            var outputs = new List<int>();

            for (int i = 0; i < count; i++)
            {
                input = Console.ReadLine();
                var range = input.Split(' ');
                if (range.Length != 2)
                {
                    return;
                }

                if (int.TryParse(range[0], out int m) == false)
                {
                    return;
                }

                if (int.TryParse(range[1], out int n) == false)
                {
                    return;
                }

                outputs.Add(PrimeNumbersCount(m, n));
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(outputs[i]);
            }
        }

        private static int PrimeNumbersCount(int m, int n)
        {
            int counter = 0;
            for (int i = m; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    counter++;
                }
            }

            return counter;
        }

        private static bool IsPrime(int number)
        {
            if (number == 0 || number == 1) return false;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}