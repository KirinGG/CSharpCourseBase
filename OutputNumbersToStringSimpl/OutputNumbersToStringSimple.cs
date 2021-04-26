using System;

namespace OutputNumbersToStringSimpl
{
    class OutputNumbersToStringSimple
    {
        static void Main(string[] args)
        {
            const int lineLength = 10;
            const int numbersCount = 100;
            int i = 1;

            while (i <= numbersCount)
            {
                Console.Write("{0,4}", i);

                if (i % lineLength == 0)
                {
                    Console.WriteLine();
                }

                i++;
            }
        }
    }
}
