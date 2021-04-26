using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLesson2Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вывести при помощи одного вызова Console.WriteLine сразу несколько строк при помощи перевода строки
            Console.WriteLine("Строка 1 " + Environment.NewLine + "Строка 2");

            /* Вывести следующие строки:
               “30” августа 2014г.
               C:\Windows\System32\Drivers\etc\hosts */
            Console.WriteLine("\"30\" августа 2014г.");
            Console.WriteLine("C:\\Windows\\System32\\Drivers\\etc\\hosts");

            // Посчитать некоторое выражение и распечатать его результат в виде строки. 
            Console.WriteLine("Результат = " + 3 * 5);

            /* Попрактиковаться с арифметическими операторами:
               сделать по 1 примеру для каждого оператора для целых
               чисел и для вещественных чисел, вывести результат в консоль
                • Операторы: + - * / %
                • Проверить как работает целочисленное и вещественное деление */
            int a = 3;
            int b = 5;

            Console.WriteLine("a + b = " + (a + b));
            Console.WriteLine("a + b = " + ((double)a + (double)b));

            Console.WriteLine("a - b = " + (a - b));
            Console.WriteLine("a - b = " + ((double)a - (double)b));

            Console.WriteLine("a * b = " + (a * b));
            Console.WriteLine("a * b = " + ((double)a * (double)b));

            Console.WriteLine("a / b = " + (a / b));
            Console.WriteLine("a / b = " + ((double)a / (double)b));

            Console.WriteLine("a % b = " + (a % b));
            Console.WriteLine("a % b = " + ((double)a % (double)b));

            double x = 3 - (56 - 12) / 44 * 4 / 2;
            double y = (2 * x) / (33 - x);
            double z = -x / 2 * y;

            Console.WriteLine("x = " + x + "; y = " + y + "; z = " + z);

            /* Написать программу, которая вычисляет и печатает площадь круга с радиусом r.
               • Значение r задать самим в тексте программы
               • Использовать класс Math: тригонометрические функции, возведение в степень, квадратный корень, константа Пи и др.*/

            double radius = 5.0;
            double angle = 30.0;
            double areaOfCircle = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine("The area of a circle with a radius " + radius + " is " + areaOfCircle);

            /* Написать программу, которая вычисляет и печатает:
                • Площадь круга и длину окружности с заданным радиусом. Значение радиуса задать самим в тексте программы
                • Посчитать радиус окружности с заданной площадью круга. Значение площади задать самим в тексте программы
                • * Посчитать площадь сектора с заданными радиусом и углом в градусах. Значения радиуса и угла задать в тексте программы
                • Использовать класс Math: возведение в степень, квадратный корень, константа Пи и др.
                • Имена переменных должны быть хорошими, не ориентируемся на математические обозначения*/
            double lengthOfCircle = 2 * Math.PI * radius;

            Console.WriteLine("The length of a circle with radius " + radius + " is " + lengthOfCircle);

            radius = Math.Sqrt(areaOfCircle / Math.PI);

            Console.WriteLine("The radius of a circle with area " + areaOfCircle + " is " + radius);

            double areaOfSector = Math.PI * Math.Pow(radius, 2) * angle / 360;
            Console.WriteLine("the area of a sector with radius " + radius + " and angle " + angle + " is " + areaOfSector);

            Console.ReadLine();
        }
    }
}
