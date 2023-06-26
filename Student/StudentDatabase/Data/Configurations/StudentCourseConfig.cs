using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentSystem.Data.Models;
using StudentSystem.Seeding;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentSystem.Data.Configurations
{
    public class StudentCourseConfig : IEntityTypeConfiguration<StudentCourse>
    {
        public void Configure(EntityTypeBuilder<StudentCourse> builder)
        {
            builder.HasKey(sc => new { sc.StudentID, sc.CourseID });
            builder
                .HasOne(sc => sc.Student)
                .WithMany(sc => sc.CourseEnrollments)
                .HasForeignKey(sc => sc.StudentID);
            builder
                .HasOne(sc => sc.Course)
                .WithMany(sc => sc.StudentsEnrolled)
                .HasForeignKey(sc => sc.CourseID);
            new StudentCourseSeeder().Seed(builder);
        }
    }
}