using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn16Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hej!!!

            Person person1 = new Person("Håkan", "Johansson");

            person1.details.Add(new Email("Hem", "hakan@abc.com"));
            person1.details.Add(new Phone("Mobile", "1234567890"));
            person1.details.Add(new Adress("Home", "Kvarnskogen", "Sollentuna"));

            Console.WriteLine(person1);


            //PrintPerson(person1.);

            //Email email = new Email("Hem", "hakan@abc.com");
            //email.SetValue("hakan@gmail.com");

            //Adress adress = new Adress("Home", "Kvarnskogen", "Sollentuna");
            //adress.SetValue("Sollentuna");

        }

        private static void PrintPerson(Person person1)
        {
            Console.WriteLine($"Firstname: {person1.firstName}");

            foreach (var detail in person1.details)
            {
                if (detail is Adress)
                {
                    Adress adress = detail as Adress;

                    Console.WriteLine($"Street: {adress.street}");
                    Console.WriteLine($"City: {adress.city}");
                }
                else
                    Console.WriteLine($"{detail.type} : {detail.value}");
            }
        }
    }
}
