using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Pesel { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Postcode { get; set; }

        public Person()
        {
            Console.WriteLine("Enter your name: ");
            this.Name = Console.ReadLine();
            Console.WriteLine("Enter your lastname: ");
            this.LastName = Console.ReadLine();
            Console.WriteLine("Enter name of the city you live in: ");
            this.City = Console.ReadLine();
            Console.WriteLine("Enter name and the number of the street: ");
            this.Street = Console.ReadLine();
            Console.WriteLine("Enter your postcode: ");
            this.Postcode = Console.ReadLine();

        }
        public Person(string name, string lastname, int pesel, string city, string street, string postcode)
        {
            this.Name = name;
            this.LastName = lastname;
            this.Pesel = pesel;
            this.City = city;
            this.Street = street;
            this.Postcode = postcode;

        }
        public string AgeFromPesel()
        {
            Console.Write("Enter your PESEL number: ");
            string pesel = Console.ReadLine();
            int year = 19;
            if (Convert.ToInt32(pesel.Substring(0, 2)) < 20) { year = 20; }
            Console.WriteLine(String.Format("You were born {0}{1}-{2}-{3}", year, pesel.Substring(0, 2),
                pesel.Substring(2, 2), pesel.Substring(4, 2)));
            return pesel;
        }

        public void InfoAboutPerson()
        {
            Console.WriteLine(string.Format("Your name is {0} {1}. You live in {2}, on {3}. This is your Postcode {4}.",
                Name,LastName,City,Street,Postcode)); 
        }
       
    }

}
