using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutonomousDemo
{
    public class DeterminePath
    {
        public void CalculateTravelTime(double meters, Road road, VehicleMotion vehicleMotion)
        {

            if (vehicleMotion.CurrentVelocity.Speed == 0)
            {
                var accelerationTime = 4.0;
                var constantAccelerationDistancePerSecond = road.SpeedLimit/accelerationTime; //travel this many meters per second

                var nonAcceleratingdistance = meters - road.SpeedLimit;
                var nonAcceleratingTime = nonAcceleratingdistance / road.SpeedLimit;
                var totalTime = accelerationTime + nonAcceleratingTime;

                //    vehicleMotion.ConstantAcceleration(travelTime, finalVelocity, vehicleMotion.CurrentVelocity);
            }
        }
    }
}
