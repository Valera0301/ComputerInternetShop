using System;
using System.Collections.Generic;
using ComputerInternetShop.Presenters;
using ComputerInternetShop.ProductContainer;
using ComputerInternetShop.View;

namespace ComputerInternetShop.Locator
{
    public class ServiceLocator : IServiceLocator
    {
        private readonly Dictionary<object, object> _services;

        public ServiceLocator()
        {
            _services = new Dictionary<object, object>
            {
                {
                    typeof(IProductSearcher), new ProductSearcher(new Shop())
                },
                {
                    typeof(IMenuView), new ConsoleMenu()
                }
            };
            
            _services.Add(typeof(IPresenter), new Presenter(GetService<IMenuView>(), GetService<IProductSearcher>()));
        }

        public T GetService<T>()
        {
            try
            {
                return (T)_services[typeof(T)];
            }
            catch (KeyNotFoundException)
            {
                throw new ApplicationException("Запрашиваемый сервис не зарегистрирован!");
            }
        }
    }
}