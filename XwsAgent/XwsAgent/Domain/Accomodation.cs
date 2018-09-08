using System;

namespace XwsAgent.Domain
{
    public class Accomodation
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public Int16 Category { get; set; }
        public AccomodationType Type { get; set; }
        public string Description { get; set; }
        public string ImageUri { get; set; }
        bool HasParking { get; set; }
        bool HasWiFi { get; set; }
        bool HasBreakfast { get; set; }
        bool HasHalfBoard { get; set; }
        bool HasFullBoard { get; set; }
        bool HasTV { get; set; }
        bool HasKitchen { get; set; }
        bool HasPrivateBathroom { get; set; }
        public float DailyPrice { get; set; }
    }
}
