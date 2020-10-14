using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Polym
{
    // 我是一个生产电扇的厂商
    // 生产电扇的话,一定要有电源,
    // 风扇转的快的时候电源输出较高电流,反之亦然
    // 电源有保护机制,电流过大 断开或者警告
    // 依赖关系是   电扇依赖电源

    #region 紧耦合实例 像zz一样的方法,只能通过GetPower() 方法改动而改动
    // 一个类设计好了之后, 不能再去改动里面的代码, 写出来这样的代码估计要被骂死
    // 如果随便改变GetPower的值 来达到测试目的 ,那么 其他风扇 获取这个值的时候运行就会出错

    // 电源类
    class PowerSupply
    {
        // 用电方法
        internal int GetPower()
        {
            // 这个电源是标准电源 ,永远只输出100
            return 200;
        }
    }

    // 风扇类
    class DeskFan
    {
        private PowerSupply _powerSupply;
        public DeskFan(PowerSupply powerSupply)
        {
            this._powerSupply = powerSupply;
        }

        // 风扇工作方法
        internal string Work()
        {
            // 风扇要获得电源
            int power = _powerSupply.GetPower();

            if (power < 0)
            {
                return "Won't Work";
            }
            else if (power <100)
            {
                return "一档 ,安全电流";
            }
            else if (power <200)
            {
                return "二档 ,电流较高";
            }
            else
            {
                return "警告 警告 电流过大 ,容易发生危险";
            }
        }
    }
    #endregion

    #region 引入接口  解耦合

    // 这个是精简版本,其实应该有三个方法,因为风扇有挡位
    // 每个挡是不同的电流,在根据输入的挡位用相应电流
    public interface IPowerSupply
    {
        int Getpower();
    }

    public class PowerSupplyUp : IPowerSupply
    {
        public int Getpower()
        {
            return 100;
        }

    }

    public class Fan
    {
        private IPowerSupply _powerSupply;
        public Fan(IPowerSupply powerSupply)
        {
            this._powerSupply = powerSupply;
        }

        public string Work()
        {

            int power = _powerSupply.Getpower();
            if (power < 0)
            {
                return "Won't Work";
            }
            else if (power < 100)
            {
                return "一档 ,安全电流";
            }
            else if (power < 200)
            {
                return "二档 ,电流较高";
            }
            else
            {
                return "警告 警告 电流过大 ,容易发生危险";
            }
        }

    }



    #endregion
}
