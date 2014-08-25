using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using FoloNow.Database.Models.Entities;

namespace FoloNow.Database.Models.Map
{
    class StudentMapper : EntityTypeConfiguration<Student>
    {
        public StudentMapper()
        {
            ToTable("Students");

            HasKey(s => s.Id);
            Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(s => s.Id).IsRequired();

            Property(s => s.Email).IsRequired();
            Property(s => s.Email).HasMaxLength(255);
            Property(s => s.Email).IsUnicode(false);

            Property(s => s.UserName).IsRequired();
            Property(s => s.UserName).HasMaxLength(50);
            Property(s => s.UserName).IsUnicode(false);

            Property(s => s.Password).IsRequired();
            Property(s => s.Password).HasMaxLength(255);

            Property(s => s.FirstName).IsRequired();
            Property(s => s.FirstName).HasMaxLength(50);

            Property(s => s.LastName).IsRequired();
            Property(s => s.LastName).HasMaxLength(50);

            Property(s => s.Gender).IsOptional();

            Property(s => s.DateOfBirth).IsRequired();
            Property(s => s.DateOfBirth).HasColumnType("smalldatetime");

            Property(s => s.RegistrationDate).IsOptional();
            Property(s => s.RegistrationDate).HasColumnType("smalldatetime");
            
            Property(s => s.LastLoginDate).IsOptional();
            Property(s => s.LastLoginDate).HasColumnType("smalldatetime");

        }
    }
}
