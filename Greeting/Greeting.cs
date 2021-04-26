using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    class Greeting
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();

            Console.WriteLine("Привет, {0}!", name);
        }
    }
}
