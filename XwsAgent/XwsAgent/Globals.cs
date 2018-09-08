using XwsAgent.DataLayer;

namespace XwsAgent
{
    public static class Globals
    {
        public static LoginPort LoginClient
        {
            get;
            set;
        }

        public static AccommodationsPort AccommodationsClient
        {
            get;
            set;
        }

        public static AgentDetails LoggedAgent
        {
            get;
            set;
        }

        public static XwsAgentModel DbContext
        {
            get;
            set;
        }
    }
}
