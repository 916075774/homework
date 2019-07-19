using BLL.Repository;
using Microsoft.EntityFrameworkCore;
using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            new UserRepository().Database.Migrate();
            Console.WriteLine("Hello World!");
        }
    }
}
