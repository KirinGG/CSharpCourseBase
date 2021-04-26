using System;

namespace StringSplitting
{
    class StringSplitting
    {
        static void Main(string[] args)
        {
            string line = "1, 2, 3, 4, 5";
            int sum = 0;
            string[] numbers = line.Split(",");

            foreach (string e in numbers)
            {
                sum += Convert.ToInt32(e);
            }

            Console.WriteLine("Сумма = {0}", sum);
        }
    }
}