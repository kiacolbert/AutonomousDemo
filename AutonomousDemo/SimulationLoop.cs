using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutonomousDemo
{
    public class SimulationLoop
    {

        public void Run(Vehicle vehicle, double distance)
        {
            while (true)
            {
                ProcessInput(vehicle, distance);
                Thread.Sleep(1000); //just here so I can see the output
                DisplayVehicleStats(vehicle);
            }
        }

        private void ProcessInput(Vehicle vehicle, double distance)
        {
            vehicle.VehicleMotion.Accelerate(vehicle.VehicleMotion.CurrentVelocity);
           // vehicle.VehicleMotion.Decelerate(vehicle.VehicleMotion.CurrentVelocity);
            //change position
            
        }

        private void DisplayVehicleStats(Vehicle vehicle)
        {
            Speedometer.SpeedometerDisplay(vehicle);
            Console.WriteLine($"Vehicle's Position {vehicle.Position.XCoordinate},{vehicle.Position.YCoordinate}");
        }    
    }
}
