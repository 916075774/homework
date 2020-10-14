using System;
using System.Collections.Generic;
using System.Text;

namespace Polym
{
    class Saff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Level Level { get; set; }
        public Skill Skill { get; set; }
    }

    // 枚举的本质是限制取值范围的整数
    // 枚举 默认值是0,且是递增 '++' 关系
    // 如果第一个值赋值100,第二个没赋值,默认是101
    enum Level
    {
        Employee,
        Manager,
        Boss,
        BigBoss,
    }


    // 枚举还可以进行位运算 
    // 一般用于权限管理 
    // 假如里面的四个技能  一个人都会,怎么写呢? 赋值只能赋一个 !!
    // 把值转换成二进制的值,按位去或(就是相加) ,就可以让这个技能都叠加在一起,不受印象
    enum Skill
    {
        Drive = 1,
        Cook = 2,
        Program = 4,
        Teach = 8,
    }

    // 使用的时候是这样
    //Person xy = new Person();
    //xy.Name = "小屿";
    //xy.Skill = Skill.Cook | Skill.Drive | Skill.Program | Skill.Teach;
    //Console.WriteLine( xy.Skill);

    // 取他会不会做饭 看值是不是大于0;如果不会就不会有值 , 也可以看 是不是相等 Skill.Cook
    //Console.WriteLine((xy.Skill & Skill.Cook) > 0);
    //Console.WriteLine((xy.Skill & Skill.Cook) == Skill.Cook);
             
}
