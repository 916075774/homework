using System;
using System.Collections.Generic;
using System.Text;

namespace Polym
{
    abstract class Vehicle
    {
        internal virtual void Run()
        {
            Console.WriteLine("Vehicle is running ..");

            //之前没有虚方法的写法,非常麻烦,而且每次都要改源代码,违反开闭原则
            //if (type == "car")
            //{
            //    Console.WriteLine("car is running ..");
            //}
            //else if (type == "truck")
            //{
            //    Console.WriteLine("truck is running ..");
            //}
        }


        // 我们发现虚方法的实现永远不会被调用,那还不如不写啊,
        // 不写方法体的实现
        internal abstract void Stop();

        internal virtual void Refuel()
        {
            Console.WriteLine("pay and fill ...");
        }

        //除非加功能和改代码  否则不修改源代码;
        internal virtual void Upkeep()
        {
            Console.WriteLine(" Vehicle is upkeep ..");
        }

    }


    // 父类抽象方法,子类没有实现完,就把子类也弄成抽象的,把没有实现的,推给下一个继承的人实现
    // 缺点就是子类成为抽象类,但是无法实例化了
    // 虽然无法实例化,可以用 父类变量 引用 子类对象 ,也就是向上转换 , 来调用 Car 抽象类里面的重写方法
    abstract class Car : Vehicle
    {
        internal override void Run()
        {
            Console.WriteLine("car is running ...");
        }

        internal override void Refuel()
        {
            Console.WriteLine(" car is fill ...");
        }

        internal override void Upkeep()
        {
            Console.WriteLine(" car is upkeep ...");
        }


    }

    class Truck : Car
    {
        internal override void Run()
        {
            Console.WriteLine("truck is running ...");
        }

        internal override void Stop()
        {
            Console.WriteLine("truck is stopped ...");
        }

    }

    // 子类继承 抽象父类, 实现父类 没实现的方法
    class CarKid : Car
    {
        internal override void Stop()
        {
            Console.WriteLine("你好");
        }
    }



}
