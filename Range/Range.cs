using System;
using System.Collections.Generic;
using System.Text;

/*
Создать класс Range (непрерывный вещественный числовой диапазон на прямой). В нём:
1. Объявить два вещественных поля from, to
2. Описать конструктор, при помощи которого заполняются поля
3. Реализовать геттеры и сеттеры для полей
4. Сделать метод для получения длины диапазона
5. Сделать метод IsInside, который принимает вещественное число и возвращает bool – результат проверки, принадлежит ли число диапазону
• После этого написать небольшую программу с использованием этого класса
*/
namespace Range
{
    class Range
    {
        public double From { get; set; }

        public double To { get; set; }

        public Range(double from, double to)
        {
            From = from;
            To = to;
        }

        public double GetLength()
        {
            return To - From;
        }

        public bool IsInside(double number)
        {
            double epsilon = 1.0e-10;

            return (number - From >= -epsilon) && (To - number >= -epsilon);
        }
    }
}
