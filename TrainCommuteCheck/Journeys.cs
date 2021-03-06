﻿namespace TrainCommuteCheck
{
    public static class Journeys
    {
        public static readonly Journey Commute = new Journey
        {
            Outbound = new JourneyLeg
            {
                DepartureTime = new TimeParser("7:40"),
                From = "KLF",
                To = "ILK",
                Monitor = new MonitorSettings()
                {
                    Days = "MON-FRI",
                    From = new TimeParser("6:20"),
                    To = new TimeParser("7:40"),
                    Every = 5,
                    Off = new TimeParser("7:42"),
                    Notify = new TimeParser("7:05")
                }
            },
            Inbound = new JourneyLeg
            {
                DepartureTime = new TimeParser("16:38"),
                From = "ILK",
                To = "KLF",
                Monitor = new MonitorSettings()
                {
                    Days = "MON-FRI",
                    From = new TimeParser("16:15"),
                    To = new TimeParser("16:38"),
                    Every = 5,
                    Off = new TimeParser("16:40"),
                    Notify = new TimeParser("16:25")
                }
            }
        };

        public static readonly Journey Test = new Journey
        {
            Outbound = new JourneyLeg
            {
                DepartureTime = new TimeParser("20:14"),
                From = "KLF",
                To = "ILK",
                Monitor = new MonitorSettings()
                {
                    Days = "MON-FRI",
                    From = new TimeParser("6:20"),
                    To = new TimeParser("7:40"),
                    Every = 5,
                    Off = new TimeParser("7:42")
                }
            },
            Inbound = new JourneyLeg
            {
                DepartureTime = new TimeParser("22:40"),
                From = "ILK",
                To = "KLF",
                Monitor = new MonitorSettings()
                {
                    Days = "MON-FRI",
                    From = new TimeParser("16:15"),
                    To = new TimeParser("16:38"),
                    Every = 5,
                    Off = new TimeParser("16:40")
                }
            }
        };
    }
}