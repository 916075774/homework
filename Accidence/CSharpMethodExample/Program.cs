using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CSharpMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {

            double result = Calculator.ConeVolume(100, 100);
            Console.WriteLine(result);

            Calculator c = new Calculator();
            Action myAction = new Action(c.PrinHello);

            myAction();

            int[] array = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(array[1]);
            Console.WriteLine(array[array.Length - 1]);

            var x = 200L;
            Console.WriteLine(x.GetType().Name);

            //Form myForm = new Form();
            //Console.WriteLine(myForm.Text);

            //Student stu1 = new Student();
            //stu1.Age = 60;
            //stu1.Score = 70;

            //Student stu2 = new Student();
            //stu2.Age = 24;
            //stu2.Score = 60;

            List<Student> stulist = new List<Student>();
            for (int i = 0; i < 100; i++)
            {
                Student stu = new Student();
                //stu.Age = 24;
                stu.Score = i;
                stulist.Add(stu);
            }
            Student.ReportAmount();

            Student stu1 = new Student(1);
            Console.WriteLine(stu1.ID);
            Student stu2 = new Student(2);
            Console.WriteLine(stu2);
        }
    }

    class Calculator
    {
        public static double CircleArea(double r)//圆
        {
            return Math.PI * r * r;
        }
        public static double CylinderVolume(double r, double h)//圆柱
        {
            double x = CircleArea(r);
            return x * h;
        }
        public static double ConeVolume(double r, double h)//圆锥
        {
            double a = CylinderVolume(r, h);
            return a / 3;
        }

        public void PrinHello()
        {
            Console.WriteLine("Hello");
        }
    }

    class Student
    {
        public int Age { get; }
        //public int Age1 { get => age; set => age = value; }

        //private int age;

        public readonly int ID;//只读字段
        public Student(int id)
        {
            this.ID = id;
        }

        public int Score;


        public static int AverageAge;
        public static int AverageScore;
        public static int Amount;

        public Student()
        {
            Student.Amount++;
        }
        public static void ReportAmount()
        {
            Console.WriteLine(Student.Amount);
        }
    }
}
