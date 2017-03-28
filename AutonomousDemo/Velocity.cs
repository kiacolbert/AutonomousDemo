using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutonomousDemo
{
    public struct Velocity
    {
        public double Speed;
        /// <summary>
        /// Direction on a two-dimensional surface, in radians.  Assumes that 0 radians is due east.
        /// </summary>
        public double Direction;  


        public Velocity(double speed = 0, double direction = Math.PI/2.0)
        {
            this.Speed = speed;
            this.Direction = direction;
        }

        public static Velocity operator +(Velocity initial, Velocity second)
        {
            var totalSpeed = initial.Speed + second.Speed;
            var totalDirection = 0; //TODO: fix this. This method is not being used.

            return new Velocity(totalSpeed, totalDirection);

        }

        public static Velocity operator -(Velocity second, Velocity initial)
        {

            var totalSpeed = second.Speed - initial.Speed;
            var totalDirection =0 ; //TODO: fix this. This method is not being used.

            return new Velocity(totalSpeed, totalDirection);

        }
        
    }
}
   
   

