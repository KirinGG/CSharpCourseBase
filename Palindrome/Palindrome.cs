using System;
/*
 Объявить некоторую строковую переменную в программе
• Проверить, что данная строка является палиндромом – то есть читается одинаково слева направо и справа налево.
• При проверке не учитывать регистр символов, учитывать только буквы
• Пример палиндрома: «Аргентина манит негра»
• Требование: cделать без создания новой строки и без удаления символов из строки
 */
namespace Palindrome
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            string verifiableString = "Аргентина манит негра";

            if (IsPalindrome(verifiableString))
            {
                Console.WriteLine("Слово - '{0}' это палиндром.", verifiableString);
            }
            else
            {
                Console.WriteLine("Слово - '{0}' это не палиндром.", verifiableString);
            }
        }

        static bool IsPalindrome(string verifiableString)
        {
            int i = 0;
            int j = verifiableString.Length - 1;

            while (i <= j)
            {
                while (!char.IsLetter(verifiableString[i]) && i < j)
                {
                    i++;
                }

                while (!char.IsLetter(verifiableString[j]) && j > i)
                {
                    j--;
                }

                if (char.ToLower(verifiableString[i]) != char.ToLower(verifiableString[j]))
                {
                    return false;
                }

                i++;
                j--;
            }

            return true;
        }
    }
}
