namespace Inherpolymorp
{
    public class Car:Vehicle
    {
        public Car() { }
        public bool Workingstatus { get; set; }
        public int Transmission { get; set; }
        public Car(bool Workingstatus, int Transmission)
        {
            this.Workingstatus = Workingstatus;
            if (Transmission <=-1) this.Transmission = 1;
            else if (Transmission >=5) this.Transmission = 4;
            else this.Transmission = Transmission;
        }
    }
}
