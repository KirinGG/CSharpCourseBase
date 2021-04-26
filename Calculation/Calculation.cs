using System;

namespace Calculation
{
    class Calculation
    {
        static void Main(string[] args)
        {
            double x = 3 - (56 - 12) / 44 * 4 / 2;
            double y = 2 * x / (33 - x);
            double z = -x / (2 * y);

            Console.WriteLine("x = {0}; y = {1}; z = {2}", x, y, z);
        }
    }
}

