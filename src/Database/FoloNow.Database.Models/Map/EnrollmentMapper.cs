using System.Data.Entity.ModelConfiguration;
using FoloNow.Database.Models.Entities;

namespace FoloNow.Database.Models.Map
{
    class EnrollmentMapper : EntityTypeConfiguration<Enrollment>
    {
        public EnrollmentMapper()
        {
            ToTable("Enrollment");

            //HasKey(e => e.Id);
            //Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            //Property(e => e.Id).IsRequired();

            Property(e => e.EnrollmentDate).IsRequired();
            Property(e => e.EnrollmentDate).HasColumnType("smalldatetime");

            HasOptional(e => e.Student).WithMany(e => e.Enrollments).Map(s => s.MapKey("StudentID")).WillCascadeOnDelete(false);
            HasOptional(e => e.Course).WithMany(e => e.Enrollments).Map(c => c.MapKey("CourseID")).WillCascadeOnDelete(false);
        }
    }
}
