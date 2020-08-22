using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Web.Api.Domain;
using Web.Api.Domain.Shop;

namespace Web.Api.Data.DBContexts
{
    public class ShopDbContext:DbContext
    {
       public DbSet<Product> products { set; get; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Shop;");
        }

        public ShopDbContext(DbContextOptions<ShopDbContext> options)
      : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public ShopDbContext()
        {
        }
    }
}
