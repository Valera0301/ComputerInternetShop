using System;
using System.Collections.Generic;
using ComputerInternetShop.Products;

namespace ComputerInternetShop.View
{
    public class ConsoleMenu : IMenuView
    {
        public void ShowResult(IEnumerable<Product> productsResult)
        {
            foreach (var product in productsResult)
            {
                Console.WriteLine(product.GetInformation());
            }
        }

        public event Action<ActionType> ActionChoice;
        
        public int GetItemNumber()
        {
            Console.Write("Введіть номенклантурний номер: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        
        public string GetName()
        {
            Console.Write("Введіть назву: ");
            return Console.ReadLine();
        }

        public int GetPrice()
        {
            Console.Write("Введіть максимальну ціну: ");
            return Convert.ToInt32(Console.ReadLine());
            
        }

        public string GetSocketType()
        {
            Console.Write("Введіть тип сокету: ");
            return Console.ReadLine();
        }

        public string GetChipset()
        {
            Console.Write("Введіть чіпсет: ");
            return Console.ReadLine();
        }

        public string GetMemoryType()
        {
            Console.Write("Введіть тип оперативної пам'ять: ");
            return Console.ReadLine();
        }

        public int GetBusSpeed()
        {
            Console.Write("Введіть частоту системної шини: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public int GetCoreCount()
        {
            Console.Write("Введіть кількість ядер: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public double GetClockSpeed()
        {
            Console.Write("Введіть тактовій частоті: ");
            return Convert.ToDouble(Console.ReadLine());
        }

        public int GetCapacity()
        {
            Console.Write("Введіть місткість: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public int GetFrequency()
        {
            Console.Write("Введіть частоту: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public int GetModuleCount()
        {
            Console.Write("Введіть кількості планок: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public int GetSpeed()
        {
            Console.Write("Введіть швидкість: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public string GetInterfaceOfConnect()
        {
            Console.Write("Введіть інтерфейс підключення: ");
            return Console.ReadLine();
        }

        public void ShowAction()
        {
            Console.WriteLine("1) Пошук по номенклантурному номеру");
            Console.WriteLine("2) Пошук по назві");
            Console.WriteLine("3) Пошук по ціні");
            Console.WriteLine("4) Пошук по типу скоету");
            Console.WriteLine("5) Пошук по чипсету");
            Console.WriteLine("6) Пошук по типу оперативної пам'ять");
            Console.WriteLine("7) Пошук по частоті системної шини");
            Console.WriteLine("8) Пошук по кількістю ядер");
            Console.WriteLine("9) Пошук по тактовій частоті");
            Console.WriteLine("10) Пошук по місткості");
            Console.WriteLine("11) Пошук по частоті");
            Console.WriteLine("12) Пошук по кількості планок");
            Console.WriteLine("13) Пошук по швидкості");
            Console.WriteLine("14) Пошук по інтерфейсу підключення");
            Console.WriteLine("-1) Для виходу");
        }

        public void GetAction()
        {
            Console.Write("Оберіть дію: ");
            string actionNumber = Console.ReadLine();
            ActionChoice?.Invoke((ActionType)int.Parse(actionNumber));
        }
    }
}