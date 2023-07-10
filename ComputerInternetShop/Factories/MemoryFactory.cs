using System;
using System.Collections.Generic;
using ComputerInternetShop.Products;
using ComputerInternetShop.Readers;

namespace ComputerInternetShop.Factories
{
    public class MemoryFactory : IProductFactory
    {
        private IReadOnlyDictionary<string, string> _parameters;

        public Product CreateProduct(IReadOnlyDictionary<string, string> parameters)
        {
            _parameters = parameters;
            return new Memory(GetItemNumber(), GetName(), GetPrice(), GetCapacity(), GetTypeMemory(), GetFrequency(), GetModuleCount());
        }
        
        private class DataKey
        {
            internal const string ItemNumberKey = "ItemNumber";
            internal const string NameKey = "Name";
            internal const string PriceKey = "Price";
            internal const string CapacityKey = "Capacity";
            internal const string TypeKey = "MemoryType";
            internal const string FrequencyKey = "Frequency";
            internal const string ModuleCountKey = "ModuleCount";
        }
        
        private int GetModuleCount() =>
            _parameters.ContainsKey(DataKey.ModuleCountKey) ? Convert.ToInt32(_parameters[DataKey.ModuleCountKey]) : 0;

        private int GetFrequency() =>
            _parameters.ContainsKey(DataKey.FrequencyKey) ? Convert.ToInt32(_parameters[DataKey.FrequencyKey]) : 0;

        private string GetTypeMemory() =>
            _parameters.ContainsKey(DataKey.TypeKey) ? _parameters[DataKey.TypeKey] : string.Empty;
        
        private int GetCapacity() =>
            _parameters.ContainsKey(DataKey.CapacityKey) ? Convert.ToInt32(_parameters[DataKey.CapacityKey]) : 0;

        private double GetPrice() => 
            _parameters.ContainsKey(DataKey.PriceKey) ? Convert.ToDouble(_parameters[DataKey.PriceKey]) : 0;

        private string GetName() => 
            _parameters.ContainsKey(DataKey.NameKey) ? _parameters[DataKey.NameKey] : string.Empty;
        
        private int GetItemNumber() =>
            _parameters.ContainsKey(DataKey.ItemNumberKey) ? Convert.ToInt32(_parameters[DataKey.ItemNumberKey]) : 0;
    }
}