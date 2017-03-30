using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutonomousDemo
{
    public class DeterminePath
    {
        private double Distance;
        double _x, _y;

        public DeterminePath() { }

        public DeterminePath(double distance)
        {
            this.Distance = distance;
        }

        Road road = new Road(27);

        public Velocity CalculateDriveVelocity(Vehicle vehicle)
        {
            if (vehicle.VehicleMotion.CurrentVelocity.Speed < road.SpeedLimit)
            {
                return vehicle.VehicleMotion.Accelerate(vehicle.VehicleMotion.CurrentVelocity);
            }
            return vehicle.VehicleMotion.CurrentVelocity;
        }

        public double CalculateDistanceTraveled(Vehicle vehicle)
        {
            _x = vehicle.Position.XCoordinate * vehicle.Position.XCoordinate;
            _y = vehicle.Position.YCoordinate * vehicle.Position.YCoordinate;
            return Math.Sqrt(_x + _y);

        }
        //when speed should be zero
        public bool IsDestinationReached(double distance, Vehicle vehicle)
        {
            var sqrtXY = CalculateDistanceTraveled(vehicle);
            var distancesqrd = distance * distance;
            return sqrtXY == distancesqrd;
        }
    }
}
