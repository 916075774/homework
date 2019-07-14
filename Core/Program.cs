#define World
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HomeWork;


namespace HomeWork._17bang
{
    class Program
    {
        public static void Main(string[] args)
        {
            string q = null;
            string p = q ?? "3";
            Console.WriteLine(p);


            //Console.WriteLine(Type.GetType("Junior.Student"));

            //Console.WriteLine("".GetType().Name);
            //Console.WriteLine(typeof(Int32).Assembly);

            #region try
            //try
            //{
            //    IEnumerable<int> numbers = Enumerable.Range(0, 1000);
            //    var filtered = numbers.AsParallel()
            //        //.Where(n => n % 11 == 0)
            //        .Where(n => 8 % (n > 100 ? n : 0) == 0)     //这个异常时被除数等于0的时候就会报异常，被除数不能为0，不然谁除它结果就是0了。
            //        ;
            //    //foreach (var item in filtered)
            //    //{
            //    //    Console.WriteLine(item);
            //    //}
            //    filtered.ForAll(f => Console.WriteLine(f));
            //    //Parallel.ForEach(numbers, (x) => { Console.WriteLine(x); });
            //}
            //catch (AggregateException ae)
            //{
            //    ae.Handle(e =>
            //    {
            //        Console.WriteLine(e.Message);
            //        return true;
            //    });
            //} 
            #endregion

            Console.Read();
            //Getup().Wait();

            #region 线程
            //Console.WriteLine(Thread.CurrentThread);

            //Thread current = Thread.CurrentThread;      //主线程
            ////Thread current = new Thread(new ThreadStart(Process));     //工作线程

            //Console.WriteLine(Thread.GetDomain().FriendlyName);     //把它理解成当前程序集名称
            //Console.WriteLine(current.ManagedThreadId);             //托管线程ID
            //Console.WriteLine(current.Priority);                    //优先级
            //Console.WriteLine(current.IsThreadPoolThread);          //是不是线程池的线程
            //Console.WriteLine(current.IsBackground);                //是后台还是前台线程
            //Console.WriteLine(current.ThreadState);                 //线程状态 
            #endregion
            #region 注释
            //Number randoms = new Number();
            //randoms.Guess1TOX();

            //Max.Maxmum();

            //object[] array = new object[10];
            //array[0] = false;
            //array[1] = true;
            //array[2] = "小屿"; 

            //Console.WriteLine(array[1].GetType());
            ////bool feigeIsSMart = true;
            //if ((bool)array[1])
            //{
            //    Console.WriteLine("你好");
            //}

            //Teacher<int> fg=new Teacher<int>();
            //int fmoney = fg.Salary;

            //Teacher<string> xy=new Teacher<string>();
            //string name = xy.Name;

            //Console.WriteLine(fmoney);
            //Console.WriteLine(name);
            //    IPerson xy = new Student();
            //    Console.WriteLine(xy.Greet(3, 2));
            //    xy.Eat(); 
            #endregion
        }

        /// <summary>
        /// 起床的方法：....
        /// </summary>
        /// <param name="amount">起床的人数</param>
        /// <returns>没有起床的王平</returns> 
        public static async Task Getup()
        {
            await Task.Run(() => { Console.WriteLine("洗脸"); });
            await Task.Run(() => { Console.WriteLine("刷牙"); });
            await Task.Run(() => { Console.WriteLine("吃早餐"); });
            await Task.Run(() => { Console.WriteLine("背单词"); });

            //Task[] tasks =                                              //异步
            //{
            //    Task.Run(() => { Console.WriteLine("洗脸"); }),
            //    Task.Run(() => { Console.WriteLine("刷牙"); }),
            //    Task.Run(() => { Console.WriteLine("吃早餐"); }),
            //    Task.Run(() => { Console.WriteLine("背单词"); })
            //};
            //await Task.WhenAll(tasks);
        }

        //public static void Process()
        //{
        //    Console.WriteLine($"ThreadId:{Thread.CurrentThread.ManagedThreadId}");
        //}
    }
}
