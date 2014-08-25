using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using FoloNow.Database.Models.Entities;

namespace FoloNow.Database.Models.Map
{
    class CourseMapper : EntityTypeConfiguration<Course>
    {
        public CourseMapper()
        {
            ToTable("Courses");

            HasKey(c => c.Id);
            Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Id).IsRequired();

            Property(c => c.Name).IsRequired();
            Property(c => c.Name).HasMaxLength(255);

            Property(c => c.Duration).IsRequired();

            Property(c => c.Description).IsOptional();
            Property(c => c.Description).HasMaxLength(1000);

            HasRequired(c => c.CourseSubject).WithMany().Map(s => s.MapKey("SubjectID"));
            HasRequired(c => c.CourseTutor).WithMany().Map(t => t.MapKey("TutorID"));

        }
    }
}
