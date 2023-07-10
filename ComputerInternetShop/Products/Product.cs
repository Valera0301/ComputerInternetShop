namespace ComputerInternetShop.Products
{
    public abstract class Product
    {
        public int ItemNumber { get; }
        public string Name { get; }
        public double Price { get;  }

        protected Product(int itemNumber, string name, double price)
        {
            ItemNumber = itemNumber;
            Name = name;
            Price = price;
        }

        public abstract string GetInformation();
    }
}