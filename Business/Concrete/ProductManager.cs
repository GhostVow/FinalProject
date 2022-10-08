using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //Business Code
            //Yetkisi var mı?
            return _productDal.GetAll();

        }

        public List<Product> GetAllByCategory(int categoryId)
        {
           return _productDal.GettAllByCategory(categoryId);
        }
    }
}
