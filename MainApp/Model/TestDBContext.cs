using System.Data.Entity;

namespace MainApp.Model
{
    public class TestDbContext : DbContext
    {
        public TestDbContext() : base(nameOrConnectionString: "TestDBConnectionString")
        {
            
            if (!Database.Exists())
            {
                Database.SetInitializer(new NullDatabaseInitializer<TestDbContext>());
            }
            else
            {
                Database.SetInitializer(new CreateDatabaseIfNotExists<TestDbContext>());
            }
        }

      
    }
}
