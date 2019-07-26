using BLL.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.SqlServer.Server;
using System;

namespace DBFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //DatabaseFacade db = new SqlContext().Database;
            //db.EnsureDeleted();      //如果存在数据库，就删除之//db.EnsureCreated();   和Migration有可能冲突，不要混合使用
            //db.Migrate();

            new UserRepository().Database.Migrate();
            RegissterFctory.Create();
        }
    }
}
