using System;
using System.Collections.Generic;
using System.Text;

namespace Polym
{


    // 以值类型变量 相关联的那块内存里 存储的是值类型的实例
    // struct 可以继承接口 ,但是不可有子类
    // struct 可以实例化
    struct Work : IContent
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Content()
        {
            Console.WriteLine($"I'm#{this.Id} I'm{this.Name} .");
        }
    }

    interface IContent
    {
        void Content();
    }
}
