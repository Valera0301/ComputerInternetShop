using ComputerInternetShop.Locator;
using ComputerInternetShop.Presenters;
using ComputerInternetShop.View;

namespace ComputerInternetShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IServiceLocator serviceLocator = new ServiceLocator();
            var menu = serviceLocator.GetService<IMenuView>();
            var presenter = serviceLocator.GetService<IPresenter>();
            presenter.Enable();
            menu.ShowAction();
            menu.GetAction();
        }
    }
}