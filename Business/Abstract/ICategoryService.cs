using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    //Dış dünya ya ne servis etmek istiyorsun 
   public interface ICategoryService
    {
        List<Category> GetAll();
        Category GetById(int categoryId);

    }
}
