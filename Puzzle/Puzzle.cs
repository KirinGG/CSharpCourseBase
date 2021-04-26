using System;

namespace Puzzle
{
    class Puzzle
    {
        static void Main(string[] args)
        {
            string puzzleWord = "Слово";
            puzzleWord = puzzleWord.ToLower();

            while (true)
            {
                Console.WriteLine("Введите загаданное слово:");
                string inputWord = Console.ReadLine().ToLower();

                if (inputWord.Equals(puzzleWord))
                {
                    Console.WriteLine("Угадали!");
                    break;
                }

                Console.WriteLine("Не угодали. Попробуйте ещё раз!");
            }
        }
    }
}
