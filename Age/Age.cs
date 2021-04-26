using System;

/*
Программа просит ввести пользователя свой возраст от 1 до 112 включительно, после чего выводит сообщение «Вам x лет»
• При этом учесть, что для разных чисел разные склонения
• Например, «3 года», «99 лет» и т.д.
• Если введут слишком малое или слишком большое число,
то выведите, что «Вы слишком малы» или стары
• Старайтесь использовать логические связки, если это
возможно
*/

namespace Age
{
    class Age
    {
        static void Main(string[] args)
        {
            int maxAge = 112;
            int minAge = 1;

            Console.WriteLine("Введите возраст:");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < minAge)
            {
                Console.WriteLine("Вы слишком малы");
            }
            else if (age > maxAge)
            {
                Console.WriteLine("Вы слишком стары");
            }
            else
            {
                int lastDigits = age % 100;
                int lastDigit = age % 10;

                if ((lastDigits >= 11) && (lastDigits <= 19))
                {
                    Console.WriteLine("Вам {0} лет", age);
                }
                else if (lastDigit >= 2 && lastDigit <= 4)
                {
                    Console.WriteLine("Вам {0} года", age);
                }
                else if (lastDigit == 1)
                {
                    Console.WriteLine("Вам {0} год", age);
                }
                else
                {
                    Console.WriteLine("Вам {0} лет", age);
                }
            }
        }
    }
}
