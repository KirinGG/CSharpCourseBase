using System;

/*
 Объявить в классе несколько функций с именем GetTypeSize
• Каждая функция должна принимать один аргумент одного из следующих типов: byte, short, int, long, float, double
• Функция должна возвращать int – количество байт, требуемых под переменную данного типа
• В функции Main сделать по одному примеру использования для каждой перегруженной функции
 */

namespace Overload
{
    class Overload
    {
        static void Main(string[] args)
        {
            byte variable1 = 1;
            short variable2 = 1;
            int variable3 = 1;
            long variable4 = 1;
            float variable5 = 1;
            double variable6 = 1;

            string template = "Для хранения переменной с типом {0}, значение которой {1}, требуется {2} байт";
            Console.WriteLine(template, variable1.GetType(), variable1, GetTypeSize(variable1));
            Console.WriteLine(template, variable2.GetType(), variable2, GetTypeSize(variable2));
            Console.WriteLine(template, variable3.GetType(), variable3, GetTypeSize(variable3));
            Console.WriteLine(template, variable4.GetType(), variable4, GetTypeSize(variable4));
            Console.WriteLine(template, variable5.GetType(), variable5, GetTypeSize(variable5));
            Console.WriteLine(template, variable6.GetType(), variable6, GetTypeSize(variable6));
        }
        
        public static int GetTypeSize(byte variable)
        {
            return 1;
        }
        
        public static int GetTypeSize(short variable)
        {
            return 2;
        }
        
        public static int GetTypeSize(int variable)
        {
            return 4;
        }
        
        public static int GetTypeSize(long variable)
        {
            return 8;
        }
        
        public static int GetTypeSize(float variable)
        {
            return 4;
        }
        
        public static int GetTypeSize(double variable)
        {
            return 8;
        }
    }
}
