using System;
/*
Есть дом с N этажами и M подъездами. Все подъезды
одинаковые, на каждом этаже в подъезде 4 квартиры.
• Считаем, что номера квартир на лестничной площадке
распределяются так:
• То есть можно сказать, что квартира 1 – ближняя слева, квартира
2 – дальняя слева, квартира 3 – дальняя справа, квартира 4 –
ближняя справа
• Прочитать с консоли числа N, M и целое число K – номер
квартиры. По введенному числу K выдать номер подъезда и
этажа, где находится эта квартира, а также положение квартиры
на лестничной площадке
• Выдать сообщение, если квартиры с таким номером нет в доме
*/
namespace Apartments
{
    class Apartments
    {
        static void Main(string[] args)
        {
            const int apartmentsOnFloorCount = 4;

            Console.WriteLine("Введите количество этажей в доме: ");
            int floorsCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество подъездов в доме: ");
            int entrancesCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер квартиры: ");
            int apartmentNumber = Convert.ToInt32(Console.ReadLine());

            if (floorsCount * entrancesCount * apartmentsOnFloorCount < apartmentNumber)
            {
                Console.WriteLine("Квартиры {0} нет в доме!", apartmentNumber);
            }
            else
            {
                int entranceNumber = (int)Math.Ceiling((double)apartmentNumber / (floorsCount * apartmentsOnFloorCount));
                int floorNumber = (int)Math.Ceiling((double)(apartmentNumber - (entranceNumber - 1) * floorsCount * apartmentsOnFloorCount) / apartmentsOnFloorCount);
                int apartmentPosition = apartmentNumber % apartmentsOnFloorCount;

                switch (apartmentPosition)
                {
                    case 1:
                        Console.WriteLine("Квартира {0} находитcя в(о) {1} подъезде, на {2} этаже, ближняя слева", apartmentNumber, entranceNumber, floorNumber);
                        break;
                    case 2:
                        Console.WriteLine("Квартира {0} находитcя в(о) {1} подъезде, на {2} этаже, дальняя слева", apartmentNumber, entranceNumber, floorNumber);
                        break;
                    case 3:
                        Console.WriteLine("Квартира {0} находитcя в(о) {1} подъезде, на {2} этаже, дальняя справа", apartmentNumber, entranceNumber, floorNumber);
                        break;
                    default:
                        Console.WriteLine("Квартира {0} находитcя в(о) {1} подъезде, на {2} этаже, ближняя справа", apartmentNumber, entranceNumber, floorNumber);
                        break;
                }
            }
        }
    }
}
