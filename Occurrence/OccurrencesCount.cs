using System;
using System.IO;
/*
Прочитать текст из файла, и написать функцию, которая считает количество вхождений некоторой строки в этот текст без учета регистра символов
•
Использовать цикл и IndexOf, который принимает начальный индекс, с которого искать
*/
namespace Lesson_12
{
    class OccurrencesCount
    {
        static void Main(string[] args)
        {
            string searchWord = "может";
            int occurrencesCount = 0;

            using (StreamReader reader = new StreamReader(("..\\..\\..\\In.txt")))
            {
                string currentLine;

                while ((currentLine = reader.ReadLine()) != null)
                {
                    occurrencesCount += GetOccurrencesCount(currentLine, searchWord);
                }
            }

            Console.WriteLine("'{0}' входит в текст {1} раз.", searchWord, occurrencesCount);
        }

        public static int GetOccurrencesCount(string line, string searchWord)
        {
            int startIndex = 0;
            int occurrencesCount = 0;

            line = line.ToUpper();
            searchWord = searchWord.ToUpper();

            while (true)
            {
                startIndex = line.IndexOf(searchWord, startIndex);

                if (startIndex == -1)
                {
                    break;
                }

                occurrencesCount++;
                startIndex += searchWord.Length;
            }

            return occurrencesCount;
        }
    }
}