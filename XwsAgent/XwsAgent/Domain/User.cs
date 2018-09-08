using System.Data.Linq.Mapping;

namespace XwsAgent.Domain
{
    [Table(Name = "User")]
    public class User : Client
    {
        [Column(Name = "Blocked", DbType = "BOOLEAN")]
        public bool IsBlocked { get; set; }
        [Column(Name = "Deleted", DbType = "BOOLEAN")]
        public bool IsDeleted { get; set; }
    }
}
