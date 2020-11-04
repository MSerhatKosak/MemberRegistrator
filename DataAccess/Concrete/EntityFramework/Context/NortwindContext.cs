using Core.Entites.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Context
{
  public  class NortwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {//ConnectionString burda
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=True;");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationsClaims { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
    }
}
