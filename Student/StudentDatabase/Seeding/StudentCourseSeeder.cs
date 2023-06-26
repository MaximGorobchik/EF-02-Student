using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentSystem.Data.Models;
using StudentSystem.Interfaces;
using System;
using System.Collections.Generic;

namespace StudentSystem.Seeding
{
    public class StudentCourseSeeder : ISeeder<StudentCourse>
    {

        private static readonly List<StudentCourse> sc = new()
        {
            new StudentCourse
            {
                StudentID = 1,
                CourseID = 1
            },

            new StudentCourse
            {
                StudentID = 2,
                CourseID = 2
            }
        };

        public void Seed(EntityTypeBuilder<StudentCourse> builder)
        {
            builder.HasData(sc);
        }

    }
}

