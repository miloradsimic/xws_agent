namespace XwsAgent.DataLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;
    using XwsAgent.Domain;

    public class XwsAgentModel : DbContext
    {
        // Your context has been configured to use a 'XwsAgentModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'XwsAgent.XwsAgentModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'XwsAgentModel' 
        // connection string in the application configuration file.
        public XwsAgentModel()
            : base("name=XwsAgentModel")
        {
            InitializeDatabase();
        }

        protected virtual void InitializeDatabase()
        {             
            if (!Database.Exists())
            {
                Database.Initialize(true);
            }
        }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public DbSet<AbstractUser> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}