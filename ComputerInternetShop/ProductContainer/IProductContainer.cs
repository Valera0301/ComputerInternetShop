using System.Collections.Generic;
using ComputerInternetShop.Products;

namespace ComputerInternetShop.ProductContainer
{
    public interface IProductContainer
    {
        IEnumerable<Product> Products { get; }
    }
}