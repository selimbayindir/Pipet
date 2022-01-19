using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            // ProductManager productManager = new ProductManager(new InMemoryProductDal());
            foreach (var item in productManager.GetAll()) // GetAllByCategoryId(2)  //GetByUnitPrice(50,100)
            {
                Console.WriteLine(item.ProductName);
            }
            
            
         
        }
    }
}
