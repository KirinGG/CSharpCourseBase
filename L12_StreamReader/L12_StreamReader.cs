using System;
using System.IO;

namespace Lesson
{
    class L12_StreamReader
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("..\\..\\..\\input.txt"))
            {

                string line = sr.ReadLine();
                string[] numbersString = line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                double[] numbers = new double[numbersString.Length];

                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = Convert.ToDouble(numbersString[i]);
                }

                Console.Write(string.Join(";", numbers));
            }
        }
    }
}
