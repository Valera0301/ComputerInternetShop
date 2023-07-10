using System;
using System.Collections.Generic;
using System.IO;
using ComputerInternetShop.Products;

namespace ComputerInternetShop.Readers
{
    public class ParametersReader : IParametersReader
    {
        private readonly string _pathToFile = "/Users/denys/RiderProjects/ComputerInternetShop/ComputerInternetShop/Resources/";
        private readonly Dictionary<Type, string> _dictionaryPath;
        private readonly List<Dictionary<string, string>> _parameters = new ();

        public ParametersReader()
        {
            _dictionaryPath = new Dictionary<Type, string>()
            {
                {
                    typeof(MotherBoard), "MotherBoard.txt"
                },                
                {
                    typeof(Processor), "Processors.txt"
                },
                {
                    typeof(HardDrive), "HardDrives.txt"
                },
                {
                    typeof(Memory), "Memories.txt"
                }
            };
        }

        private void InitializeParameters(string pathToFile)
        {
            using StreamReader sr = new StreamReader(pathToFile);
            string line;
            Dictionary<string, string> itemData = new Dictionary<string, string>();

            while ((line = sr.ReadLine()) != null)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    _parameters.Add(itemData);
                    itemData = new Dictionary<string, string>();
                }
                else
                {
                    string[] parts = line.Split(':');

                    if (parts.Length == 2)
                    {
                        string key = parts[0].Trim();
                        string value = parts[1].Trim();

                        itemData.Add(key, value);
                    }
                }
            }
            _parameters.Add(itemData);
        }

        public IEnumerable<IReadOnlyDictionary<string, string>> GetProductsParameters<T>() where T : Product
        {
            
            InitializeParameters($"{_pathToFile}{_dictionaryPath[typeof(T)]}" );
            return _parameters;
        }
    }
}