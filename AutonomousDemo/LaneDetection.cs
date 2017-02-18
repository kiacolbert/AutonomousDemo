using System;

namespace AutonomousDemo
{
    public class LaneDetection
    {
        public double LeftLaneBorder { get; set; }
        public double RightLaneBorder { get; set; }
        public TrafficStop TrafficStop { get; set; }

        public double LaneBorderDistance()
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
