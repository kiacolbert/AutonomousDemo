using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutonomousDemo
{
    public class Speedometer
    {
        public void SpeedometerDisplay(VehicleMotion vehicleMotion, int travelTime, Position position)
        {

            var metersPerSecond= vehicleMotion.PressGasPedal(travelTime, position);
            var milesPerHour = CalculateMilesPerHour(metersPerSecond);
            Console.WriteLine($"Speed: {milesPerHour}");
        }
        public double ConvertMetersPerSecondToMilesPerHour(double metersPerSecond)
        {
            return metersPerSecond * 2.2369;
        }
        
    }
}
