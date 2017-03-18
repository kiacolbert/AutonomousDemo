using System;

namespace AutonomousDemo
{
    public class LaneDetection
    {
        const double LaneWidth = 3.7; //meters

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
