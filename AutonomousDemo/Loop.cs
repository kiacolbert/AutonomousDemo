using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutonomousDemo
{
    public class Loop
    {

        public void SimulationLoop(Vehicle vehicle)
        {
            while (true)
            {
                ProcessInput(vehicle);
                DisplayVehicleStats(vehicle);
            }
        }

        private void ProcessInput(Vehicle vehicle)
        {
            
            //change position
            throw new NotImplementedException();
        }

        private void DisplayVehicleStats(Vehicle vehicle)
        {
            Speedometer.SpeedometerDisplay(vehicle);
            Console.WriteLine($"Vehicle's Position {vehicle.Position.XCoordinate},{vehicle.Position.YCoordinate}");
        }    
    }
}
