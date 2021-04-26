using System;

namespace Example
{
    class Example
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("Число положительное");
            }
            else if (number < 0)
            {
                Console.WriteLine("Число отрицательное");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
