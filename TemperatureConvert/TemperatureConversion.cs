using System;

namespace TemperatureConversion
{
    class TemperatureConversion
    {
        public static double ConvertToFahrenheit(double celsiusTemperature)
        {
            return 9.0 / 5.0 * celsiusTemperature + 32;
        }

        public static double ConvertToKelvin(double celsiusTemperature)
        {
            return celsiusTemperature + 273.15;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение температуры (в градусах Цельсия):");
            double celsiusTemperature = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("{0} градусов Цельсия = {1} градус(ов) по Фаренгейту", celsiusTemperature, ConvertToFahrenheit(celsiusTemperature));
            Console.WriteLine("{0} градусов Цельсия = {1} градус(ов) по Кельвину", celsiusTemperature, ConvertToKelvin(celsiusTemperature));
        }
    }
}
