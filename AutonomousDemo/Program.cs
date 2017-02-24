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
            VehicleMotion vehicleMotion = new VehicleMotion(0);
            Speedometer speedometer = new Speedometer();
            Position position = new Position(152);
            speedometer.SpeedometerDisplay(vehicleMotion, 8, position);
         
        }
    }
}
