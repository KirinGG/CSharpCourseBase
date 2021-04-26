using System;

namespace NextDate
{
    class NextDate
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите день:");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите месяц:");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите год:");
            int year = Convert.ToInt32(Console.ReadLine());

            int maximumDay;

            if (month == 2)
            {
                bool isLeapYear = ((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0);
                maximumDay = isLeapYear ? 29 : 28;
            }
            else if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                maximumDay = 31;
            }
            else
            {
                maximumDay = 30;
            }
            
            const int maximumMonth = 12;

            if ((day > maximumDay) || (month > maximumMonth) || (day <= 0) || (month <= 0) || (year < 0))
            {
                Console.WriteLine("Введена некорректная дата: {0:d2}.{1:d2}.{2}.", day, month, year);
            }
            else
            {
                int nextDay = day + 1;
                int nextMonth = month;
                int nextYear = year;

                if (nextDay > maximumDay)
                {
                    nextDay = 1;
                    nextMonth++;
                }

                if (nextMonth > maximumMonth)
                {
                    nextMonth = 1;
                    nextYear++;
                }

                Console.WriteLine("Текущая дата: {0:d2}.{1:d2}.{2}; Следующая дата: {3:d2}.{4:d2}.{5}", day, month, year, nextDay, nextMonth, nextYear);
            }
        }
    }
}
