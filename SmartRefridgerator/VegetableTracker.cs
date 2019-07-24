using System.Collections.Generic;

namespace SmartRefridgerator
{
    public class VegetableTracker
    {
        Refrigerator refrigerator = new Refrigerator();
        ConfigurationManager configurationManager;
        public VegetableTracker(Refrigerator refrigerator, ConfigurationManager configurationManager)
        {
            this.refrigerator = refrigerator;
            this.configurationManager = configurationManager;
        }
        public List<KeyValuePair<Vegetable, int>> GetInsufficientVegetableQuantity()
        {
            var insufficientVegetableQuantityList = new List<KeyValuePair<Vegetable, int>>();
            //var vegetableTray = new VegetableTray();
            var vegetablesList = refrigerator.GetVegetableQuantity();
            //var inMemoryStorage = new InMemoryStorage();
            foreach(var vegetable in vegetablesList)
            {
               var vegetableMinimumQuantity = configurationManager.GetMinimumQuantity(vegetable.Key);
                if (vegetableMinimumQuantity >= vegetable.Value)
                    insufficientVegetableQuantityList.Add(vegetable);
            }
            
            return insufficientVegetableQuantityList;
        }
    }
}
