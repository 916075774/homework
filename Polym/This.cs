using System;
using System.Collections.Generic;
using System.Text;

namespace Polym
{

    // 扩展方法必须是静态的方法,必须要放在静态类里面
    static class Double
    {
        // 方法返回类型就是要扩展的方法的返回类型
        // 我扩展的是double 的方法,返回类型就要是double
        // 怎么知道我扩展的是什么类型的方法,就看方法的第一个参数
        public static double Round(this double input, int digits)
        {
            // 在方法里面在调用另一个方法,在返回回去
            // 简称中间商
            double result = Math.Round(input, digits);
            return result;
        }
    }

    // Extension 默认在静态方法类名后接 Extension
    public static class StudentsExtension
    {
        public static void Play(this Student student , string name )
        {
            Console.WriteLine($"{student.Name}不学习,打{name}游戏,扣红包!!!");
        }
    }
}
