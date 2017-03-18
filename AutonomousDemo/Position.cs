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

        public Position TravelForOneSecond(Velocity currentVelocity, Velocity previousVelocity)
        {
            Velocity velocitySum = currentVelocity + previousVelocity;
            var x = velocitySum.Speed * Math.Cos(currentVelocity.Direction);
            var y = velocitySum.Speed * Math.Sin(currentVelocity.Direction);
            return new Position(x, y);
        }
    }
}
