using System;

namespace ServerName
{
    class ServerName
    {
        static void Main(string[] args)
        {
            string[] urls = { "http://SomeServerName/abcd/dfdf.htm?dfdf=dfdf", "http://SomeServerName", "localhost" };

            foreach (string url in urls)
            {
                string serverName = GetServerName(url);
                Console.WriteLine("Для url - {0} имя сервера = {1}", url, serverName);
            }
        }

        public static string GetServerName(string url)
        {
            const string separatorProtocolInUrl = "://";

            int startIndex = url.IndexOf(separatorProtocolInUrl);

            if (startIndex == -1)
            {
                return "Ошибка. Неверный формат url адреса!";
            }

            startIndex += separatorProtocolInUrl.Length;
            int endIndex = url.IndexOf("/", startIndex);

            return (endIndex == -1) ? url.Substring(startIndex) : url.Substring(startIndex, endIndex - startIndex);
        }
    }
}
