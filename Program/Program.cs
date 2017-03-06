using AutonomousDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutonomousDemo
{
    class Program
    {
        static void Main(string[] arg)
        {
            VehicleMotion vehicleMotion = new VehicleMotion(new Velocity(0));
            Speedometer speedometer = new Speedometer();
            speedometer.SpeedometerDisplay(vehicleMotion, 8, 202);
            var currentVelocity = vehicleMotion.DecelerateVelocityPerSecond(vehicleMotion.CurrentVelocity);
            DeterminePath determinePath = new DeterminePath();
            Road road = new Road(27);
            determinePath.CalculateTravelTime(202, road, vehicleMotion);
            
         
        }
    }
}
