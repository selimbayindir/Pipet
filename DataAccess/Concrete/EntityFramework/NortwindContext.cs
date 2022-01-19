using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{

    public class NortwindContext:DbContext //kütüphane entityframework en gell
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=BYNDR28\BYNDRSERVER;Database=Northwind;Trusted_Connection=true");
        }
       // public DbSet<benim koddaki tablom> vt de ki tablo { get; set; }
        public DbSet<Product> Products { get; set; } //Anahtar işareti çıkacak :D
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
