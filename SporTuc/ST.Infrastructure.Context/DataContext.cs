using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using static ST.Application.ConectionString.ConectionString;

namespace ST.Infrastructure.Context
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base(Get)
        {
            //Sirven para quitar la posibilidad de que me haga los include para 
            //que yo los haga a mano
            Configuration.LazyLoadingEnabled = false;

            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Para que no pueda borrarse en cascada
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //Para que no Pluralice en ingles
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
