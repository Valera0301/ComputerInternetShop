namespace ComputerInternetShop.Products
{
    public class Processor : Product, ISocketType
    {
        public string SocketType { get;  }
        public int CoreCount { get;  }
        public double ClockSpeed { get;  }
        
        public Processor(int itemNumber, string name, double price, string socketType, int coreCount, double clockSpeed) : base(itemNumber, name, price)
        {
            SocketType = socketType;
            CoreCount = coreCount;
            ClockSpeed = clockSpeed;
        }
        
        public override string GetInformation()
        {
            return $"Processor: " +
                   $"\n\tItem Number: {ItemNumber}" +
                   $"\n\tName: {Name}" +
                   $"\n\tPrice: {Price}" +
                   $"\n\tSocket Type: {SocketType}" +
                   $"\n\tCore Count: {CoreCount}" +
                   $"\n\tClock Speed: {ClockSpeed}";
        }
    }
}