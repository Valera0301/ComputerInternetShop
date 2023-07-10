using System;
using System.Collections.Generic;
using ComputerInternetShop.Products;

namespace ComputerInternetShop.View
{
    public interface IMenuView
    {
        void ShowAction();
        void GetAction();
        void ShowResult(IEnumerable<Product> productsResult);

        event Action<ActionType> ActionChoice;
        string GetName();
        int GetItemNumber();
        int GetPrice();
        string GetSocketType();
        string GetChipset();
        string GetMemoryType();
        int GetBusSpeed();
        int GetCoreCount();
        double GetClockSpeed();
        int GetCapacity();
        int GetFrequency();
        int GetModuleCount();
        int GetSpeed();
        string GetInterfaceOfConnect();
    }
}