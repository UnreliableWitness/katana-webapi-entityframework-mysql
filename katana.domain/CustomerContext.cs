using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Migrations.History;

namespace katana.domain
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class CustomerContext : DbContext 
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



        }
    }

     
}
