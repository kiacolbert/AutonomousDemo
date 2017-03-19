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

        public Position TravelForOneSecond(Velocity currentVelocity, Position previousPosition)
        {

            var _x = currentVelocity.Speed * Math.Cos(currentVelocity.Direction);
            var _y = currentVelocity.Speed * Math.Sin(currentVelocity.Direction);
            var x = _x + previousPosition.XCoordinate;
            var y = _y + previousPosition.YCoordinate;
            return new Position(x, y);
        }
    }
}
