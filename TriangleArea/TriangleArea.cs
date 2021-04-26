using System;

namespace TriangleArea
{
    class TriangleArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату x первой точки:");
            double coordinateX1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координату y первой точки:");
            double coordinateY1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координату x второй точки:");
            double coordinateX2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координату y второй точки:");
            double coordinateY2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координату x третей точки:");
            double coordinateX3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координату y третей точки:");
            double coordinateY3 = Convert.ToDouble(Console.ReadLine());

            double epsilon = 1.0e-10;
            
            if (Math.Abs((coordinateY1 - coordinateY2) * (coordinateX1 - coordinateX3) - (coordinateY1 - coordinateY3) * (coordinateX1 - coordinateX2)) <= epsilon)
            {
                Console.WriteLine("Точки лежат на одной прямой!");
            }
            else
            {
                double sideALength = Math.Sqrt(Math.Pow(coordinateX1 - coordinateX2, 2) + Math.Pow(coordinateY1 - coordinateY2, 2));
                double sideBLength = Math.Sqrt(Math.Pow(coordinateX2 - coordinateX3, 2) + Math.Pow(coordinateY2 - coordinateY3, 2));
                double sideCLength = Math.Sqrt(Math.Pow(coordinateX3 - coordinateX1, 2) + Math.Pow(coordinateY3 - coordinateY1, 2));

                double halfPerimeter = (sideALength + sideBLength + sideCLength) / 2;
                double area = Math.Sqrt(halfPerimeter * (halfPerimeter - sideALength) * (halfPerimeter - sideBLength) * (halfPerimeter - sideCLength));

                Console.WriteLine("Площади треугольника - {0}", area);
            }
        }
    }
}
