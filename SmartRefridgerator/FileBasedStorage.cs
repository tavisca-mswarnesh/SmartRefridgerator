using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace SmartRefridgerator
{
    class FileBasedStorage : IStorage
    {
        //string json = JsonConvert.SerializeObject();
        private Dictionary<Vegetable, int> _vegetableQuantities = new Dictionary<Vegetable, int>();
        public int GetVegetableMinimumQuantity(Vegetable vegetable)
        {
            if (_vegetableQuantities.ContainsKey(vegetable))
            {
                return _vegetableQuantities[vegetable];
            }

            throw new VegetableNotFoundException();
        }

        public void SetVegetableMinimumQuantity(Vegetable vegetable, int quantity)
        {
            if (_vegetableQuantities.ContainsKey(vegetable))
            {
                _vegetableQuantities[vegetable] = quantity;
            }
            else
            {
                _vegetableQuantities.Add(vegetable, quantity);
            }
        }
    }
}
