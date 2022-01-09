using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal() //ctor
        {
            _products = new List<Product>
            {
                new Product(1,5,"KAR KURESİ",10,149),//constructor ile
                new Product(2,7,"Kamera",500,3),
                new Product{ProductId=4,CategoryId=2,ProductName="Telefon",UnitPrice=1500,UnitsInStock=65}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ
            var productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            //Gönderdiğim urun idsine sahip olan urunu bul demek ..
            var productToUpdate = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);
            //ŞUNLARI GÜNCELLE EF İLE DAHA KOLAYLAŞIYOR 
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

        }
    }
}
