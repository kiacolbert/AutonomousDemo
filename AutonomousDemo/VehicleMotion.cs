using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutonomousDemo
{
    public class VehicleMotion
    {
        public Vehicle Vehicle;
        public int Time;
        public double CurrentSpeed { get; set; }
        public double CurrentAcceleration { get; set; }
        public Velocity CurrentVelocity { get; set; }
        
        public VehicleMotion(double currentSpeed)
        {
            this.CurrentSpeed = currentSpeed;
        }

        public Velocity CalculateCurrentVelocity(double meters, int seconds)
        {
            return new Velocity(meters/seconds);
        }

        public void Brake()
        {
            CurrentSpeed = 0;
            //need to decelerate over time
        }

        public double CalculateSpeed(double meters, double time)
        {
            return meters / time;
        }

        public double ConstantAcceleration(double travelTime, Velocity finalVelocity, Velocity initialVelocity)
        {
            var avgV = finalVelocity - initialVelocity;
            return avgV.Speed / travelTime;
        }
    }

   
 
}
