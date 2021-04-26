using System;

namespace FunctionPrintAndRead
{
    class FunctionPrintAndRead
    {
        public static int PrintAndRead(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            int number1 = PrintAndRead("Введите первое число:");
            int number2 = PrintAndRead("Введите второе число:");
            Console.WriteLine("Первое число = {0}; Второе число = {1}", number1, number2);
        }
    }
}
