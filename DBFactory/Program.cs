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
            DatabaseFacade db = new SQLContext().Database;
            db.EnsureDeleted();      //如果存在数据库，就删除
            db.EnsureCreated();      //和Migration可能冲突，不要混合使用
            //db.Migrate();

            RegissterFctory.Create();
            Suggest.NewFactory.Create();
        }
    }
}
