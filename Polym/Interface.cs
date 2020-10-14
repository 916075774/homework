using System;
using System.Collections;
using System.Diagnostics.Tracing;

namespace Polym
{
    class Interface
    {
        // 有两个数组 ,分别求和 求平均值
        //public void Sum(int[] nums)
        //{
        //    int sum = 0;
        //    foreach (var n in nums)
        //    {
        //        sum += n;
        //    }
        //    Console.WriteLine(sum);
        //}

        //public double Avg(int[] nums)
        //{

        //    int sum = 0;
        //    int count = 0;
        //    foreach (var n in nums)
        //    {
        //        sum += n;
        //        count++;                
        //    }
        //    return sum / count;
        //}

        internal double Avg(IEnumerable nums)
        {
            int sum = 0;
            int count = 0;
            foreach (var n in nums)
            {
                sum += (int)n;
                count++;
            }
            return sum / count;

        }

        // 用了接口之后 只用写两个方法,就可以实现重用 , IEnumerable 是 array 和 arraylist 的父类,所以都可以遍历自己 
        // 把自己类型的变量传进来就可以 遍历 求和 求平均;
        // 这是 .net framework 提供 标准 集合类型 可以直接 使用 foreach 

        internal int Sum(IEnumerable nums)
        {
            int sum = 0;
            foreach (var n in nums)
            {
                sum += (int)n;
            }
            return sum;
        }

        // 大接口例子
        // 传给调用的接口是由两个设计很好的小接口组成,本来传给小接口就可以解决需求,结果却传了一个大接口
        // 要写个自定义的foreacch 遍历自身 , 太难了

        internal static int Sum(ICollection nums)
        {
            int sum = 0;
            foreach (var n in nums)
            {
                sum += (int)n;

            }
            return sum;
        }
    }

    // 显示接口实现
    // 这个杀手不太冷 有两面性,绅士 跟 杀人 
    // 绅士的一面要展示出来, 杀人可不能随便展示
    interface IGentleman
    {
        void Love();
    }
    interface IKiller
    {
        void Kill();
    }

    class WarmKiller : IGentleman, IKiller
    {
        public void Love()
        {
            Console.WriteLine("我是暖男");
        }

        // 杀人的一面 要显示实现 接口, 并且不写访问修饰符
        // 想调用杀人方法,就要用父类的变量来调用 , 即向上转换
        void IKiller.Kill()
        {
            Console.WriteLine("我是杀手");
        }
    }


    // 自定义类型实现 foreach 失败 , 不会写 以后看看吧
    //class Test : IEnumerable
    //{
    //    private Test[] _test;
    //    public Test(Test[] test)
    //    {
    //        _test = Test[test.Length];
    //        for (int i = 0; i < test.Length; i++)
    //        {
    //            _test[i] = test[i];
    //        }
    //    }

    //    public IEnumerator GetEnumerator()
    //    {
    //        return new Test(_test);
    //    }
    //}

    #region 紧耦合demo 最开始的设计 ,最垃圾的
    // 这是个 紧耦合,或者说 依赖关系
    // 这是非常严重的事情,耦合度高,说明一个类 依赖 另一个类,造成如果 出bug 很难发现 
    // 工作后都是模块发 开发的, Engine 是一个人写的,Bus是一个,如果 写 Engine 的错了, Bus 工作就一直受阻. 要等他弄好才能接着做
    // 而且如果 Engine 错了,Bus 类 也会跟着错 , 像这样的情况 , 找 BUG 都找不到在哪
    // 引擎类
    class Engine
    {
        // 设置 转速 属性
        public int RPM { get; private set; }
        // 运行 方法 ( 油门大小 )
        internal void Work(int gas)
        {
            // 转速值  油门大,转速高,所以是 * 乘
            this.RPM = /*gas * 2*/000;
        }
    }

    // 现在有一个 公交车 类 
    class Bus
    {
        // 车有速度,来个速度属性
        public int Speed { get; private set; }

        private Engine _engine;

        // 车要运行 要把这个方法传进来,所以传对象进来   就有了运行的方法
        public Bus(Engine engine)
        {
            this._engine = engine;
        }

        // 车要跑的方法, 跑 要有油门 , 方法里面要调用 运行 方法
        // 车跑起来了 要显示它的速度 , 速度 等于转速 ÷
        public void Run(int gas)
        {
            _engine.Work(gas);
            this.Speed = _engine.RPM / 100;
        }
    }
    #endregion

    #region 低耦合 demo  ,解耦 demo 依赖反转  改设计

    // 交通工具接口 ,里面有 车 都要用的方法 ,如果有厂商生产车 ,就要来遵循这个契约
    interface IVehicle
    {
        // 加油方法
        void Refuel();
        // 停车方法
        void Stop();
        // 跑的方法
        void Run(int gas);
    }

    // 这里注意一下 当 类 实现 接口 的时候 , 类 跟 接口 的关系也是 紧耦合 的

    // BYD汽车公司,要遵守行业规范 IVehicle 里面的方法
    // 车 实现了踩油门的方法,跑的方法 ,属于基本功能 ,生产车必须有的
    // 这样就低耦合了, 方法接口定义好,我们厂商只用实现契约
    class BYDCar : IVehicle
    {
        // 速度属性
        public int Speed { get; set; }
        // 转速属性
        public int RPM { get; set; }

