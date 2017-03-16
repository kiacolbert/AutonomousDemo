using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutonomousDemo
{
    public static class Speedometer
    {
        public static void SpeedometerDisplay(Vehicle vehicle)
        {
            var milesPerHour = ConvertMetersPerSecondToMpH(vehicle.VehicleMotion.CurrentVelocity.Speed);
            Console.WriteLine($"Speed: {milesPerHour}");
        }
        public static double ConvertMetersPerSecondToMpH(double metersPerSecond)
        {
            return metersPerSecond * 2.2369;
        }

    }
}
