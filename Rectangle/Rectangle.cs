using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
Написать программу, читающую с консоли длину и ширину прямоугольника, и печатающую его площадь
• *Посчитайте и периметр
• Считать, что длина и ширина – вещественные числа
*/
namespace Geometry
{
    class Rectangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину:");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите ширину:");
            double width = Convert.ToDouble(Console.ReadLine());

            double area = width * length;
            double perimeter = length * 2 + width * 2;
            Console.WriteLine("Площадь = {0}, Периметр = {1}", area, perimeter);
        }
    }
}
