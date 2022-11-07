using System;

namespace Inherpolymorp
{
    public class CarDiagnostic
    {
        private bool OilCheck (double a)
        {
            if (a < 4) 
            {
                Console.WriteLine(MessageReport.LowOil());
                return false; 
            }

            else if (a > 5)
            {
                Console.WriteLine(MessageReport.HighOil());
                return false;
            }

            else return true;
        }

        private bool FuelLevelCheck(double l)
        {
            if (l < 0.1)
            {
                Console.WriteLine(MessageReport.LowFuel());
                return false;
            }

            else
                return true;
        }

        private bool FuelCapacityCheck(double l)
        {
            if (l > CarData.EngineInfo().FuelTankСapacity)
            {
                Console.WriteLine(MessageReport.LowFuel());
                return false;
            }

            else
                return true;
        }

        private bool EngineCheck(double OilLevel, double FuelLevel)
        {
            var Oil = OilCheck (OilLevel);
            var FuelL = FuelLevelCheck (FuelLevel);
            var FuelC = FuelCapacityCheck(CarData.EngineInfo().FuelTankСapacity);

            if (FuelL && Oil && FuelC)
                return true;

            else return false;
        }

        private bool CarIsWorking()
        {
            var OilLevel = CarData.EngineInfo().OilLevel;
            var FuelLevel = CarData.EngineInfo().FuelLevel;

            return EngineCheck(OilLevel, FuelLevel);
        }

        public int Starter(int TransmissionLevel)
        {
            int Speed = 0;
            bool Status = CarIsWorking();
            if (Status && TransmissionLevel == 1)
                Speed = 20;
            else if (Status && TransmissionLevel == 2)
                Speed = 40;
            else if (Status && TransmissionLevel == 3)
                Speed = 60;
            else if (Status && TransmissionLevel == 4)
                Speed = 80;
            else if (Status && TransmissionLevel == 5)
                Speed = 100;
            else if (Status && TransmissionLevel == -1) 
            { 
                Speed = -5; 
                Console.WriteLine(MessageReport.Reverse()); 
            }
            else if (Status && TransmissionLevel == 0)
            {
                Speed = 0; Console.WriteLine("Reverse is engaged");
            }

            return Speed;
        }

    }
}
