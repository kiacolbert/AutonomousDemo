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
        const double MaximumVehicleSpeed = 54; //m/s

        public double CurrentAcceleration { get; set; }
        public Velocity CurrentVelocity { get; set; }
        public double DistanceTraveled { get; set; }
       

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
            if(velocity.Speed == 0 || velocity.Speed < Rate)
            {   
                //Direction will change in position class
                return new Velocity(velocity.Speed = 0, velocity.Direction);
            }
            var decreasedSpeed = velocity.Speed - Rate;
            velocity.Speed = decreasedSpeed;

            return new Velocity(velocity.Speed, velocity.Direction);
        }
        public Velocity Accelerate(Velocity velocity)
        {
            if (velocity.Speed >= MaximumVehicleSpeed)
            {
                velocity.Speed = MaximumVehicleSpeed;
                return new Velocity(velocity.Speed, velocity.Direction);
            }
            var increasedSpeed = velocity.Speed + Rate;
            velocity.Speed = increasedSpeed;

            return new Velocity(velocity.Speed, velocity.Direction);
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
