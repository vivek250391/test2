using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Contracts;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        private IProduct _product;

        public ProductController(IProduct product)
        {
            _product = product;
        }
        public IActionResult Index()
        {
            List<ProductModel> products = _product.getProducts(); 
            return View(products);
        }
    }
}