using System.Collections.Generic;
using ComputerInternetShop.Products;

namespace ComputerInternetShop.Factories
{
    public interface IProductFactory
    {
        Product CreateProduct(IReadOnlyDictionary<string, string> parameters);
    }
}