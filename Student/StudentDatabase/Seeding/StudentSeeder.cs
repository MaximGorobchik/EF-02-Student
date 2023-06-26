using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentSystem.Data.Models;
using StudentSystem.Interfaces;
using System;
using System.Collections.Generic;

namespace StudentSystem.Seeding
{
    public class StudentSeeder : ISeeder<Student>
    {
        private static readonly List<Student> s = new()
        {
            new Student
            {
                StudentID = 1,
                Name = "Maksim",
                PhoneNumber = "+124233456789",
                RegisteredOn = DateTime.Now,
                Birthday = DateTime.Now
            },

            new Student
            {
                StudentID = 2,
                Name = "Stepan",
                PhoneNumber = "+123232456789",
                RegisteredOn = DateTime.Now,
                Birthday = DateTime.Now
            }
        };

        public void Seed(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(s);
        }
    }
}
