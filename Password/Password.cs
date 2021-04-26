using System;
/*
 *В программе объявить строковую переменную, хранящую
пароль
• С консоли прочитать строку, сравнить её с этим паролем.
Если строка совпала, то выдать сообщение, что пароль
верный
• Если строка не совпала с паролем, и её длина
(использовать Length) больше длины пароля, то сказать что
пароль неверный и строка слишком длинная
• Если строка не совпала с паролем, и её длина меньше, то
сказать, что пароль неверный строка слишком короткая
• Иначе сказать, что пароль неверный
 */
namespace Password
{
    class Password
    {
        static void Main(string[] args)
        {
            string originalPassword = "pwd";

            Console.WriteLine("Введите пароль:");
            string verifiablePassword = Console.ReadLine();

            if (verifiablePassword.Equals(originalPassword))
            {
                Console.WriteLine("Введен верный пароль.");
            }
            else
            {
                if (originalPassword.Length == verifiablePassword.Length)
                {
                    Console.WriteLine("Введен неверный пароль!");
                }
                else if (originalPassword.Length < verifiablePassword.Length) 
                {
                    Console.WriteLine("Длина введеного пароля больше!");
                }
                else 
                {
                    Console.WriteLine("Длина введеного пароля меньше!");
                }
            }
        }
    }
}
