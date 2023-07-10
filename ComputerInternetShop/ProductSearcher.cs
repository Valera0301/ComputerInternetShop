using System;
using System.Collections.Generic;
using System.Linq;
using ComputerInternetShop.ProductContainer;
using ComputerInternetShop.Products;

namespace ComputerInternetShop
{
    public class ProductSearcher : IProductSearcher
    {
        private readonly IProductContainer _container;

        public ProductSearcher(IProductContainer container)
        {
            _container = container;
        }

        public IEnumerable<Product> FindProductByItemNumber(int itemNumber) => 
            _container.Products.Where(product => product.ItemNumber == itemNumber);

        public IEnumerable<Product> FindProductByName(string name) => 
            _container.Products.Where(product => product.Name == name);

        public IEnumerable<Product> FindProductByPrice(int maxPrice) =>
            _container.Products.Where(product => product.Price < maxPrice);

        public IEnumerable<Product> FindProductBySocketType(string socketType)
        {
            var result = new List<Product>();
            
            foreach (var product in _container.Products)
            {
                if (product is not ISocketType socketTypeProduct) 
                    continue;
                if (socketTypeProduct.SocketType == socketType) 
                    result.Add(product);
            }

            return result;
        }
        
        public IEnumerable<Product> FindProductByChipset(string chipSet)
        {
            var result = new List<Product>();
            
            foreach (var product in _container.Products)
            {
                if (product is not MotherBoard motherBoard) 
                    continue;
                if (motherBoard.Chipset == chipSet) 
                    result.Add(product);
            }

            return result;
        }

        public IEnumerable<Product> FindProductByMemoryType(string memoryType)
        {
            var result = new List<Product>();
            
            foreach (var product in _container.Products)
            {
                if (product is not IMemoryType memoryTypeProduct) 
                    continue;
                if (memoryTypeProduct.MemoryType == memoryType) 
                    result.Add(product);
            }

            return result;
        }

        public IEnumerable<Product> FindProductByBusSpeed(int busSpeed)
        {
            var result = new List<Product>();
            
            foreach (var product in _container.Products)
            {
                if (product is not MotherBoard motherBoard) 
                    continue;
                if (motherBoard.BusSpeed == busSpeed) 
                    result.Add(product);
            }

            return result;
        }

        public IEnumerable<Product> FindProductByCoreCount(int coreCount)
        {
            var result = new List<Product>();
            
            foreach (var product in _container.Products)
            {
                if (product is not Processor processor) 
                    continue;
                if (processor.CoreCount == coreCount) 
                    result.Add(product);
            }

            return result;
        }

        public IEnumerable<Product> FindProductByClockSpeed(double clockSpeed)
        {
            var result = new List<Product>();
            
            foreach (var product in _container.Products)
            {
                if (product is not Processor processor) 
                    continue;
                if (Math.Abs(processor.ClockSpeed - clockSpeed) < 0.001) 
                    result.Add(product);
            }

            return result;
        }

        public IEnumerable<Product> FindProductByCapacity(int capacity)
        {
            var result = new List<Product>();
            
            foreach (var product in _container.Products)
            {
                if (product is not ICapacity capacityProduct) 
                    continue;
                if (capacityProduct.Capacity == capacity) 
                    result.Add(product);
            }

            return result;
        }

        public IEnumerable<Product> FindProductByFrequency(int frequency)
        {
            var result = new List<Product>();
            
            foreach (var product in _container.Products)
            {
                if (product is not Memory memoryProduct) 
                    continue;
                if (memoryProduct.Frequency == frequency) 
                    result.Add(product);
            }

            return result;
        }

        public IEnumerable<Product> FindProductByModuleCount(int moduleCount)
        {
            var result = new List<Product>();
            
            foreach (var product in _container.Products)
            {
                if (product is not Memory memoryProduct) 
                    continue;
                if (memoryProduct.ModuleCount == moduleCount) 
                    result.Add(product);
            }

            return result;
        }

        public IEnumerable<Product> FindProductBySpeed(int speed)
        {
            var result = new List<Product>();
            
            foreach (var product in _container.Products)
            {
                if (product is not HardDrive hardDriveProduct) 
                    continue;
                if (hardDriveProduct.Speed == speed) 
                    result.Add(product);
            }

            return result;
        }

        public IEnumerable<Product> FindProductByInterfaceOfConnect(string interfaceOfConnect)
        {
            var result = new List<Product>();
            
            foreach (var product in _container.Products)
            {
                if (product is not HardDrive hardDriveProduct) 
                    continue;
                if (hardDriveProduct.InterfaceOfConnect == interfaceOfConnect) 
                    result.Add(product);
            }

            return result;
        }
    }
}