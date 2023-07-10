using System;
using System.Collections.Generic;
using ComputerInternetShop.Products;
using ComputerInternetShop.Readers;

namespace ComputerInternetShop.Factories
{
    public class MotherboardFactory : IProductFactory
    {
        private IReadOnlyDictionary<string, string> _parameters;
        
        public Product CreateProduct(IReadOnlyDictionary<string, string> parameters)
        {
            _parameters = parameters;
            return new MotherBoard(GetItemNumber(), GetName(), GetPrice(), GetSocketType(), GetChipset(), GetProcessorCount(), GetMemoryType(), GetBusSpeed());
        }

        private int GetItemNumber() =>
            _parameters.ContainsKey(DataKey.ItemNumberKey) ? Convert.ToInt32(_parameters[DataKey.ItemNumberKey]) : 0;
        
        private int GetBusSpeed() => 
            _parameters.ContainsKey(DataKey.BusSpeedKey) ? Convert.ToInt32(_parameters[DataKey.BusSpeedKey]) : 0;

        private string GetMemoryType() => 
            _parameters.ContainsKey(DataKey.MemoryTypeKey) ? _parameters[DataKey.MemoryTypeKey] : string.Empty;

        private int GetProcessorCount() => 
            _parameters.ContainsKey(DataKey.ProcessorCountKey) ? Convert.ToInt32(_parameters[DataKey.ProcessorCountKey]) : 0;

        private string GetChipset() => 
            _parameters.ContainsKey(DataKey.ChipsetKey) ? _parameters[DataKey.ChipsetKey] : string.Empty;

        private string GetSocketType() => 
            _parameters.ContainsKey(DataKey.SocketTypeKey) ? _parameters[DataKey.SocketTypeKey] : string.Empty;

        private double GetPrice() => 
            _parameters.ContainsKey(DataKey.PriceKey) ? Convert.ToDouble(_parameters[DataKey.PriceKey]) : 0;

        private string GetName() => 
            _parameters.ContainsKey(DataKey.NameKey) ? _parameters[DataKey.NameKey] : string.Empty;

        private static class DataKey
        {
            internal const string ItemNumberKey = "ItemNumber";
            internal const string NameKey = "Name";
            internal const string PriceKey = "Price";
            internal const string SocketTypeKey = "SocketType";
            internal const string ChipsetKey = "Chipset";
            internal const string ProcessorCountKey = "ProcessorCount";
            internal const string MemoryTypeKey = "MemoryType";
            internal const string BusSpeedKey = "BusSpeed";
        }
    }
}