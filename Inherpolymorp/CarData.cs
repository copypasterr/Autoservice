namespace Inherpolymorp
{
    public class CarData
    {
        public static Engine EngineInfo()
        {
            Engine engine = new Engine()
            {
                OilLevel = 5,
                FuelLevel = 20,
                FuelTankСapacity = 64
            };
            return engine;
        }

        public static Wheel WheelInfo()
        {
            Wheel wheel = new Wheel()
            {
                WheelQuantity = 4,
                Width = 205,
                Diameter = 17,
                Profile = 55,
                //Transmission = 2
            };
            return wheel;
        }
    }
}
