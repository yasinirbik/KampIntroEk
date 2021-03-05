using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkDemo
{
    class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\mssqllocaldb; Database = Northwind;Trusted_Connection = True ");//ya bundan "\" iki tane koyacazz her zaman ya da başa @ işaretini koyacağız northwind'e bağlama işini yaptık

        }
        public DbSet<Product> Products { get; set; }    //class'ı db'yle ilişkilendirdik. 
    }

}
