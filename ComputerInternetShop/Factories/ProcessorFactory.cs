using System;
using System.Collections.Generic;
using ComputerInternetShop.Products;
using ComputerInternetShop.Readers;

namespace ComputerInternetShop.Factories
{
    public class ProcessorFactory : IProductFactory
    {
        private IReadOnlyDictionary<string, string> _parameters;

        public Product CreateProduct(IReadOnlyDictionary<string, string> parameters)
        {
            _parameters = parameters;
            return new Processor(GetItemNumber(), GetName(), GetPrice(), GetSocketType(), GetCoreCount(), GetClockSpeed());
        }

        private double GetClockSpeed() =>
            _parameters.ContainsKey(DataKey.ClockSpeedKey) ? Convert.ToDouble(_parameters[DataKey.ClockSpeedKey]) : 0;
        
        private int GetCoreCount() =>
            _parameters.ContainsKey(DataKey.CoreCountKey) ? Convert.ToInt32(_parameters[DataKey.CoreCountKey]) : 0;

        private string GetSocketType() => 
            _parameters.ContainsKey(DataKey.SocketTypeKey) ? _parameters[DataKey.SocketTypeKey] : string.Empty;
        
        private double GetPrice() => 
            _parameters.ContainsKey(DataKey.PriceKey) ? Convert.ToDouble(_parameters[DataKey.PriceKey]) : 0;

        private string GetName() => 
            _parameters.ContainsKey(DataKey.NameKey) ? _parameters[DataKey.NameKey] : string.Empty;
        
        private int GetItemNumber() =>
            _parameters.ContainsKey(DataKey.ItemNumberKey) ? Convert.ToInt32(_parameters[DataKey.ItemNumberKey]) : 0;
        
        private static class DataKey
        {
            internal const string ItemNumberKey = "ItemNumber";
            internal const string NameKey = "Name";
            internal const string PriceKey = "Price";
            internal const string SocketTypeKey = "SocketType";
            internal const string CoreCountKey = "CoreCount";
            internal const string ClockSpeedKey = "ClockSpeed";
        }
    }
}