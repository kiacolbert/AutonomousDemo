using System;

namespace AutonomousDemo
{
    public class DistanceDetection
    {
        public decimal LeftLaneBoarder { get; set; }
        public decimal RightLaneBoarder { get; set; }
        public TrafficStop TrafficStop { get; set; }

        public decimal LaneBoarderDistance()
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