        public void Run(int gas)
        {
            this.RPM = gas * 2000;
            this.Speed = RPM / 100;
            Console.WriteLine("BYD车已启动");
        }

        public void Refuel()
        {
            Console.WriteLine("BDY油已加满");
        }

        public void Stop()
        {
            this.RPM = 0;
            this.Speed = 0;
            Console.WriteLine("BYD车已停止");
        }

        // 如果再来 其他 汽车公司  也要遵守 
        // 这样的方法 大大降低了 耦合度,彼此之间互不相干 ,不会造成bug存在

    }

    // 注意 , 当 类 实现 接口 的时候, 类 跟 接口 的关系 , 也是 紧耦合 的

    // Bmw汽车公司, 也要遵守行业规范,实现IVehicle
    class BMWCar : IVehicle
    {
        // 速度属性
        public int Speed { get; set; }
        // 转速属性
        public int RPM { get; set; }

        public void Run(int gas)
        {
            this.RPM = gas * 2000;
            this.Speed = RPM / 100;
            Console.WriteLine("BMW车已启动");
        }

        public void Refuel()
        {
            Console.WriteLine("BMW油已加满");
        }

        public void Stop()
        {
            this.RPM = 0;
            this.Speed = 0;
            Console.WriteLine("BMW车已停止");
        }
    }

    // 现在有个汽车司机 , 司机要驾驶车
    // 汽车司机 不光能开 BYD汽车,也能开BMW 汽车
    // 所以 有参构造函数 传进来一个汽车厂商的对象,再把它赋值给字段,这个司机就两个厂商的车都能开了
    class CarUser
    {
        // 行业规范 类型 的 字段
        private IVehicle _vehicle;

        // 这里就像用户输入汽车一样 ,看看自己能开什么样的桥车,我输入了 BMW,能开 ; 输入 BYD 也能开
        // 低耦合  不依赖别人, 做好自己的事 , 只需要知道传什么进来,我就输出什么
        public CarUser(IVehicle vehicle)
        {
            this._vehicle = vehicle;
        }

        internal void UseCar()
        {
            _vehicle.Run(2);
            _vehicle.Stop();
            _vehicle.Refuel();
        }
    }

    // 是不是还有另一种写法 , 尝试写一下
    // 上面的写法很方便,同一个司机,根据传进去的汽车不同,不同的车都能开,传一个 BWM 能开 ,传一个 BYD能开
    // 如果按照下面这种写法, 卡车司机 只能开 BYD汽车 ; 如果想开 BMW汽车,就要再写一个类,在继承BMW汽车,导致代码像屎山一样,垃圾代码
    // 
    class TruckUser : BYDCar
    {

    }

    // 思考题 : 如果有 多个 服务使用者 的时候呢 , 是不是把 CarUser 类 复制几个???

    #endregion

    #region 多种配对 桥接模式 -- 当多个服务的调用者 和 多个服务的提供者都 遵循 一个接口的时候

    // 不用 用户 根据 传进去的手机厂商不同,用不同的手机

    interface IPhone
    {
        // 发短信 方法
        void Send();
        // 打电话 方法
        void Call();
    }

    // 厂商 实现 行业规范 , 类 实现了 接口 , 类 与 接口 也是 紧耦合 的
    class NokiaPhone : IPhone
    {
        public void Call()
        {
            Console.WriteLine("Nokia Phone 呼叫...");
        }

        public void Send()
        {
            Console.WriteLine("Nokia Phone 私信 ...");
        }
    }

    //厂商 实现 规范 , 厂商 和 契约 - 也是 - 紧耦合的
    class MiPhone : IPhone
    {
        public void Call()
        {
            Console.WriteLine("Mi Phone 呼叫 ...");
        }

        public void Send()
        {
            Console.WriteLine("Mi Phone 私信 ...");
        }
    }

    // 设置一个 抽象 类 ,里面写必要的东西 , 子类继承抽象类的时候直接用,代码重用
    abstract class PhoneUser
    {
        private protected IPhone _phont;
        public PhoneUser(IPhone phone)
        {
            this._phont = phone;
        }
        public abstract void UsePhone();
    }


    // User 用户 可以用 诺基亚 也可以用 小米
    class User : PhoneUser
    {
        public User(IPhone phone) : base(phone)
        {

        }
        public override void UsePhone()
        {
            _phont.Send();
            _phont.Call();
        }
    }


    // Vip 用户 可以用 诺基亚 也可以用 小米
    class VipUser : PhoneUser
    {
        public VipUser(IPhone phone) : base(phone)
        {

        }
        public override void UsePhone()
        {
            _phont.Send();
            _phont.Call();
        }
    }

    // 思考题 : 如果更近一步的设计是什么样子的呢 ?
    // 刘老师说 更进一步就是 设计模式了 .  加油 , 迟早拿下它


    // 抽象类不能继承接口 , 或者说没有意义
    abstract class VIP : IPhone
    {
        public abstract void Call();

        public abstract void Send();

    }

    #endregion


}
