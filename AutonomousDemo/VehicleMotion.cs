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
        double Rate = 3.4; //m/s^2

        public double CurrentAcceleration { get; set; }
        public Velocity CurrentVelocity { get; set; }
        public double DistanceTraveled { get; set; }
        public double TravelDistance { get; set; }

        public VehicleMotion(Velocity currentVelocity)
        {
            this.CurrentVelocity = currentVelocity;
        }

        public Velocity CalculateCurrentVelocity(double meters, int seconds)
        {
            return new Velocity(meters/seconds);
        }

        public Velocity Decelerate(Velocity velocity)
        {
            //less than 3.4?
            if(velocity.Speed == 0)
            {
                return velocity;
            }
            var decreasedSpeed = velocity.Speed - Rate;
            velocity.Speed = decreasedSpeed;
            //something about direction

            return velocity;
        }
        public Velocity Accelerate(Velocity velocity)
        {
            if (velocity.Speed >= 54)
            {
                velocity.Speed = 54;
                return velocity;
            }
            var increasedSpeed = velocity.Speed + Rate;
            velocity.Speed = increasedSpeed;
            //something about direction

            return velocity;
        }
        public Velocity ZeroVelocity(Velocity velocity)
        {
            throw new NotImplementedException();
        }

        public double ConstantAcceleration(double travelTime, Velocity finalVelocity, Velocity initialVelocity)
        {
            var avgV = finalVelocity - initialVelocity;
            return avgV.Speed / travelTime;
        }
    }

   
 
}
