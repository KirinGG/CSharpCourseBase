using System;

namespace CharCheck
{
    class CharCheck
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку для анализа:");
            string inputLine = Console.ReadLine();

            int digitsCount = 0;
            int lettersCount = 0;
            int whitespacesCount = 0;
            int otherCharsCount = 0;

            for (int i = 0; i < inputLine.Length; i++)
            {
                if (char.IsDigit(inputLine[i]))
                {
                    digitsCount++;
                }
                else if (char.IsLetter(inputLine[i]))
                {
                    lettersCount++;
                }
                else if (char.IsWhiteSpace(inputLine[i]))
                {
                    whitespacesCount++;
                }
                else
                {
                    otherCharsCount++;
                }
            }

            Console.WriteLine("В строке {0} букв, {1} цифр, {2} пробела и {3} прочих символа", lettersCount, digitsCount, whitespacesCount, otherCharsCount);
        }
    }
}
