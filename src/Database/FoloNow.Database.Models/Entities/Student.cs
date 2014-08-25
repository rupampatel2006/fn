﻿using System;
using System.Collections.Generic;
using JM.Database;

namespace FoloNow.Database.Models.Entities
{
    public class Student : EntityBase
    {
        public Student()
        {
            Enrollments = new List<Enrollment>();
        }

        //public int Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Enums Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public DateTime? LastLoginDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
