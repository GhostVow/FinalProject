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
            IProductService productService = new ProductManager(new EfProductDal());

            var products = productService.GetByUnitPrice(50,100);

            products.ForEach(p => Console.WriteLine(p.ProductName + " " + p.UnitPrice));

            

        }
    }
}
