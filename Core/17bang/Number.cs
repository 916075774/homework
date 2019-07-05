using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork._17bang
{
    class Number
    {
        public void Guess1TOX()
        {
            int random = new Random().Next(500);
            Console.WriteLine("--------猜数字游戏----");
            Console.WriteLine();
            Console.WriteLine("请输出1-500以内你猜的数字：");

            //Console.WriteLine(a);
            for (int i = 5; i > 0; i--)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input > random)
                {
                    Console.Write("太大，往小里猜");
                    Console.WriteLine();
                    Console.WriteLine($"还有{i - 1}次机会");
                }
                else
                {
                    if (input < random)
                    {
                        Console.Write("太小，往大里猜");
                        Console.WriteLine();
                        Console.WriteLine($"还有{i - 1}次机会");
                    }

                    else
                    {
                        Console.WriteLine("恭喜你，猜对了");
                        Console.WriteLine();
                    }

                }
            }
            Console.WriteLine($"机会用尽，游戏结束");
            Console.WriteLine($"正确答案是{random}");
        }
    }
}