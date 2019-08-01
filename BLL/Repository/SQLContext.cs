using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repository
{
    public class SQLContext : DbContext
    {
        public SQLContext()
        {

        }

        public SQLContext(DbContextOptions<SQLContext> options)
        : base(options){}





        //告诉数据库我要生成这两个表
        public DbSet<User> _users { get; set; }
        public DbSet<Suggest> _suggests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = 
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=17bang;Integrated Security=True;";

            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Name)
                .IsUnique();            //让数据库中user的name不能重复


            modelBuilder.Entity<User>((options) => 
            {
                options.ToTable("Users")    //改了数据库里面表格映射的名称
                    .Property(x => x.Name)  //让name是必需的
                    .IsRequired();
            });
        }
    }
}
