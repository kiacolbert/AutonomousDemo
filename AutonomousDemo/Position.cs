using System;

namespace AutonomousDemo
{
    public struct Position 
    {
        public double XCoordinate;
        public double YCoordinate;

        public Position(double xCoordinate = 0, double yCoordinate = 0)
        {
            this.XCoordinate = xCoordinate;
            this.YCoordinate = yCoordinate;
        }

        public Position TravelForOneSecond(Velocity velocity)
        {
            var x =  velocity.Speed * Math.Cos(velocity.Direction);
            var y = velocity.Speed * Math.Sin(velocity.Direction);
            return new Position(x, y);
        }
    }
}
