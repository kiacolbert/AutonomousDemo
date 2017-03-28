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
    }
}
