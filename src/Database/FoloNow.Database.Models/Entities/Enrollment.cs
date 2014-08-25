using System;
using JM.Database;

namespace FoloNow.Database.Models.Entities
{
    public class Enrollment : EntityBase
    {
        public Enrollment()
        {
            Student = new Student();
            Course = new Course();
        }
        //public int Id { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
