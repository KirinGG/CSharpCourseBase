using System;
/*
 Написать функцию, которая принимает массив строк и изменяет его, присваивая элементам эти же строки, но в которых все символы заглавные
• Для этого использовать метод класса string ToUpper()
• Пример вызова ToUpper для строки:
    string s = “hello”;
    string b = s.ToUpper(); // “HELLO” 
 */
namespace StringArrayToUpper
{
    class StringArray
    {
        static void Main(string[] args)
        {
            string[] stringsArray = { "строка1", "строка2", "строка3" };

            Console.WriteLine("Исходный массив строк:");
            Console.WriteLine(string.Join(", ", stringsArray));

            ConvertStringsArrayToUpperCase(stringsArray);

            Console.WriteLine("Измененный массив строк:");
            Console.WriteLine(string.Join(", ", stringsArray));
        }

        public static void ConvertStringsArrayToUpperCase(string[] stringsArray)
        {
            for (int i = 0; i < stringsArray.Length; i++)
            {
                stringsArray[i] = stringsArray[i].ToUpper();
            }
        }
    }
}
