using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Strive
{
    class Bed
    {
        public int age { get; set; }
        public string name { get; set; }
    }

    class Program
    {
        static void SetHello(string name,string name2)
        {
            Console.WriteLine($"Hello,{name} and {name2}");
        }
     
        static void Main(string[] args)
        {
            //    MyClass.AICaculate(2, 3, MyClass.Add);
            //Caculate caculate = MyClass.Add;
            //Caculate caculate1 = MyClass.Multiple;
            //MyClass.AICaculate(2, 2, caculate);
            //MyClass.AICaculate(2, 3, caculate1);
            //Mathematics.AICaculate(2, 3, Mathematics.Add);
            //Mathematics.AICaculate(4, 4, Mathematics.Multiple);

            //Action<string,string> action = SetHello ;
            //action("行人","小屿");

            List<string> list = new List<string> { "a", "b", "c" };
            foreach (var item in list)
            {
                Console.Write (item+",");
            }





            //List<Student> students = new List<Student>
            //{
            //    new Student{Name="小屿"},
            //    new Student{Name="薛明林"},
            //    new Student{Name="行人"},
            //};
            //for (int i = 0; i < students.Count; i++)
            //{
            //    Console.WriteLine(students[i].Name);
            //}

            //Console.WriteLine("*---*");

            //// foreach 里 
            //// item = new student()   item 不可赋值
            //foreach (var item in students)
            //{
            //    item.Name = null;       // 给item 的 Name 属性赋值可以,不可以给item赋值   
            //    Console.WriteLine(item.Name);
            //}

            //Bed b = new Bed();
            //b.age = 19;
            //Bed d = b;
            //d.age = 20;
            //Console.WriteLine(d.age);
            //Console.WriteLine(b.age);


            //int[] nums1 = new int[] { 1, 2, 3, 4, 5, };
            //ArrayList nums2 = new ArrayList { 1, 2, 3, 4, 5 };

            //Apple a = new Apple() { Color = "Red" };
            //Box b = new Box() { Cargo = a };
            //Book bo = new Book() { Name = "活着" };
            //Box boo = new Box() { book = bo };

            //Apple ap = new Apple() { Color = "Red" };
            //Box<Apple> box = new Box<Apple>() { Cargo = ap };
            //Book bo = new Book() { Name = "活着" };
            //Box<Book> box1 = new Box<Book>() { Cargo = bo };
            //Console.WriteLine(box1.Cargo.Name);
            //Console.WriteLine(box.Cargo.Color);

            //int i = 3;
            //switch (i)
            //{
            //    case  2 :
            //        Console.WriteLine("你好");
            //        break;
            //    default:
            //        Console.WriteLine("我好哦");
            //        break;
            //}

            //Person<Major> xy = new Teacher<Major>("小屿");
            //Person<Major> xml = new Teacher("薛明林");
            //Person<Major> demo = xy;
            //xy = xml;
            //xml = demo;
            //Console.WriteLine(xy._name);
            //Console.WriteLine(xml._name);


            //Console.WriteLine("Hello World!");
        }
    }

    //public class Student
    //{

    //    public int Age { get; set; }

    //    public void Homework()
    //    {
    //        string Name = "薛明林";
    //        Console.WriteLine(Name);
    //    }
    //}
}





