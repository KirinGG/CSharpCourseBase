using System;

/*
Прочитать с консоли год и вывести в консоль, является он високосным или нет
• Старайтесь использовать логические связки, если это возможно
*/
namespace LeapYear
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год:");
            int year = Convert.ToInt32(Console.ReadLine());

            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                Console.WriteLine("{0} год - високосный.", year);
            }
            else
            {
                Console.WriteLine("{0} год - обычный.", year);
            }
        }
    }
}
