using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace HomeWork._17bang
{
    interface IPerson
    {
        void Eat();
        int Greet(int a, int b);
    }

    class Student : IPerson
    {
        void IPerson.Eat()
        {
            int a = 5;
            int b = 4;
            Console.WriteLine(a + b);
        }

        int IPerson.Greet(int a, int b)
        {
            return a + b;
        }
    }
}




