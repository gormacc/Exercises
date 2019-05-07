using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = Console.ReadLine();
            var input = Console.ReadLine();

            var counter = new int[10];

            var length = input.Length;
            for (int i = 0; i < length; i++)
            {
                var ascii = (byte)input[i];
                if (ascii >= 48 && ascii <= 57)
                {
                    counter[ascii - 48]++;
                }
            }

            int maxDigit = -1;
            int maxCount = -1;
            for (int i = 0; i < 10; i++)
            {
                if (maxCount <= counter[i])
                {
                    maxDigit = i;
                    maxCount = counter[i];
                }
            }

            Console.WriteLine(maxDigit);
        }
    }
}