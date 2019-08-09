using System;

namespace CSharpMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double result = Calculator.ConeVolume(100,100);
            Console.WriteLine(result);
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
    }
}
