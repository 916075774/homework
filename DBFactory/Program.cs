using BLL.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Microsoft.SqlServer.Server;
using System;

namespace DBFactory
{
    class Program
    {
        public static readonly LoggerFactory consoleLoggerFactory
            = new LoggerFactory(
                //_, __跟我的输入无关，返回一个true
                new[] { new ConsoleLoggerProvider((_, __) => true, true) }
              );


        static void Main(string[] args)
        {

            string connectionString =
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=17bang;Integrated Security=True;";

            DbContextOptionsBuilder<SQLContext> optionsBuilder = new DbContextOptionsBuilder<SQLContext>();
            optionsBuilder
                .UseLoggerFactory(consoleLoggerFactory)
                .UseSqlServer(connectionString);



            DatabaseFacade db = new SQLContext(optionsBuilder.Options).Database;
            db.EnsureDeleted();      //如果存在数据库，就删除
            db.EnsureCreated();      //和Migration可能冲突，不要混合使用
            ////db.Migrate();

            RegissterFctory.Create();
            //Suggest.NewFactory.Create();

            Console.Read();
        }
    }
}
