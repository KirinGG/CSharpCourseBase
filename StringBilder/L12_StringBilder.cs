using System;
using System.Text;

namespace Lesson
{
    class L12_StringBilder
    {
        static void Main(string[] args)
        {
            const int rangeLength = 100;
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= rangeLength; i++)
            {
                sb.Append(i).Append(", ");
            }

            sb.Remove(sb.Length - 2, 2);

            string result = sb.ToString();
            Console.WriteLine(result);
        }
    }
}
