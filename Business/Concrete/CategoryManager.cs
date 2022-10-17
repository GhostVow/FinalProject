using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public bool Add(Category category)
        {
            _categoryDal.Add(category);
            return true;
        }

        public bool Delete(Category category)
        {
            _categoryDal.Delete(category);
            return true;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category GetById(int id)
        {
            return _categoryDal.Get(c => c.CategoryId == id);
        }

        public bool Update(Category category)
        {
            _categoryDal.Update(category);
            return true;
        }
    }
}
