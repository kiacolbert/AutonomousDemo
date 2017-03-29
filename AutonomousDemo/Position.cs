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

            var deltaX = currentVelocity.Speed * Math.Cos(currentVelocity.Direction);
            var deltaY = currentVelocity.Speed * Math.Sin(currentVelocity.Direction);
            var x = deltaX + previousPosition.XCoordinate;
            var y = deltaY + previousPosition.YCoordinate;
            return new Position(x, y);
        }
        public double CalculateDirection(Position position, Velocity velocity)
        {
            var sinY = position.YCoordinate / velocity.Speed;
           return Math.Asin(sinY);
           
        }
    }
}
