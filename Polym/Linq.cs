using System;
using System.Collections.Generic;
using System.Text;

namespace Polym
{
    public class Student : Person
    {
        public Student()
        {

        }
        public Student(string name)
        {
            this.Name = name;
        }

        public int Score { get; set; }
        public IEnumerable<Major> Majors { get; set; }

        //public override void Homework()
        //{


        //    _money -= 1000;
        //    Console.WriteLine(_money);
        //    Console.WriteLine("学生作业");
        //}
        //public override void Greet()
        //{
        //    Console.WriteLine("学生类");
        //}
    }

    public class Teacher : Person
    {

        // 现在 Teacher 跟 Major 是双向的
        // 双向 在面向对象中 是经常出现的, 主要是为了方便 
        // 得到Teacher 能马上知道他的 Major,反之也是
        // 通常一对多是 只想多的 那个类型是集合
        public IEnumerable<Major> Major { get; set; }

        
        public Teacher()
        {

        }
        private protected int _money = 2000;
        public virtual void Homework()
        {
            Console.WriteLine(_money);
        }
        public virtual void Greet()
        {
            Console.WriteLine("老师类");
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    // 现在 Major 跟 Student 是 多对多的关系了 ,集合对集合
    // Major有多个学生, Student 里 也有多个 Major
    public class Major
    {
        public string Name { get; set; }
        //public Teacher Teacher { get; set; }
        public string TeacherName { get; set; }
        public int TeacherAge { get; set; }
        public IEnumerable<Student> Students { get; set; }
    }

}
