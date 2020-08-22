using System;
using Web.Api.Domain.Shop;
using Web.Api.Data.DBContexts;

namespace RndConsole.App
{
    class Program
    {
       private static ShopDbContext context = new ShopDbContext();
        static void Main(string[] args)
        {
            context.Database.EnsureCreated();
            Console.WriteLine("Hello World!");
        }
    }
}
