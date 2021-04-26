using System;
/*
Написать функцию, которая ищет в строке подстроку максимальной длины, состоящую из одного и того же символа, и выдает эту максимальную длину
• Например, есть строка "аааббдеггггв", должно выдаться число 4, потому что есть 4 подряд символа «г», и это максимальная подстрока, где подряд идет один и тот же символ
• Функция должна работать без учета регистра
 */
namespace Substring
{
    class Substring
    {
        static void Main(string[] args)
        {
            string line = "аааббдеггггв";
            Console.WriteLine("В строке - '{0}', длина максимальной подстроки - {1}", line, GetMaximumDuplicateSubstringLength(line));
        }

        public static int GetMaximumDuplicateSubstringLength(string originalString)
        {
            if (originalString.Length == 0)
            {
                return 0;
            }

            int substringCurrentLength = 0;
            int substringMaximumLength = 1;

            for (int i = 1; i < originalString.Length; i++)
            {
                if (char.ToLower(originalString[i]) == char.ToLower(originalString[i - 1]))
                {
                    substringCurrentLength++;
                }
                else if (substringCurrentLength > substringMaximumLength)
                {
                    substringMaximumLength = substringCurrentLength;
                    substringCurrentLength = 0;
                }
            }

            if (substringCurrentLength >= substringMaximumLength)
            {
                substringCurrentLength++;
                substringMaximumLength = substringCurrentLength;
            }

            return substringMaximumLength;
        }
    }
}
