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
        public double CurrentSpeed;
        public double CurrentAcceleration { get; set; }
        public double CurrentVelocity { get; set; }
                                           //int CurrentTime = DateTime.Now.Second;
                                           //int CurrentTime = 0;
                                           // public int TravelTime;
        public Position CurrentPosition;



        // public VehicleMotion(Vehicle vehicle, Position currentPosition, int currentSpeed)
        public VehicleMotion(double currentSpeed)
        {
            //this.CurrentPosition = currentPosition;
            this.CurrentSpeed = currentSpeed;
        }

        public double PressGasPedal(int seconds, Position position)
        {
            var finalVelocity = CalculateFinalVelocity(position, seconds);
            ConstantAcceleration(seconds, finalVelocity);
            //var travelTime = position.TravelDistance / CurrentAcceleration;
            for (int i = 0; i < seconds; i++)
            {
                CurrentVelocity += CurrentAcceleration;

            }
            return CurrentVelocity;
        }
        public void ConstantAcceleration(double travelTime, double finalVelocity,  double initialVelocity = 0)
        {
            CurrentAcceleration = (finalVelocity - initialVelocity) / travelTime;
            
        }
        public void Brake()
        {
            CurrentSpeed = 0;
        }
        public double CalculateFinalVelocity(Position position, int travelTime)
        {
            var finalVelocity = position.TravelDistance / travelTime;
            return finalVelocity;
        }
      
    }
    public class Position
    {
        public int TravelDistance { get; set; }
        public Direction Direction { get; set; }

        public Position (int travelDistance) {
            this.TravelDistance = travelDistance;
        }
        
    }
    public enum Direction
    {
        North,
        South,
        East,
        West
    }
}
