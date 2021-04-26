using System;

namespace SearchElement
{
    class SearchElement
    {
        static void Main(string[] args)
        {
            double[] realNumbers = { 1.0, 2.0, 5.0, 3.0 };
            int findElementIndex = FindElement(realNumbers, 1.0);

            if (findElementIndex == -1)
            {
                Console.WriteLine("Элемент не найден!");
            }
            else
            {
                Console.WriteLine("Элемент найден под индексом = {0}", findElementIndex);
            }
        }

        public static int FindElement(double[] realNumbers, double element)
        {
            double epsilon = 1.0e-10;

            for (int i = 0; i < realNumbers.Length; i++)
            {
                if (Math.Abs(realNumbers[i] - element) <= epsilon)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
