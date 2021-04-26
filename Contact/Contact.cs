using System;
using System.Collections.Generic;
using System.Text;

namespace Contact
{
    class Contact
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string TelephoneNumber { get; set; }

        public Contact(string name, string lastname, string telephoneNumber)
        {
            Name = name;
            LastName = lastname;
            TelephoneNumber = telephoneNumber;
        }

        public Contact()
        {

        }

        public void Print()
        {
            Console.WriteLine("{0},{1},{2}", Name, LastName, TelephoneNumber);
        }
    }
}
