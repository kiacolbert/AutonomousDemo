using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutonomousDemo
{
    public class Velocity
    {
        public double Speed { get; set; }
        public Direction Direction { get; set; } //radians, change radians to change direction

        public Velocity(double speed, Direction direction)
        {
            this.Speed = speed;
            this.Direction = direction;
        }
        public static Velocity operator +(Velocity vIntial, Velocity vFinal)
        {
            Velocity velocity = null;
            var totalSpeed = vIntial.Speed + vFinal.Speed;
            Direction totalDirection = vIntial.Direction + vFinal.Direction;
            //vIntial.Direction + vFinal.Direction);
            //return new Velocity
            return velocity;
                
        }
    }

    public class Direction
    {
        public double XCoordinateOffSet { get; set; }
        public double YCoordinateOffSet { get; set; }

        public Direction(Position position)
        {
            this.XCoordinateOffSet = position.XCoordinate;
            this.YCoordinateOffSet = position.YCoordinate;
        }
        
        //public static Position operator +(Direction direction1, Direction direction2)
        //{

        //    return new Position(direction1.XCoordinateOffSet + direction2.XCoordinateOffSet, direction1.YCoordinateOffSet + direction2.YCoordinateOffSet);
        //}
        public void AdjustPositionByDirection(Position currentPosition)
        {
            currentPosition.XCoordinate += XCoordinateOffSet;
            currentPosition.YCoordinate += YCoordinateOffSet;
        }
    }
    public class Position
    {
        public double XCoordinate { get; set; }
        public double YCoordinate { get; set; }

        public Position(double xCoordinate, double yCoordinate)
        {
            this.XCoordinate = xCoordinate;
            this.YCoordinate = yCoordinate;  
        }
        public static Position operator +(Position position1, Position position2)
        {

            return new Position(position1.XCoordinate + position2.XCoordinate, position1.YCoordinate + position2.YCoordinate);
        }
    }
    public class Speed
    {
        //how do meters relate to  xy position
        public double MetersTraveled { get; set; }
        public double Time { get; set; }

        public Speed(double metersTraveled, double time)
        {
            this.MetersTraveled = metersTraveled;
            this.Time = time;
        }

        
    }
}
