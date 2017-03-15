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
                return vehicle.VehicleMotion.AccelerateVelocityPerSecond(vehicle.VehicleMotion.CurrentVelocity);
            }
                return vehicle.VehicleMotion.CurrentVelocity;
        }
        //just needed to save now
        //public Velocity StoppingDistance(Vehicle vehicle, double destinationDistance)
        //{  
        //  var stoppingDistance = destinationDistance - vehicle.VehicleMotion.DistanceTraveled;
        //    if(stoppingDistance > vehicle.VehicleMotion.CurrentVelocity.Speed)
        //    {
        //        throw new NotImplementedException();
        //    }
        //    return vehicle.VehicleMotion.CurrentVelocity - displacement;
        //}
    }
}
