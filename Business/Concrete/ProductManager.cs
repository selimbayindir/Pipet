using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
                
              ///  /*Result*/(/*true,"Urun Kaydı Yapılmıştır");*/ //bunu yapabilmenin yolu constructor dır.
            //Result : Genetate Constructot with field

            /*
            if (product.ProductName.Length<2)
            {
                return new ErrorResult("Urun Adı 2 en az 2 karakter olmalıdır  .. ");
            }
            _productDal.Add(product);*/
        }

        public List<Product> GetAll()
        {
            //iş kodları
            //Yetkisi varmı
            return _productDal.GetAll(); //Data Accesdeki _productDalı döner .
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);
        }

        public Product GetById(int productId)
        {
            return _productDal.Get(p => p.ProductId == productId);   
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice < max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }
    }
}
