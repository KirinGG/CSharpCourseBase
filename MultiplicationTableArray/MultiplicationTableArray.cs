using System;
/*
Написать функцию, которая создает двумерный массив с таблицей умножения
• Размер таблицы должен быть параметром функции
• Вызвать функцию и распечатать результат в Main
*/
namespace MultiplicationTableArray
{
    class MultiplicationTableArray
    {
        static void Main(string[] args)
        {
            int[,] multiplicationTable = CreateMultiplicationTableArray(5, 5);
            PrintMultiplicationTableArray(multiplicationTable);
        }

        public static int[,] CreateMultiplicationTableArray(int rows, int columns)
        {
            int[,] multiplicationTable = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    multiplicationTable[i, j] = (i + 1) * (j + 1);
                }
            }

            return multiplicationTable;
        }

        public static void PrintMultiplicationTableArray(int[,] multiplicationTableArray)
        {
            int rowsCount = multiplicationTableArray.GetLength(0);
            int columnsCount = multiplicationTableArray.GetLength(1);
            int numberLength = Convert.ToString(rowsCount * columnsCount).Length;

            string formatString = "{0," + numberLength + ":#.#} | ";
            int i = 0;

            foreach (int e in multiplicationTableArray)
            {
                Console.Write(formatString, e);
                i++;

                if (i % columnsCount == 0)
                {
                    i = 0;
                    Console.WriteLine();
                }
            }
        }
    }
}