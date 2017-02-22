using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutonomousDemo
{
    public class Speedometer
    {
        public void SpeedometerDisplay(VehicleMotion vehicleMotion, int travelTime, double meters)
        {

            var metersPerSecond= vehicleMotion.Drive(meters, travelTime);
            var milesPerHour = ConvertMetersPerSecondToMpH(metersPerSecond.Speed);
            Console.WriteLine($"Speed: {milesPerHour}");
        }
        public double ConvertMetersPerSecondToMpH(double metersPerSecond)
        {
            return metersPerSecond * 2.2369;
        }

    }
}
