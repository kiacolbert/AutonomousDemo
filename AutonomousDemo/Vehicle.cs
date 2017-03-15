using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutonomousDemo
{
    public class Vehicle
    {
        protected VehicleMotion vehicleMotion = new VehicleMotion(new Velocity(0));
        protected Position position = new Position(0, 0);

        public double Area { get; set; }
        public VehicleMotion VehicleMotion
        {
            get
            {
                return vehicleMotion;
            }
            set
            {
                this.vehicleMotion = value;
            }
        }
        public Position Position { get { return position; } set { this.Position = position; } }
      
        public Vehicle(double area)
        {
            this.Area = area;
        }

      
    }

}
