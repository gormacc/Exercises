using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = Console.ReadLine();
            var input = Console.ReadLine();

            int maxSum = 0;
            int maxIndex = 0;
            int currSum = 0;
            int index = 0;

            input += " ";
            var length = input.Length;
            for (int i = 0; i < length; i++)
            {
                var ascii = (byte)input[i];
                if (ascii >= 48 && ascii <= 57)
                {
                    currSum += ascii - 48;
                }
                else
                {
                    if (currSum >= maxSum)
                    {
                        maxSum = currSum;
                        maxIndex = index;
                    }

                    currSum = 0;
                    index += 1;
                }
            }

            Console.WriteLine(maxIndex);
        }
    }
}