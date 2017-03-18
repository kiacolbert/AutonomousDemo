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

        public void Run(Vehicle vehicle,double distance)
        {
            while (true)
            {
                ProcessInput(vehicle, distance);
                DisplayVehicleStats(vehicle);
                Console.ReadLine();
            }
        }

        private void ProcessInput(Vehicle vehicle, double distance)
        {
            var updatedVelocity = vehicle.VehicleMotion.Accelerate(vehicle.VehicleMotion.CurrentVelocity);
            vehicle.VehicleMotion.CurrentVelocity = updatedVelocity;
            var updatedPosition = vehicle.Position.TravelForOneSecond(vehicle.VehicleMotion.CurrentVelocity);
            vehicle.Position = updatedPosition;
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
