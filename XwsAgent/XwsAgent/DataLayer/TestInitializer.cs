using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XwsAgent.Domain;

namespace XwsAgent.DataLayer
{
    public class TestInitializer: DropCreateDatabaseIfModelChanges<XwsAgentModel>
    {
        protected override void Seed(XwsAgentModel context)
        {
            context.Users.Add(new Agent()
            {
                Name = "Miko Mikic",
                Email = "miko@mail.com",
                Password = "pass",
                Address = "Pera Perica bb, Perovac",
                Tin = "112233",
                Role = UserRole.Agent
            });
            context.Users.Add(new Agent()
            {
                Name = "Ziko Zikic",
                Email = "ziko@mail.com",
                Password = "pass",
                Address = "Pera Perica bb, Perovac",
                Tin = "123456",
                Role = UserRole.Agent
            });
            context.SaveChanges();
        }
    }
}
