using System;
/*
Прочитать с консоли три числа – два операнда и код команды
• Код команды должен быть от 1 до 4
• Если он равен 1, то выполнить сложение первых двух
чисел. Если 2, то вычитание, если 3, то умножение, если 4,
то деление.
• Если ввели число не от 1 до 4, то вывести, что неизвестная
операция
• Использовать switch 
 */

namespace ExecuteCommand
{
    class ExecuteCommand
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите код команды:");
            int commandCode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите первый операнд:");
            double operand1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второй операнд:");
            double operand2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;
            bool isCommandCorrectly = true;

            switch (commandCode)
            {
                case 1:
                    result = operand1 + operand2;
                    break;
                case 2:
                    result = operand1 - operand2;
                    break;
                case 3:
                    result = operand1 * operand2;
                    break;
                case 4:
                    result = operand1 / operand2;
                    break;
                default:
                    isCommandCorrectly = false;
                    break;
            }

            if (isCommandCorrectly)
            {
                Console.WriteLine("Результат операции = {0}", result);
            }
            else
            {
                Console.WriteLine("Выбрана неизвестная операция!");
            }
        }
    }
}
