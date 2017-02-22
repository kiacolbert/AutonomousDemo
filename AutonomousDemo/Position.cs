using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutonomousDemo
{
    public class Position 
    {
        public double XCoordinate { get; set; } = 0;
        public double YCoordinate { get; set; } = 0;

        public Position(double xCoordinate, double yCoordinate)
        {
            this.XCoordinate = xCoordinate;
            this.YCoordinate = yCoordinate;
        }
        public Position TravelToPosition(Velocity velocity)
        {
            var x =  velocity.Speed * Math.Cos(velocity.Direction);
            var y = velocity.Speed * Math.Sin(velocity.Direction);
            return new Position(x, y);
        }

    }
}
