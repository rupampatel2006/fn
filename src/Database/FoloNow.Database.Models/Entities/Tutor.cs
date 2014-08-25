﻿using System.Collections.Generic;
using JM.Database;

namespace FoloNow.Database.Models.Entities
{
    public class Tutor : EntityBase
    {
        public Tutor()
        {
            Courses = new List<Course>();
        }
        //public int Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Enums Gender { get; set; }

        public ICollection<Course> Courses;
    }
}