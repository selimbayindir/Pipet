using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            using (NortwindContext context =new NortwindContext() )
            {
                var addedEntity = context.Entry(entity);//REFERANSI YAKALA 
                addedEntity.State = EntityState.Added;//EKLE
                context.SaveChanges(); //KAYDET
            }
        }
        public void Delete(Product entity)
        {
            using (NortwindContext context = new NortwindContext())
            {
                var deletedEntity = context.Entry(entity);//REFERANSI YAKALA 
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges(); //KAYDET
            }
        }
        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NortwindContext context = new NortwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
              
            }

      
        }
        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NortwindContext context = new NortwindContext())
            {
                return filter == null 
                    ?context.Set<Product>().ToList() 
                    :context.Set<Product>().Where(filter).ToList();
            }
        }
        public void Update(Product entity)
        {
            using (NortwindContext context = new NortwindContext())
            {
                var updatedEntity = context.Entry(entity);//REFERANSI YAKALA 
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges(); //KAYDET
            }
        }
    }
}
