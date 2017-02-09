using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutonomousDemo
{
    public class Road
    {
        public decimal LaneWidth { get; set; }
        public RoadType Type { get; set; }
        public WeatherCondition Condition { get; set; }
    }

    public class WeatherCondition
    {
    }

    public enum RoadType
    {
    }
}
