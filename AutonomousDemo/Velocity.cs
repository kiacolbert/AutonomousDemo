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
        public double Direction { get; set; }  //radians


        public Velocity(double speed, double direction = 1.5708)
        {
            this.Speed = speed;
            this.Direction = direction;
        }

        public static Velocity operator +(Velocity vIntial, Velocity vFinal)
        {

            var totalSpeed = vIntial.Speed + vFinal.Speed;
            var totalDirection = vIntial.Direction + vFinal.Direction;

            return new Velocity(totalSpeed, totalDirection);

        }

        public static Velocity operator -(Velocity vFinal, Velocity vInitial)
        {

            var totalSpeed = vFinal.Speed - vInitial.Speed;
            var totalDirection = vFinal.Direction - vInitial.Direction;

            return new Velocity(totalSpeed, totalDirection);

        }
        
    }

    //public class Direction
    //{
    //    public double Angle { get; set; } = 1.5708; // 90 degrees

    //    public Direction(double angle)
    //    {
    //        this.Angle = angle;
    //        //this.XCoordinateOffSet = metersTraveled * Math.Cos(angle);
    //        //this.YCoordinateOffSet = metersTraveled * Math.Sin(angle);
    //    }

    //}
}
   
   

