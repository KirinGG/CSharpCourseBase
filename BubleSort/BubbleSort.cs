using System;

namespace BubbleSort
{
    class BubbleSort
    {
        static void Main(string[] args)
        {
            int[] numbersArray = { 1, -9, -9, 5, 4, 3, 7, 9, -9, 67, 1 };
            Sort(numbersArray);

            foreach (int e in numbersArray)
            {
                Console.Write("{0}, ", e);
            }
        }

        public static void Sort(int[] numbersArray)
        {
            for (int i = 0; i < numbersArray.Length - 1; i++)
            {
                bool isExchanged = false;

                for (int j = 1; j < numbersArray.Length - i; j++)
                {
                    if (numbersArray[j - 1] > numbersArray[j])
                    {
                        int temp = numbersArray[j - 1];
                        numbersArray[j - 1] = numbersArray[j];
                        numbersArray[j] = temp;
                        isExchanged = true;
                    }
                }

                if (!isExchanged)
                {
                    break;
                }
            }
        }
    }
}
