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
            Vehicle vehicle = new Vehicle(800);
            SimulationLoop loop = new SimulationLoop();
            loop.Run(vehicle,200);
         
        }
    }
}
