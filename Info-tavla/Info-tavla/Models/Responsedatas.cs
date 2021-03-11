using System;

namespace Info_tavla.Models
{
    public class Responsedatas
    {
        public DateTime LatestUpdate { get; set; }
        public int DataAge { get; set; }
        public Metro[] Metros { get; set; }
        public Bus[] Buses { get; set; }
        public Train[] Trains { get; set; }
        public object[] Trams { get; set; }
        public object[] Ships { get; set; }
        public Stoppointdeviation[] StopPointDeviations { get; set; }
    }
}
