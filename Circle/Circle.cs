using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 Написать программу, которая вычисляет и печатает:
 • Площадь круга и длину окружности с заданным радиусом. Значение радиуса задать самим в тексте программы
 • Посчитать радиус окружности с заданной площадью круга. Значение площади задать самим в тексте программы
 • * Посчитать площадь сектора с заданными радиусом и углом в градусах. Значения радиуса и угла задать в тексте программы
 • Использовать класс Math: возведение в степень, квадратный корень, константа Пи и др.
 • Имена переменных должны быть хорошими, не ориентируемся на математические обозначения
*/
namespace Geometry
{
    class Circle
    {
        static void Main(string[] args)
        {
            double radius = 5.0;
            double angle = 30.0;

            double circleArea = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("The area of a circle with a radius " + radius + " is " + circleArea);

            double circleLength = 2 * Math.PI * radius;
            Console.WriteLine("The length of a circle with radius " + radius + " is " + circleLength);

            double circleRadius = Math.Sqrt(circleArea / Math.PI);
            Console.WriteLine("The radius of a circle with area " + circleArea + " is " + circleRadius);

            double sectorArea = Math.PI * Math.Pow(radius, 2) * angle / 360;
            Console.WriteLine("the area of a sector with radius " + radius + " and angle " + angle + " is " + sectorArea);
        }
    }
}
