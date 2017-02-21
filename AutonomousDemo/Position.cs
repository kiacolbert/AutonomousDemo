using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutonomousDemo
{
    public class Position : IPosition
    {
        public double XCoordinate { get; set; } = 0;
        public double YCoordinate { get; set; } = 0;

        public Position(double xCoordinate, double yCoordinate)
        {
            this.XCoordinate = xCoordinate;
            this.YCoordinate = yCoordinate;
        }
        public Position TravelToPosition(double meters, Velocity velocity)
        {
            var x = meters * Math.Cos(velocity.Direction);
            var y = meters * Math.Sin(velocity.Direction);
            return new Position(x, y);
        }

    }
}
