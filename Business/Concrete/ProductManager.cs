﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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

        public IResult Add(Product product)
        {
            _productDal.Add(product);

            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IDataResult<List<Product>> GetAll()
        {
            //Business Code
            //Yetkisi var mı?
            if (DateTime.Now.Hour == 2)
            {
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }
            var result = _productDal.GetAll();

            return new SuccessDataResult<List<Product>>(result, Messages.ProductListed);

        }

        public IDataResult<List<Product>> GetByCategoryId(int categoryId)
        {
           var result =_productDal.GetAll(p => p.CategoryId == categoryId);

            return new SuccessDataResult<List<Product>>(result);
        }

        public IDataResult<Product> GetById(int productId)
        {
            var result = _productDal.Get(p => p.ProductId == productId);

            return new SuccessDataResult<Product>(result);
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            var result = _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);

            return new SuccessDataResult<List<Product>>(result);
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            var result = _productDal.GetProductDetails();

            return new SuccessDataResult<List<ProductDetailDto>>(result);
        }
    }
}
