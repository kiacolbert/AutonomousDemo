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
        
        public VehicleMotion(double currentSpeed, double meters, int seconds)
        {
            this.CurrentSpeed = currentSpeed;
            this.CurrentVelocity = CalculateCurrentVelocity(meters, seconds);
        }

        public Velocity CalculateCurrentVelocity(double meters, int seconds)
        {
            return new Velocity(meters/seconds);
        }

        public Velocity DecelerateVelocityPerSecond(Velocity velocity)
        {
            var delerationRate = -3.4; //m/s^2
            var decreasedSpeed = velocity.Speed + delerationRate;
            velocity.Speed = decreasedSpeed;
            //something about direction

            return velocity;
        }
        public Velocity ZeroVelocity(Velocity velocity)
        {
            throw new NotImplementedException();
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
