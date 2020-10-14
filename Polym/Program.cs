using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Mime;
using System.Security.Cryptography.X509Certificates;

namespace Polym
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 4, 5, 6 };
            ArrayList nums2 = new ArrayList { 1, 2, 4, 5, 6 };

            Teacher fg = new Teacher { Name = "大飞哥", Age = 39 };
            Teacher fish = new Teacher { Name = "小鱼", Age = 19 };
            Teacher waiting = new Teacher { Name = "诚聘", Age = 0 };
            IEnumerable<Teacher> teachers = new List<Teacher> { fg, fish, waiting };

            Major csharp = new Major { Name = "C#", TeacherName = "大飞哥", TeacherAge = 39 };
            Major SQL = new Major { Name = "SQL", TeacherName = "大飞哥", TeacherAge = 39 };
            Major Javascript = new Major { Name = "JavaScript", TeacherName = "大飞哥", TeacherAge = 29 };
            Major UI = new Major { Name = "UI", TeacherName = "小鱼", TeacherAge = 19 };
            IEnumerable<Major> majors = new List<Major> { csharp, SQL, Javascript, UI };

            IList<Student> students = new List<Student>
            {
                new Student{Score = 98, Name = "屿", Majors=new List<Major>{csharp,SQL } },
                new Student{Score = 86, Name = "行人", Majors=new List<Major>{Javascript, csharp, SQL} },
                new Student{Score = 78, Name = "王平", Majors=new List<Major>{csharp}},
                new Student{Score = 89, Name = "王枫", Majors=new List<Major>{Javascript, csharp, SQL,UI}},
                new Student{Score = 98, Name = "蒋宜蒙", Majors=new List<Major>{Javascript, csharp}},
            };



            // linq
            //var stu = from s in students                      // 找到students 这个结果集 , s 是这个结果集的每一个元素
            //          where s.Score>80
            //          select s

            // 排序
            //var orderby = from a in students
            //              where a.Score > 80
            //              orderby a.Score descending
            //              select a;

            // 分组     IEnumerable < IGrouping <
            //var groupedMajor = from m in majors                 // by 是指以 什么分组, group 是分组之后的结果
            //                   group m by m.Teacher             // 分组 m 是作为集合,对m进分组,分组的条件是 m.Teacher , 简单理解为对谁进行分组,分组成什么样子 
            // 分组之后如果还想添加条件 , 或者对上述的结果集进行加工,一定要into

            // 投影  into
            //var groupedMajor = from m in majors
            //                   group m by m.Teacher             // 到此为止，得到分组结果集
            //                                                    // 接下来对分组结果集再运算（统计）
            //                   into mm                          // into类似于命名，将之前的结果集命名为：mm,into之后一定要用它,不然语法通不过
            //                   select new                       // 使用匿名类
            //                   {
            //                       teacher = mm.Key.Name,       // 老师的名字
            //                       count = mm.Count(),          // 统计的结果
            //                   };

            // 01
            // 取小鱼老师教的科目,majors能点出Teacher 是因为majors里有Teacher 类型的属性
            //var majorOfYu = from m in majors
            //                where m.Teacher.Name == "小鱼"
            //                select m;
            // 02
            //join 连接写法 , 取大飞哥教的课
            //var majorOfYu = from t in teachers
            //                join m in majors on t equals m.Teacher
            //                where t.Name == "大飞哥"
            //                select new                      // 用匿名类 就输出了两个值
            //                {
            //                     m.Name,                    // 在 linq里面的匿名方法 可以不赋值,直接用
            //                     tname=t.Name,              // 如果有同名的就要赋值给新的
            //                };

            // left outer join 像SQL里面的左连接

            //var majorOfTeacher = from t in teachers
            //                     join m in majors on t equals m.Teacher
            //                     into mt
            //                     from result in mt.DefaultIfEmpty()         // 如果没有这个就是inner join了,没有把右边表没有的赋值为null
            //                     select new
            //                     {
            //                         t.Name,
            //                         mname = result?.Name??"没有课程"
            //                     };


            // 查找两个条件一样的数据出来 , 连接条件用 匿名类,并且要赋值
            //var mymajors = from t in teachers
            //               join m in majors
            //               on new { age=t.Age , name=t.Name } equals new { age=m.TeacherAge , name=m.TeacherName }      // 这里要再次赋值,不然join推断不出来类型
            //               select new
            //               {
            //                   t.Age,
            //                   t.Name,
            //                   majorName = m.Name
            //               };

            // let 子句, 像子查询一样,先查出来一个结果集,然后对这个结果集再次查询
            // 一般用的也不多,在数据庞大的时候太麻烦了,作为了解 , 一般在这个时候 都是用 SQL 查了,或者存储过程
            //var mymajors = from s in students
            //               let ms = s.Majors                  // 把students专业的结果集 赋值给另一个
            //               from m in ms                       // 然后找到 ms 这个结果集, m是ms的每一个元素
            //               select new                         // 用子查询的眼光取看待这个
            //               {
            //                   stuName=s.Name,
            //                   m.Name,
            //               };

            // 接上面  试试别的办法 , 取学的专业为2个或者2个以上的 
            // 这样查的效果不是很好 , 要把专业能再次循环
            //var mymajors = from s in students
            //               from m in s.Majors
            //               where s.Majors.Count() > 1
            //               select new
            //               {
            //                   s.Name,
            //                   majorsName = m.Name,
            //               };

            // 接上面 用 group by 让结果集能再次循环              // by 是指以 什么分组, group 是分组之后的结果
            var mymajors = from s in students                   // 先把students 里的每个元素取出来
                           from m in s.Majors                   // 再把 每一个元素 里面的 majors每一个专业 取出来
                           group m by s.Name into gm            // 想让key 是什么  , 就看 by,但是这个结果集 还是group
                           where gm.Count() >= 2
                           select new
                           {
                               gm.Key,                          // gm.key 就是 by s.Name
                               gm                               // gm 这个结果集  还是 group m
                           };




            foreach (var item in mymajors)
            {

                Console.WriteLine($"{ item.Key}  ");
                foreach (var n in item.gm)
                {
                    Console.WriteLine("    " + n.Name);

                }


                //Console.WriteLine(item.Name + ":");
                //foreach (var n in item)
                //{
                //    Console.WriteLine("\t" + n.Name);
                //}

            }




            // 老写法 非常麻烦
            //foreach (var item in students)
            //{
            //    if (item.Score>80)
            //    {
            //        Console.WriteLine(item.Name);
            //    }
            //}

            //double x = 3.14159;
            //double y = 3.131214.Round(2);
            //Console.WriteLine(y);
            //new Student("小屿").Play("王者");
            //Student stu = new Student("行人");
            //stu.Play("吃鸡");

            //Work w = new Work() { Id = 857, Name = "代码" };
            //w.Content();

            //var w = new WarmKiller();
            //w.Love();
            //IKiller k = new WarmKiller();
            //k.Kill();

            //Fan f = new Fan(new PowerSupplyUp());
            //Console.WriteLine(f.Work());

            //PhoneUser u = new User(new NokiaPhone());
            //u.UsePhone();
            //PhoneUser us = new User(new MiPhone());
            //us.UsePhone();

            //CarUser c = new CarUser(new BYDCar());
            //c.UseCar();
            //CarUser u = new CarUser(new BMWCar());
            //u.UseCar();
            //TruckUser t = new TruckUser();
            //t.Run(3);

            //Engine e = new Engine();
            //Bus b = new Bus(e);
            //b.run(3);
            //Console.WriteLine(b.Speed);

            //BydCar r = new BydCar();
            //r.Run(2);
            //Console.WriteLine($"转速是{r.RPM}");
            //Console.WriteLine($"时速是{r.Speed}");

            //Vehicle v = new Car();
            //v.Run();
            //Vehicle t = new Truck();
            //t.Stop();


            //父类变量引用子类对象的时候
            //方法以变量为准进行调用,而不是按照实例,走了父类的同名方法
            //Teacher t = new Student();
            //t.Greet();
            //t.Homework();
            //Student s = new Student();
            //s.Greet();

            //Teacher tt = new Teacher();
            ////tt.Greet();

            //Teacher ss = new Student();
            //ss.Greet();
            //Student nn = new Student();
            //Console.WriteLine(nn.Name);
            //Console.WriteLine(tt.Age);
        }
    }

}