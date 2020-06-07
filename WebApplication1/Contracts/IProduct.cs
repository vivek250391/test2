using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Contracts
{
    public interface IProduct
    {
        List<ProductModel> getProducts();
    }
}
