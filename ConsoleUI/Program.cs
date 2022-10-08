using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IProductService productService = new ProductManager(new InMemoryProductDal());

            var products = productService.GetAll();

            products.ForEach(p => Console.WriteLine(p.ProductName));

        }
    }
}
