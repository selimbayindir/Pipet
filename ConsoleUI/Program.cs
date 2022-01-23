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
            ///  ProductTest();
            ///  CategoryTest();
            ProductDetailsDtos();
        }

        private static void ProductDetailsDtos()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var item in productManager.GetProductDetails())
            {
                Console.WriteLine(item.ProductName + "/" + item.CategoryName);
            }
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var item in categoryManager.GetAll())
            {
                Console.WriteLine(item.CategoryName);
            }
        }

        private static void ProductTest()
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
