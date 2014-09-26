using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;

namespace FoloNow.Database
{
    public class EFContext : DbContext
    {
        public EFContext()
            : base("EFContext")
        {
            var _ = typeof (System.Data.Entity.SqlServer.SqlProviderServices);
            System.Data.Entity.Database.SetInitializer<EFContext>(new CreateDatabaseIfNotExists<EFContext>());
            //System.Data.Entity.Database.SetInitializer<EFContext>(new DropCreateDatabaseAlways<EFContext>());
            //System.Data.Entity.Database.SetInitializer<EFContext>(new DropCreateDatabaseIfModelChanges<EFContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
            //.Where(type => !String.IsNullOrEmpty(type.Namespace))
            //.Where(type => type.BaseType != null && type.BaseType.IsGenericType
            //     && type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));
            // foreach (var type in typesToRegister)
            // {
            //     dynamic configurationInstance = Activator.CreateInstance(type);
            //     modelBuilder.Configurations.Add(configurationInstance);
            // }
            // base.OnModelCreating(modelBuilder);

            var addMethod = typeof (ConfigurationRegistrar)
                .GetMethods()
                .Single(m =>
                    m.Name == "Add"
                    && m.GetGenericArguments().Any(a => a.Name == "TEntityType"));

            foreach (var assembly in AppDomain.CurrentDomain
                .GetAssemblies()
                .Where(a => a.GetName().Name == "FoloNow.Database.Models"))
            {
                var configTypes = assembly
                    .GetTypes()
                    .Where(t => t.BaseType != null
                                && t.BaseType.IsGenericType
                                && t.BaseType.GetGenericTypeDefinition() == typeof (EntityTypeConfiguration<>));

                foreach (var type in configTypes)
                {
                    //    var entityType = type.BaseType.GetGenericArguments().Single();

                    //    var entityConfig = assembly.CreateInstance(type.FullName);
                    //    addMethod.MakeGenericMethod(entityType)
                    //        .Invoke(modelBuilder.Configurations, new object[] {entityConfig});
                    dynamic configurationInstance = Activator.CreateInstance(type);
                    modelBuilder.Configurations.Add(configurationInstance);
                    modelBuilder.Conventions.Add<DomainConventions>();
                }

            }
            base.OnModelCreating(modelBuilder);

        }
    }

}
