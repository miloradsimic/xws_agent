using System;

namespace XwsAgent.Domain
{
    public class Reservation
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public double Price { get; set; }
        public bool IsApproved { get; set; }
    }
}
