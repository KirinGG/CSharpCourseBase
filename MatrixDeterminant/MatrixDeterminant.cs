using System;

namespace MatrixDeterminant
{
    class MatrixDeterminant
    {
        static void Main(string[] args)
        {
            double[,] matrix = { { 4, 6, -2, 4 }, { 1, 2, -3, 1 }, { 4, -2, 1, 0 }, { 6, 4, 4, 6 } }; // -144
            int size = matrix.GetLength(0);

            for(int i = 0; i< size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    Console.Write(" " + matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            GetMinor(matrix);

       
        }

        public static void GetMinor(double[,] matrix)
        {
            double[,] newMatrix = new double[matrix.GetLength(0) - 1, matrix.GetLength(0) - 1];

            if(matrix.GetLength(0) - 1 == 2)
            {
                Console.WriteLine(newMatrix[0, 0] * newMatrix[1, 1] - newMatrix[0, 1] * newMatrix[1, 0]);
                return;
            }

            for (int k = 0; k < matrix.GetLength(0); k++)
            {
                double coefficient = Math.Pow(-1, 1 + k) * matrix[0, k];

                // Заполнение матрицы
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (i == k)
                    {
                        continue;
                    }

                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (j == i)
                        {
                            continue;
                        }
                        Console.Write(" " + matrix[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            //return 1.0;
        }
    }
}