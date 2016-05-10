using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age
{
    class Program
    {
        static void Main(string[] args)
        {
            int birthYear = 1984;
            Person person = new Person(birthYear);
            Person agedPerson = person + 12;
            Console.WriteLine("{0} {1} is {2} years old this year", person.firstName, person.lastName, person.age);
            Console.WriteLine("{0} {1} will be {2} in 12 years", agedPerson.firstName, agedPerson.lastName, agedPerson.age);
            Console.ReadKey();
        }
    }
}
