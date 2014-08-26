using System.Data.Entity.ModelConfiguration;
using FoloNow.Database.Models.Entities;

namespace FoloNow.Database.Models.Map
{
    class SubjectMapper : EntityTypeConfiguration<Subject>
    {
        public SubjectMapper()
        {
            ToTable("Subject");

            //HasKey(s => s.Id);
            //Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            //Property(s => s.Id).IsRequired();

            Property(s => s.Name).IsRequired();
            Property(s => s.Name).HasMaxLength(255);

        }
    }
}
