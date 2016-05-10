using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age
{
    class Person
    {
        public string firstName;
        public string lastName;
        public int age;
        public int birthYear;
        public Person(int BirthYear)
        {
            birthYear = BirthYear;
            firstName = "bill";
            lastName = "gill";
            age = (2016 - birthYear);

        }
        public static Person operator +(Person person, int yearsToAge)
        {          
            Person agedPerson = new Person(person.birthYear);
            agedPerson.age = (person.age + yearsToAge);
            return agedPerson;
        }

    }
}
