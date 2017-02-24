using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutonomousDemo
{
    public class Velocity
    {
        public double Speed { get; set; } = 0;
        public Direction Direction { get; set; } //radians

        //public Velocity(double metersTraveled, double time, Direction direction)
        //{   
        //    this.Speed =  metersTraveled / time;
        //    this.Direction = direction;
        //}

        public Velocity(double speed, Direction direction)
        {
            this.Speed = speed;
            this.Direction = direction;
        }

        public static Velocity operator +(Velocity vIntial, Velocity vFinal)
        {
            
            var totalSpeed = vIntial.Speed + vFinal.Speed;
            Direction totalDirection = vIntial.Direction + vFinal.Direction;

            return new Velocity(totalSpeed, totalDirection);
                
        }
        public static Velocity operator -(Velocity vFinal, Velocity vInitial)
        {

            var totalSpeed = vFinal.Speed + vInitial.Speed;
            Direction totalDirection = vFinal.Direction + vInitial.Direction;

            return new Velocity(totalSpeed, totalDirection);

        }
    }

    public class Direction
    {
        public double XCoordinateOffSet { get; set; } = 0;
        public double YCoordinateOffSet { get; set; } = 0;
        public double Angle { get; set; } = 1.5708; // 90 degrees

        public Direction(double metersTraveled, double angle)
        {
            this.Angle = angle;
            this.XCoordinateOffSet = metersTraveled * Math.Cos(angle);
            this.YCoordinateOffSet = metersTraveled * Math.Sin(angle);
        }

        public static Direction operator +(Direction direction1, Direction direction2)
        {

            return new Direction(direction1.XCoordinateOffSet + direction2.XCoordinateOffSet, direction1.YCoordinateOffSet + direction2.YCoordinateOffSet);
        }
        public void AdjustPositionByDirection(Position currentPosition)
        {
            currentPosition.XCoordinate += XCoordinateOffSet;
            currentPosition.YCoordinate += YCoordinateOffSet;
        }
    }
    public class Position
    {
        public double XCoordinate { get; set; } = 0;
        public double YCoordinate { get; set; } = 0;

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
   
    //public class Speed
    //{
    //    //how do meters relate to  xy position
    //    public double MetersTraveled { get; set; }
    //    public double Time { get; set; }
    //    public double MetersPerSecond { get; set; }

    //    public Speed(double metersTraveled, double time)
    //    {
    //        this.MetersTraveled = metersTraveled;
    //        this.Time = time;
    //        this.MetersPerSecond = metersTraveled/time;
    //    }

        
    }
}
