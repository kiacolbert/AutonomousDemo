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
        public Velocity previousVelocity;

        public void Run(Vehicle vehicle,double distance)
        {
            previousVelocity = vehicle.VehicleMotion.CurrentVelocity;

            while (true)
            {
                 previousVelocity = ProcessInput(vehicle, distance, previousVelocity);
                
                DisplayVehicleStats(vehicle);
               
                Console.ReadLine();
            }
        }

        private Velocity ProcessInput(Vehicle vehicle, double distance, Velocity previousVelocity)
        {
            var updatedVelocity = vehicle.VehicleMotion.Accelerate(vehicle.VehicleMotion.CurrentVelocity);
            vehicle.VehicleMotion.CurrentVelocity = updatedVelocity;
            var updatedPosition = vehicle.Position.TravelForOneSecond(vehicle.VehicleMotion.CurrentVelocity, previousVelocity);
            vehicle.Position = updatedPosition;
            // vehicle.VehicleMotion.Decelerate(vehicle.VehicleMotion.CurrentVelocity);
            //change position
            return vehicle.VehicleMotion.CurrentVelocity;
            
        }

        private void DisplayVehicleStats(Vehicle vehicle)
        {
            Speedometer.SpeedometerDisplay(vehicle);
            Console.WriteLine($"Vehicle's Position {vehicle.Position.XCoordinate},{vehicle.Position.YCoordinate}");
        }    
    }
}
