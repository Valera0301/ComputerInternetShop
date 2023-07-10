using System;
using System.Collections.Generic;
using ComputerInternetShop.Products;
using ComputerInternetShop.View;

namespace ComputerInternetShop.Presenters
{
    public class Presenter : IPresenter
    {
        private readonly IMenuView _menuView;
        private readonly IProductSearcher _productSearcher;

        private readonly Dictionary<ActionType, Func<IEnumerable<Product>>> _actionMethods;

        private void OnActionChoice(ActionType actionType)
        {
            if (actionType == ActionType.None)
            {
                Console.WriteLine("Невірний тип!");
                Disable();
                return;
            }

            if (_actionMethods.TryGetValue(actionType, out var actionMethod))
                _menuView.ShowResult(actionMethod.Invoke());
            else
                throw new ArgumentOutOfRangeException(nameof(actionType), actionType, null);

            Disable();
        }
        
        public Presenter(IMenuView menuView, IProductSearcher productSearcher)
        {
            _menuView = menuView;
            _productSearcher = productSearcher;

            _actionMethods = new Dictionary<ActionType, Func<IEnumerable<Product>>>()
            {
                {
                    ActionType.FindByItemNumber,
                    () => _productSearcher.FindProductByItemNumber(_menuView.GetItemNumber())
                },
                {
                    ActionType.FindByName, 
                    () => _productSearcher.FindProductByName(_menuView.GetName())
                },
                {ActionType.FindByPrice, () => _productSearcher.FindProductByPrice(_menuView.GetPrice())},
                {
                    ActionType.FindBySocketType,
                    () => _productSearcher.FindProductBySocketType(_menuView.GetSocketType())
                },
                {
                    ActionType.FindProductByChipset, 
                    () => _productSearcher.FindProductByChipset(_menuView.GetChipset())
                },
                {
                    ActionType.FindProductByMemoryType,
                    () => _productSearcher.FindProductByMemoryType(_menuView.GetMemoryType())
                },
                {
                    ActionType.FindProductByBusSpeed,
                    () => _productSearcher.FindProductByBusSpeed(_menuView.GetBusSpeed())
                },
                {
                    ActionType.FindProductByCoreCount,
                    () => _productSearcher.FindProductByCoreCount(_menuView.GetCoreCount())
                },
                {
                    ActionType.FindProductByClockSpeed,
                    () => _productSearcher.FindProductByClockSpeed(_menuView.GetClockSpeed())
                },
                {
                    ActionType.FindProductByCapacity,
                    () => _productSearcher.FindProductByCapacity(_menuView.GetCapacity())
                },
                {
                    ActionType.FindProductByFrequency,
                    () => _productSearcher.FindProductByFrequency(_menuView.GetFrequency())
                },
                {
                    ActionType.FindProductByModuleCount,
                    () => _productSearcher.FindProductByModuleCount(_menuView.GetModuleCount())
                },
                {
                    ActionType.FindProductBySpeed, 
                    () => _productSearcher.FindProductBySpeed(_menuView.GetSpeed())
                },
                {
                    ActionType.FindProductByInterfaceOfConnect,
                    () => _productSearcher.FindProductByInterfaceOfConnect(_menuView.GetInterfaceOfConnect())
                }
            };
        }

        public void Enable() => _menuView.ActionChoice += OnActionChoice;

        public void Disable() => _menuView.ActionChoice -= OnActionChoice;
    }
}