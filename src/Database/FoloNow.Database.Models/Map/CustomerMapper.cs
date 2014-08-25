using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using FoloNow.Database.Models.Entities;

namespace FoloNow.Database.Models.Map
{
    class CustomerMapper : EntityTypeConfiguration<Customer>
    {
        public CustomerMapper()
        {

            //key
            HasKey(t => t.Id);

            //properties
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Name);
            Property(t => t.Email).IsRequired();

            //table
            ToTable("Customers");

        }
    }
}
