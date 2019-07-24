using System.Collections.Generic;

namespace SmartRefridgerator
{
    public class Refrigerator
    {
        private VegetableTray _vegetableTray = new VegetableTray();

        private ConfigurationManager _configurationManager = new ConfigurationManager(new InMemoryStorage());
        
        public void AddVegetable(Vegetable vegetable, int quantity)
        {
            _vegetableTray.Add(vegetable, quantity);
        }

        public void TakeOutVegetable(Vegetable vegetable, int quantity)
        {
            _vegetableTray.TakeOut(vegetable, quantity);

            var vegetableQuantity = _vegetableTray.GetVegetableQuantity();
        }

        //Testing code
        public List<KeyValuePair<Vegetable, int>> GetVegetableQuantity()
        {
            return _vegetableTray.GetVegetableQuantity();
        }


    }
}
