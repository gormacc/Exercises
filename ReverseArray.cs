using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputOne = Console.ReadLine();
            var inputTwo = Console.ReadLine();

            if (int.TryParse(inputOne, out int length) == false)
            {
                return;
            }

            var array = new int[length];
            var i = 0;
            foreach (var value in inputTwo.Split(' '))
            {
                if (int.TryParse(value, out array[i++]) == false)
                {
                    return;
                }
            }

            Console.WriteLine();
            for (i = 0; i < length; i++)
            {
                Console.Write($"{array[length - 1 - i]} ");
            }
            Console.WriteLine();
        }
    }
}