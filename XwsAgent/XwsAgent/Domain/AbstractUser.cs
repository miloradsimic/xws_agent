using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;

namespace XwsAgent.Domain
{
    public abstract class AbstractUser
    {
        [Column(Name= "Id", IsDbGenerated =true, IsPrimaryKey = true, DbType ="INTEGER")]
        [Key]
        public int Id { get; set; }
        [Column(Name = "Email", DbType = "VARCHAR")]
        public string Email { get; set; }
        [Column(Name = "Password", DbType = "VARCHAR")]
        public string Password { get; set; }
        [Column(Name = "Name", DbType = "VARCHAR")]
        public string Name { get; set; }
        [Column(Name = "Address", DbType = "VARCHAR")]
        public string Address { get; set; }
        [Column(Name = "Id", DbType = "VARCHAR")]
        public UserRole Role { get; set; }
    }
}
