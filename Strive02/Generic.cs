using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Text;

namespace Strive
{
    internal class Grneric<T> where T : struct { }
    //子类继承父类,也要把父类的约束带上
    internal class DerivedGrneric<T> :Grneric<T> where T: struct { }

    internal class Major { }
    internal class SQL : Major { }
    internal class Person<T> where T : Major
    {
        public Person(string name)
        {
            _name = name;
        }
        internal string _name;
    }

    // 当泛型类被使用的时候, 一定要指明它的类型参数
    internal class Teacher : Person<Major> 
    {
        public Teacher( string name ):base(name)
        {
            
        }
    }

    internal class Teacher<T> : Person<T> where T : Major
    {
        public Teacher(string name):base(name)
        {
            
        }
    }
    //提问环节  Teacher 和 Teacher<T> 之间有什么关系呢

    // 关系就是拥有同一个父类,且两个都向上转换的时候 类型达到一致,可以相互改变指针
    



    class Apple
    {
        public string Color { get; set; }
         
    }
    class Box<TCargo>
    {
        public TCargo Cargo { get; set; }
        //public Book  book { get; set; }
    }

    class Book
    {
        public string Name { get; set; }
    }
 

}
