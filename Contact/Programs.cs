using System;
using Contact;

namespace Contact
{
    class Programs
    {
        static void Main(string[] args)
        {
            Contact contact1 = new Contact();
            contact1.Name = "Вася";
            contact1.Print();

            Contact contact2 = new Contact("Иванов", "Иван", "01");
            contact2.Print();
        }
    }
}
