namespace ComputerInternetShop.Products
{
    public class MotherBoard : Product , ISocketType, IMemoryType
    {
        public string SocketType { get; }
        public string Chipset { get; }
        public int ProcessorCount { get; }
        public string MemoryType { get; }
        public int BusSpeed { get;}

        public MotherBoard(int itemNumber, string name, double price, string socketType, string chipset, int processorCount, string memoryType, int busSpeed) : base(itemNumber, name, price)
        {
            SocketType = socketType;
            Chipset = chipset;
            ProcessorCount = processorCount;
            MemoryType = memoryType;
            BusSpeed = busSpeed;
        }
        
        public override string GetInformation()
        {
            return $"MotherBoard: " +
                   $"\n\tItem Number: {ItemNumber}" +
                   $"\n\tName: {Name}" +
                   $"\n\tPrice: {Price}" +
                   $"\n\tSocket Type: {SocketType}" +
                   $"\n\tChipset: {Chipset}" +
                   $"\n\tProcessor Count: {ProcessorCount}" +
                   $"\n\tMemory Type: {MemoryType}" +
                   $"\n\tBus speed: {BusSpeed}";
        }
    }

    public interface ISocketType
    { 
        string SocketType { get; }
    }

    public interface IMemoryType
    {
        string MemoryType { get; }
    }
}