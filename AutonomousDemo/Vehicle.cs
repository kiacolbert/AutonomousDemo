using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutonomousDemo
{
    public class Vehicle
    {
        public double Area { get; set; }
        public VehicleMotion vehicleMotion { get; set; }

        public Vehicle(double area, VehicleMotion vehicleMotion)
        {
            this.Area = area;
            this.vehicleMotion = vehicleMotion;
        }

      
    }

}
