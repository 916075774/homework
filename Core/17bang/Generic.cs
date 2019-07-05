using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork._17bang
{
    class Generic
    {



        public void Call()
        {

        }
    }




    //new Teacher<int>()
    //Teacher<int> scores = new Teacher<int>();
    //scores = new Teacher<string>();
    //Teacher<bool> teachers = new Teacher<bool>();

    //Main m = new Main();
    //m = new Article();


}

class Teacher<T>
{
    internal T[] array;
    public T Salary { get; set; }
    //public T Name { get; set; }
}

class Article : Main { };
class Main { };

