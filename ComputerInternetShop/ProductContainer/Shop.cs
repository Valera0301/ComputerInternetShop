using System.Collections.Generic;
using ComputerInternetShop.Factories;
using ComputerInternetShop.Products;
using ComputerInternetShop.Readers;

namespace ComputerInternetShop.ProductContainer
{
    public class Shop : IProductContainer
    {
        private readonly Dictionary<IEnumerable<IReadOnlyDictionary<string, string>>, IProductFactory> _productsParameter;
        private readonly List<Product> _products;

        public IEnumerable<Product> Products => _products;

        public Shop()
        {
            _productsParameter = new Dictionary<IEnumerable<IReadOnlyDictionary<string, string>>, IProductFactory>()
            {
                {
                    new ParametersReader().GetProductsParameters<Memory>(), new MemoryFactory()
                },
                {
                    new ParametersReader().GetProductsParameters<HardDrive>(), new HardDriveFactory()
                },
                {
                    new ParametersReader().GetProductsParameters<MotherBoard>(), new MotherboardFactory()
                },
                {
                    new ParametersReader().GetProductsParameters<Processor>(), new ProcessorFactory()
                }
            };
            
            _products = new List<Product>();
            InitializeProducts();
        }

        private void InitializeProducts()
        {
            foreach (var (reader, value) in _productsParameter)
            {
                foreach (var dictionary in reader)
                {
                    _products.Add(value.CreateProduct(dictionary));
                }
            }
        }
    }
}