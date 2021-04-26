using System;

namespace MultiplicationTable
{
    class MultiplicationTable
    {
        static void Main(string[] args)
        {
            const int rowsCount = 10;
            const int columnsCount = 10;
            int numberLength = Convert.ToString(rowsCount * columnsCount).Length;

            string formatString = "{0," + numberLength + ":#.#} | ";
            string separatorString = "-";

            for (int i = 1; i <= (numberLength + 2); i++)
            {
                separatorString += "-";
            }

            for (int j = 0; j <= columnsCount; j++)
            {
                Console.Write(formatString, j);
            }
            
            Console.WriteLine();
            
            for (int i = 1; i <= rowsCount; i++)
            {
                for (int j = 0; j <= columnsCount; j++)
                {
                    Console.Write(separatorString);
                }

                Console.Write(Environment.NewLine + formatString, i);

                for (int j = 1; j <= columnsCount; j++)
                {
                    Console.Write(formatString, i * j);
                }

                Console.WriteLine();
            }
        }
    }
}
