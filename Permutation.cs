using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputOne = Console.ReadLine();
            var inputTwo = Console.ReadLine();

            var arrayOne = new int[11];
            var inputOneElements = inputOne.Split(' ');
            if (inputOneElements.Length != 11) return;
            for (var i = 0; i < 11; i++)
            {
                if (int.TryParse(inputOneElements[i], out arrayOne[i]) == false)
                {
                    return;
                }
            }

            var arrayTwo = new int[11];
            var inputTwoElements = inputTwo.Split(' ');
            if (inputTwoElements.Length != 11) return;
            for (var i = 0; i < 11; i++)
            {
                if (int.TryParse(inputTwoElements[i], out arrayTwo[i]) == false)
                {
                    return;
                }
            }

            Console.WriteLine();

            var chosen = new bool[11];

            for (int i = 0; i < 11; i++)
            {
                var elem = arrayOne[i];
                var exist = false;

                for (int j = 0; j < 11; j++)
                {
                    if (arrayTwo[j] == elem && chosen[j] == false)
                    {
                        chosen[j] = true;
                        exist = true;
                        break;
                    }
                }

                if (exist == false)
                {
                    Console.WriteLine("NO");
                    return;
                }
            }

            Console.WriteLine("YES");
        }
    }
}