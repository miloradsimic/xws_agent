using System;

namespace XwsAgent.Domain
{
    public class Message
    {
        public Client Sender { get; set; }
        public Client Receiver { get; set; }
        public string Text { get; set; }
        public DateTime Time { get; set; }
    }
}
