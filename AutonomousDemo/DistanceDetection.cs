using System;

namespace AutonomousDemo
{
    public class DistanceDetection
    {
        public decimal LeftLaneBorder { get; set; }
        public decimal RightLaneBorder { get; set; }
        public TrafficStop TrafficStop { get; set; }

        public decimal LaneBorderDistance()
        {
            throw new NotImplementedException();
        }

    }

    public enum TrafficStop
    {
        StopSign,
        RedLight
    }

}
