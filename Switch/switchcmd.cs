using System;

namespace switchcmd
{
    class switchcmd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите команду >>");
            string cmd = Console.ReadLine();

            switch (cmd)
            {
                case "print":
                    Console.WriteLine("Введите строку для вывода:");
                    string inputString = Console.ReadLine();

                    Console.WriteLine("Введенная строка - {0}", inputString);
                    break;
                case "sum":
                    Console.WriteLine("Введите первое число:");
                    double number1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите второе число:");
                    double number2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("a + b = " + (number1 + number2));
                    break;
                default:
                    Console.WriteLine("Неизвестная команда");
                    break;
            }
        }
    }
}
