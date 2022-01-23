using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //Generic Constraint
    public interface IEntityRepository<T> where
        T : class, //Referans tip olabilir int sttring olarak yazamaz
        IEntity, //YA IENTİTY OLABİLİR YA DA İMPLEMENT EDEN BİR NESNE
        new()    // Newlenebilir olmalı
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null); //filtre vermesende olur 
        T Get(Expression<Func<T, bool>> filter);//filre zorunlu p=>p ...
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        //List<T> GetAllByCategory(int categoryId); //Silmedim çünkü Expression lar bu yükü kaldırır gereksiz kılar
    }
}
