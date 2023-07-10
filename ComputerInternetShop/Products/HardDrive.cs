namespace ComputerInternetShop.Products
{
    public class HardDrive : Product, ICapacity
    {
        public int Capacity { get;  }
        public int Speed { get;  }
        public string InterfaceOfConnect { get; }
        
        public HardDrive(int itemNumber, string name, double price, int capacity, int speed, string interfaceOfConnect) : base(itemNumber, name, price)
        {
            Capacity = capacity;
            Speed = speed;
            InterfaceOfConnect = interfaceOfConnect;
        }

        public override string GetInformation()
        {
            return $"Hard Drive: " +
                   $"\n\tItem Number: {ItemNumber}" +
                   $"\n\tName: {Name}" +
                   $"\n\tPrice: {Price}" +
                   $"\n\tCapacity: {Capacity}" +
                   $"\n\tSpeed: {Speed}" +
                   $"\n\tInterfaceOfConnect: {InterfaceOfConnect}";
        }
    }

    public interface ICapacity
    {
        int Capacity { get;  }
    }
}