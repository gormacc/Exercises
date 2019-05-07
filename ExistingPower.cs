using System;
using System.Collections.Generic;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var powers = new List<int>();
            while (true)
            {
                var input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                if (int.TryParse(input, out int result) == false)
                {
                    return;
                }

                Decompose(result, powers);
            }

            if (powers.Count == 0)
            {
                Console.WriteLine("NA");
            }
            else
            {
                Console.WriteLine(string.Join(", ", powers));
            }
        }

        private static void Decompose(int number, List<int> powers)
        {
            if(number == 0) return;

            while (true)
            {
                if (powers.Count == 0)
                {
                    powers.Add(1);
                    continue;
                }

                if (number - powers[powers.Count - 1] >= powers[powers.Count - 1])
                {
                    powers.Add(powers[powers.Count - 1] * 2);
                }
                else
                {
                    break;
                }
            }

            var index = 0;
            while (true)
            {
                if (number - powers[index] < powers[index])
                {
                    break;
                }

                index++;
            }

            while (number > 0 && index >= 0)
            {
                number -= powers[index--];
            }
        }
    }
}
