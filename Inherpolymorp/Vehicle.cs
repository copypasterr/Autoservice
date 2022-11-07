using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherpolymorp
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public int WheelQuantity { get; set; }
        /// <summary>
        /// false gasoline, true diesel
        /// </summary>
        public double FuelLevel { get; set; }
        public double FuelTankСapacity { get; set; }
    }
}
