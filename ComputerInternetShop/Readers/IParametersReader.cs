using System.Collections.Generic;
using ComputerInternetShop.Products;

namespace ComputerInternetShop.Readers
{
    public interface IParametersReader
    {
        IEnumerable<IReadOnlyDictionary<string, string>> GetProductsParameters<T>() where T : Product;
    }
}