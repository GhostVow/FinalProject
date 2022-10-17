using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category GetById(int id);

        bool Add(Category category);
        bool Delete(Category category);
        bool Update(Category category);
    }
}
