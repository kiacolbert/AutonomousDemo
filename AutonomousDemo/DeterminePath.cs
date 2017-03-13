using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutonomousDemo
{
    public class DeterminePath
    {
        //these don't belong here
        VehicleMotion vehicleMotion = new VehicleMotion(new Velocity(0));
        DeterminePath determinePath = new DeterminePath();
        Road road = new Road(27);

        Velocity displacement = new Velocity(3.4);
        
        public Velocity CalculateDriveVelocity()
        {
            if (vehicleMotion.CurrentVelocity.Speed < road.SpeedLimit)
            {
                vehicleMotion.DistanceTraveled += displacement.Speed;
                return vehicleMotion.CurrentVelocity + displacement;
            }
            else
            {
                return vehicleMotion.CurrentVelocity;
            }
        }
        public Velocity StoppingDistance(double destinationDistance)
        {  
          var stoppingDistance = destinationDistance - vehicleMotion.DistanceTraveled;
            if(stoppingDistance > vehicleMotion.CurrentVelocity.Speed)
            {
                throw new NotImplementedException();
            }
            return vehicleMotion.CurrentVelocity - displacement;
        }
    }
}
