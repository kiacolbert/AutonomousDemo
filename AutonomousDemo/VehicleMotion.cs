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
        public Speed CurrentSpeed { get; set; }
        public double CurrentAcceleration { get; set; }
        public Velocity CurrentVelocity { get; set; }
        
        public VehicleMotion(double currentSpeed)
        {
            this.CurrentSpeed = currentSpeed;
        }

        public double PressGasPedal(int seconds, Position position)
        {
            var finalVelocity = CalculateFinalVelocity(position, seconds);
            ConstantAcceleration(seconds, finalVelocity);
            for (int i = 0; i < seconds; i++)
            {
                CurrentVelocity += CurrentAcceleration; 
                //This isn't really doing anything now

            }
            return CurrentVelocity;
        }
       
        public void Brake()
        {
            CurrentSpeed = 0;
        }
        public double CalculateFinalVelocity(Velocity velocity, int travelTime)
        {
            var finalVelocity = position.TravelDistance / travelTime;
            return finalVelocity;
        }
      
    }
    public class Acceleration
    {
        public double TravelTime { get; set; }
        public Velocity IntialVelocity { get; set; }
        public Velocity FinalVelocity { get; set; }

        public Acceleration(double travelTime, Velocity intialVelocity, Velocity finalVelocity)
        {
            this.TravelTime = travelTime;
            this.IntialVelocity = intialVelocity;
            this.FinalVelocity = finalVelocity;
        }
        public void ConstantAcceleration(double travelTime, double finalVelocity, double initialVelocity = 0)
        {
            CurrentAcceleration = (finalVelocity - initialVelocity) / travelTime;

        }
    }
 
}
