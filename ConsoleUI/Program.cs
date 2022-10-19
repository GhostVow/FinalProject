using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        //SOLID
        //Open - Closed Principle
        static void Main(string[] args)
        {
            //GetProductByUnitPriceTest();
            //GetAllCategoryTest();
            //GetProductDetails();
            IProductService productService = new ProductManager(new EfProductDal());



            var products = productService.GetAll();

            if (products.Success)
            {
                products.Data.ForEach(p => Console.WriteLine(p.ProductName + " " + p.UnitPrice));
            }
            else
            {
                Console.WriteLine(products.Message);
            }

            

        }

        private static void GetProductDetails()
        {
            IProductService productService = new ProductManager(new EfProductDal());

            var products = productService.GetProductDetails();

            foreach (var product in products.Data)
            {
                Console.WriteLine($"[{product.CategoryName}]  [{product.ProductName}]  [{product.UnitsInStock}] Stock   [{product.UnitPrice}]$ ");
            }
        }

        private static void GetAllCategoryTest()
        {
            ICategoryService categoryService = new CategoryManager(new EfCategoryDal());

            var categories = categoryService.GetAll();

            foreach (var category in categories.Data)
            {
                Console.WriteLine("{0}", category.CategoryName);
            }
        }

        private static void GetProductByUnitPriceTest()
        {
            IProductService productService = new ProductManager(new EfProductDal());

            var products = productService.GetByUnitPrice(50, 100);

            products.Data.ForEach(p => Console.WriteLine(p.ProductName + " " + p.UnitPrice));

        }
    }
}
