using System.Collections.Generic;
using JM.Database;

namespace FoloNow.Database.Models.Entities
{
    public class Subject : EntityBase
    {
        public Subject()
        {
            Courses = new List<Course>();
        }

        //public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Course> Courses;
    }
 
}
