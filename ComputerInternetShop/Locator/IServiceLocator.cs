namespace ComputerInternetShop.Locator
{
    public interface IServiceLocator
    {
        T GetService<T>();
    }
}