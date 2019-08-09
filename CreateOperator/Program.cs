using System;
using System.Collections.Generic;

namespace CreateOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Person persion1 = new Person();
            Person person2 = new Person();
            persion1.name = "Deer";
            person2.name = "Deer's wife";
            List<Person> nation = persion1 + person2;
            foreach (var p in nation)
            {
                Console.WriteLine(p.name);
            }
        }
    }
    class Person
    {
        public string name;

        public static List<Person> operator +(Person p1, Person p2)
        {
            List<Person> people = new List<Person>();
            people.Add(p1);
            people.Add(p2);
            for (int i = 0; i < 11; i++)
            {
                Person child = new Person();
                child.name = p1.name + "&" + p2.name + "s child";
                people.Add(child);
            }
            return people;
        }

    }
}
