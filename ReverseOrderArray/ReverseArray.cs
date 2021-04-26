using System;

namespace ReverseOrderArray
{
    class ReverseArray
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 5, 3, 4 };

            RearrangeItemsInReverseOrder(numbers);
            Console.WriteLine(string.Join(", ", numbers));
        }

        public static void RearrangeItemsInReverseOrder(int[] numbers)
        {
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                int j = numbers.Length - (i + 1);
                int temp = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = temp;
            }
        }
    }
}
