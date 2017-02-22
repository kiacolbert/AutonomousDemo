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
        public double Direction { get; set; }  


        public Velocity(double speed, double direction = Math.PI/2.0)
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
}
   
   

