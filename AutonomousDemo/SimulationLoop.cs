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
        public Position lastPosition = new Position();

        public void Run(Vehicle vehicle, double distance) {

            DeterminePath determinePath = new DeterminePath(distance);

            vehicle.VehicleMotion.TravelDistance = distance;

            while (vehicle.VehicleMotion.TravelDistance >= vehicle.VehicleMotion.DistanceTraveled)
            {
                ProcessInput(vehicle, distance);
                
                DisplayVehicleStats(vehicle);

                vehicle.VehicleMotion.DistanceTraveled = determinePath.CalculateDistanceTraveled(vehicle);    
                           
                Console.ReadLine();
            }

        }

        private Velocity ProcessInput(Vehicle vehicle, double distance)
        {
            var updatedVelocity = vehicle.VehicleMotion.Accelerate(vehicle.VehicleMotion.CurrentVelocity);
            vehicle.VehicleMotion.CurrentVelocity = updatedVelocity;
            lastPosition = vehicle.Position.TravelForOneSecond(vehicle.VehicleMotion.CurrentVelocity, lastPosition);
            vehicle.Position = lastPosition;
            var direction = vehicle.Position.CalculateDirection(lastPosition, vehicle.VehicleMotion.CurrentVelocity);
            
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
