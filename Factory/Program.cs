using BLL.Repository;
using Microsoft.EntityFrameworkCore;
using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
          var db=  new Db().Database;

            db.EnsureDeleted();

            Console.WriteLine("Hello World!");
        }
    }
}
