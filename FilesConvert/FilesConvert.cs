using System;
using System.IO;

namespace FilesConvert
{
    class FilesConvert
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader(("..\\..\\..\\in.txt"))) 
            {
                using (StreamWriter writer = new StreamWriter(("..\\..\\..\\out.txt")))
                {
                    string currentLine;
                    while ((currentLine = reader.ReadLine()) != null)
                    {
                        writer.WriteLine(currentLine.ToUpper());
                    }
                }
            }
        }
    }
}
