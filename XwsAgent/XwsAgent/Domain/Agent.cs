using System.Data.Linq.Mapping;

namespace XwsAgent.Domain
{
    [Table(Name = "Agent")]
    public class Agent: Client
    {
        [Column(Name = "TIN", DbType = "VARCHAR")]
        public string Tin { get; set; }
    }
}
