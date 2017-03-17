using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutonomousDemo
{
    public class DeterminePath
    {
        Road road = new Road(27);

        public Velocity CalculateDriveVelocity(Vehicle vehicle)
        {
            if (vehicle.VehicleMotion.CurrentVelocity.Speed < road.SpeedLimit)
            {
                return vehicle.VehicleMotion.Accelerate(vehicle.VehicleMotion.CurrentVelocity);
            }
            return vehicle.VehicleMotion.CurrentVelocity;
        }

        public Velocity StoppingDistance(Vehicle vehicle, double destinationDistance)
        {
            var stoppingDistance = destinationDistance - vehicle.VehicleMotion.DistanceTraveled;
            if (stoppingDistance < vehicle.VehicleMotion.CurrentVelocity.Speed
                || stoppingDistance >= vehicle.VehicleMotion.CurrentVelocity.Speed - 10)
            {
                //slow down faster
                var slowerVelocity = vehicle.VehicleMotion.Decelerate(vehicle.VehicleMotion.CurrentVelocity);
                vehicle.VehicleMotion.Decelerate(slowerVelocity);
            }
            //need a range maybe
            else if (stoppingDistance == vehicle.VehicleMotion.CurrentVelocity.Speed
                || stoppingDistance > vehicle.VehicleMotion.CurrentVelocity.Speed && stoppingDistance <= vehicle.VehicleMotion.CurrentVelocity.Speed + 10) //10m/s
            {
                return vehicle.VehicleMotion.Decelerate(vehicle.VehicleMotion.CurrentVelocity);
            }

            throw new NotImplementedException();
        }
    }
}
