namespace SmartRefridgerator
{

    public class Notifier
    {
        VegetableTracker vegetableTracker;
        public Notifier(VegetableTracker vegetableTracker)
        {
            this.vegetableTracker=vegetableTracker;
    }
        public string SendNotification()
        {
            var vegetableList = vegetableTracker.GetInsufficientVegetableQuantity();
            if (vegetableList.Count != 0)
                return "Required To Order";
            return "No order required";
        }

    }
}
