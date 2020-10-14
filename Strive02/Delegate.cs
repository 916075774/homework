using System;
using System.Collections.Generic;
using System.Text;

namespace Strive
{
    static class Mathematics
    {
        // 看这个例子,能不能想进行加法运算的时候就加法，想乘法的时候就乘法？
        // 参数里面不要通过 string 来进行判断, 当要判断的时候可以用 Enum
        internal static void AICaculate(int a, int b, Action<int ,int> action)
        {
            Console.WriteLine("四则运算");
            //Add(a, b);
            //AICaculate(a, b);

            // switch 跟枚举搭配使用
            //switch (opt)
            //{
            //    case Opt.Add:
            //        Add(a, b);
            //        break;
            //    case Opt.Multiple:
            //        Multiple(a, b);
            //        break;
            //    default:
            //        throw new ArgumentException();
            //        // 要学会报异常,勤报异常, 如果输入了无法判断的值,把异常报出来,或者枚举又添加新值了,但是循环这里没用到,输入新值就会有错误
            //}

             action(a, b);
        }

        internal static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
             
        }

        internal static void Multiple(int a, int b)
        {
            Console.WriteLine(a * b);
             
        }
    }

    enum Opt
    {
        Add,
        Multiple,
        // Minus,
    }

    // 以上基本上是能想到的最好的办法了
    // 现在引入一个新概念, delegate

    // 声明一个delegate
    public delegate void Caculate(int a, int b);



}
