using System;

namespace ConstructorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            Console.WriteLine(stu.ID);
            Console.WriteLine(stu.Name);

            Console.WriteLine("==========");

            Student stu2 = new Student(2, "Mr.Okay");
            Console.WriteLine(stu2.ID);
            Console.WriteLine(stu2.Name);

            double x = stu.Add(1.3,2);
            Console.WriteLine(x);

        }
    }
    class Student
    {
        //有参的构造函数
        public Student(int number, string name)
        {
            this.ID = number;
            this.Name = name;
        }

        //无参构造函数
        public Student()
        {
            this.ID = 1;
            this.Name = "No name";
        }

        //生成两个字段
        public int ID;
        public string Name;


        public int Add(int a)
        {
            return a;
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
    }
}
