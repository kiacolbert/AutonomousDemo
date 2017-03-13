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
            Speedometer.SpeedometerDisplay(new VehicleMotion (new Velocity(0)));

            Loop loop = new Loop();
            loop.GameLoop(true);
         
        }
    }
}
