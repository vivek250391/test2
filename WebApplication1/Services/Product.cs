using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Contracts;
using WebApplication1.Models;

namespace WebApplication1.Utility
{
    public class Product:IProduct
    {
        public List<ProductModel> getProducts()
        {
            List<ProductModel> products = new List<ProductModel>();
            products.Add(new ProductModel { Id = 1, Name = "1mm wire", Description = "1mm wire", Image = "./Images/Product.png",CostPrice=100,SalePrice=110 });

            products.Add(new ProductModel { Id = 2, Name = "2mm wire", Description = "2mm wire", Image = "./Images/Product.png",CostPrice=200,SalePrice=220 });
            products.Add(new ProductModel { Id = 2, Name = "3mm wire", Description = "3mm wire", Image = "./Images/Product.png", CostPrice = 300, SalePrice = 330 });

            return products;
        }
    }
}
