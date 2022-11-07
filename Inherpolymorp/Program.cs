using Inherpolymorp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoservice
{
    internal class Program
    {
       static void Main(string[] args)
        {
            Car auto = new Car();
            do
            {
                auto.Transmission = Int32.Parse(Console.ReadLine());
                CarDiagnostic worker = new CarDiagnostic();
                int speed = worker.Starter(auto.Transmission);
                try {
                Console.WriteLine($"Speed is:{speed}");
                }
                catch (Exception) { }
            } while (auto.Transmission != 0);
        }
    }
}
