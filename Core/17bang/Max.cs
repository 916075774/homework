using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork._17bang
{
    class Max
    {
        public static void Maxmum()
        {

            int[] array = new int[] { 2, 8, 4, 5, 6, 4, 0, 3, 1, 7, 9 };
            int max = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    Console.WriteLine($"第{i + 1}次比较,{array[i]}>{max},目前最大值为{array[i]}");

                    max = array[i];
                }
                else
                {
                    
                    Console.WriteLine($"第{i + 1}次比较,{array[i]}<{max},目前最大值为{max}");
                    
                }
                
                Console.WriteLine();
            }




        }
    }
}