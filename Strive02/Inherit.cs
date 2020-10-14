using System;
using System.Collections.Generic;
using System.Text;

namespace Polym
{
    public class Vehicle
    {

        protected int _rpm;   //发动机转速
        private int _fuel;  //汽油属性

        //加油方法  要暴露,因为没油了就要加
        public void Refuel()
        {
            _fuel = 100;
        }

        //烧油方法,这个办法为交通工具内部烧油,不需要暴露出来
        protected void Burn(int fuel)
        {
            _fuel -= fuel;
            Console.WriteLine($"使用了{fuel}格油");
            Console.WriteLine($"还剩{_fuel}格油");
        }
        public void Accelerate()    //加速
        {
            //加速的时候让速度 + 1000
            //加速的时候调用烧油方法,使其燃料-1
            Burn(1);
            _rpm += 1000;
        }

        //求当前速度
        public string Speed { get { return $"当前速度{_rpm / 100}迈"; } }
    }

    public class Car : Vehicle
    {
        //子类里面有涡轮增压加速
        public void TurboAccelerate()
        {
            //涡轮增压更加烧油,调用两次烧油办法
            Burn(2);

            //更加烧油了,转速要跟上,所以要把字段赋值
            //字段本来时私有的,子类也要用,访问级别改成protected
            _rpm += 3000;
        }
    }
}
