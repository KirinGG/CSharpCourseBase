using System;

namespace Array
{
    class Array
    {
        static void Main(string[] args)
        {

            int[] array = new int[100];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }

            foreach (int e in array)
            {
                Console.WriteLine("Элемент массива = {0}.", e);
            }
        }
    }
}
