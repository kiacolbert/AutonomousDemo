﻿using System;
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
   
   

