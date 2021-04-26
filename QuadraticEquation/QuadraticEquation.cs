using System;

/*
Прочитать с консоли коэффициенты a, b и c квадратного уравнения 𝑎𝑥
2 + 𝑏𝑥 + 𝑐 = 0 и найти решение этого уравнения
• Не забыть рассмотреть все 3 случая – когда есть 2 корня, 1 корень и нет решений
• Программа должна работать даже если уравнение не квадратное (a равен 0), например, решать линейное уравнение и т.д.
 */
namespace QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэффициент a для уравнения ax^2 + bx + c:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите коэффициент b для уравнения ax^2 + bx + c:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите коэффициент c для уравнения ax^2 + bx + c:");
            double c = Convert.ToDouble(Console.ReadLine());

            double epsilon = 1.0e-10;

            if (Math.Abs(a) <= epsilon)
            {
                if (Math.Abs(b) <= epsilon && Math.Abs(c) <= epsilon)
                {
                    Console.WriteLine("Уравнение {0}x + {1} имеет бесконечное множество решений.");
                }
                else if (Math.Abs(b) <= epsilon)
                {
                    Console.WriteLine("Уравнение {0}x + {1} не имеет решений");
                }
                else
                {
                    double equationRoot = -c / b;
                    Console.WriteLine("Уравнение {0}x + {1} имеет корень x1 = {2}!", b, c, equationRoot);
                }
            }
            else
            {
                double discriminant = Math.Pow(b, 2) - 4 * a * c;

                if (discriminant < -epsilon)
                {
                    Console.WriteLine("Уравнение {0}x^2 + {1}x + {2} не имеет решений!", a, b, c);
                }
                else if (Math.Abs(discriminant) <= epsilon)
                {
                    double equationRoot = -b / (2 * a);
                    Console.WriteLine("Уравнение {0}x^2 + {1}x + {2} имеет корень x1 = {3}!", a, b, c, equationRoot);
                }
                else
                {
                    double equationRoot1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    double equationRoot2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

                    Console.WriteLine("Уравнение {0}x^2 + {1}x + {2} имеет корени x1 = {3}, x2 = {4}!", a, b, c, equationRoot1, equationRoot2);
                }
            }
        }
    }
}
