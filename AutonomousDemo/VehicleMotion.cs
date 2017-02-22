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

        public Velocity Drive(double meters, int seconds)
        {
            var finalSpeed = CalculateSpeed(meters,seconds);
            Velocity finalVelocity = new Velocity(finalSpeed);
            Velocity CurrentVelocity = new Velocity(0);
            CurrentAcceleration = ConstantAcceleration(seconds, finalVelocity, CurrentVelocity);
            for (int i = 0; i < seconds; i++)
            {
                CurrentVelocity.Speed += CurrentAcceleration;
                //This isn't really doing anything now
            }
            return CurrentVelocity;
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
