using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutonomousDemo
{
    public class Road
    {
        public double Distance { get; set; }
        public double LaneWidth { get; set; }
        public int SpeedLimit { get; set; }
        public RoadType Type { get; set; }


        public Road(int speedLimit)
        {
            this.SpeedLimit = speedLimit;
        }
    }
    public enum RoadType
    {
        StraightTrack
    }
    
}
