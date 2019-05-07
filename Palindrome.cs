using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Console.WriteLine();

            var onlyLetters = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                var ascii = (byte)input[i];
                if (ascii >= 65 && ascii <= 90 || ascii >= 97 && ascii <= 122)
                {
                    onlyLetters += input[i].ToString().ToLower();
                }
            }

            var length = onlyLetters.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (onlyLetters[i] != onlyLetters[length - 1 - i])
                {
                    Console.WriteLine("NO");
                    return;
                }
            }
            Console.WriteLine("YES");
        }
    }
}