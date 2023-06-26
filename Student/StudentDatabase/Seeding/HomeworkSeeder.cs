using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentSystem.Data.Models;
using StudentSystem.Interfaces;
using System;
using System.Collections.Generic;

namespace StudentSystem.Seeding
{
    public class HomeworkSeeder : ISeeder<Homework>
    {
        private static readonly List<Homework> h = new()
        {
            new Homework
            {
                HomeworkID = 1,
                Content = "Task",
                ContentType = ContentType.pdf,
                SubmissionTime = DateTime.Now,
                CourseID = 1,
                StudentID = 1
            },

            new Homework
            {
                HomeworkID = 2,
                Content = "Task",
                ContentType = ContentType.application,
                SubmissionTime = DateTime.Now,
                CourseID = 2,
                StudentID = 1
            }
        };

        public void Seed(EntityTypeBuilder<Homework> builder)
        {
            builder.HasData(h);
        }
    }

}
