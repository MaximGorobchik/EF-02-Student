﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentSystem.Data;

#nullable disable

namespace StudentDatabase.Migrations
{
    [DbContext(typeof(StudentSystemContext))]
    partial class StudentSystemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StudentSystem.Data.Models.Course", b =>
                {
                    b.Property<int>("CourseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseID"));

                    b.Property<string>("Description")
                        .IsUnicode(true)
                        .HasColumnType("ntext")
                        .HasColumnName("Description");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("date")
                        .HasColumnName("EndDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Name");

                    b.Property<decimal>("Price")
                        .HasColumnType("money")
                        .HasColumnName("Price");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("date")
                        .HasColumnName("StartDate");

                    b.HasKey("CourseID");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseID = 1,
                            Description = "Description for OOP",
                            EndDate = new DateTime(2023, 6, 7, 22, 56, 39, 805, DateTimeKind.Local).AddTicks(1461),
                            Name = "OOP",
                            Price = 5000m,
                            StartDate = new DateTime(2023, 6, 7, 22, 56, 39, 805, DateTimeKind.Local).AddTicks(1124)
                        },
                        new
                        {
                            CourseID = 2,
                            Description = "Description for Philosophy",
                            EndDate = new DateTime(2023, 6, 7, 22, 56, 39, 805, DateTimeKind.Local).AddTicks(2187),
                            Name = "Philosophy",
                            Price = 1000m,
                            StartDate = new DateTime(2023, 6, 7, 22, 56, 39, 805, DateTimeKind.Local).AddTicks(2178)
                        });
                });

            modelBuilder.Entity("StudentSystem.Data.Models.Homework", b =>
                {
                    b.Property<int>("HomeworkID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HomeworkID"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("text")
                        .HasColumnName("Content");

                    b.Property<string>("ContentType")
                        .IsRequired()
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("varchar")
                        .HasColumnName("ContentType");

                    b.Property<int>("CourseID")
                        .HasColumnType("int")
                        .HasColumnName("CourseId");

                    b.Property<int>("StudentID")
                        .HasColumnType("int")
                        .HasColumnName("StudentId");

                    b.Property<DateTime>("SubmissionTime")
                        .HasColumnType("date")
                        .HasColumnName("SubmissionTime");

                    b.HasKey("HomeworkID");

                    b.HasIndex("CourseID");

                    b.HasIndex("StudentID");

                    b.ToTable("HomeworkSubmissions");

                    b.HasData(
                        new
                        {
                            HomeworkID = 1,
                            Content = "Task",
                            ContentType = "pdf",
                            CourseID = 1,
                            StudentID = 1,
                            SubmissionTime = new DateTime(2023, 6, 7, 22, 56, 39, 813, DateTimeKind.Local).AddTicks(28)
                        },
                        new
                        {
                            HomeworkID = 2,
                            Content = "Task",
                            ContentType = "application",
                            CourseID = 2,
                            StudentID = 1,
                            SubmissionTime = new DateTime(2023, 6, 7, 22, 56, 39, 813, DateTimeKind.Local).AddTicks(984)
                        });
                });

            modelBuilder.Entity("StudentSystem.Data.Models.Resource", b =>
                {
                    b.Property<int>("ResourceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResourceID"));

                    b.Property<int>("CourseID")
                        .HasColumnType("int")
                        .HasColumnName("CourseId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Name");

                    b.Property<string>("ResourceType")
                        .IsRequired()
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("varchar")
                        .HasColumnName("ResourceType");

                    b.Property<string>("Url")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("text")
                        .HasColumnName("Url");

                    b.HasKey("ResourceID");

                    b.HasIndex("CourseID");

                    b.ToTable("Resources");

                    b.HasData(
                        new
                        {
                            ResourceID = 1,
                            CourseID = 1,
                            Name = "Metanit",
                            ResourceType = "video",
                            Url = "www.link.com"
                        },
                        new
                        {
                            ResourceID = 2,
                            CourseID = 2,
                            Name = "Entity Framework Core",
                            ResourceType = "video",
                            Url = "www.linkk.com"
                        });
                });

            modelBuilder.Entity("StudentSystem.Data.Models.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentID"));

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("date")
                        .HasColumnName("Birthday");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Name");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char")
                        .HasColumnName("PhoneNumber")
                        .IsFixedLength();

                    b.Property<DateTime>("RegisteredOn")
                        .HasColumnType("date")
                        .HasColumnName("RegisteredOn");

                    b.HasKey("StudentID");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentID = 1,
                            Birthday = new DateTime(2023, 6, 7, 22, 56, 39, 802, DateTimeKind.Local).AddTicks(6738),
                            Name = "Maksim",
                            PhoneNumber = "+124233456789",
                            RegisteredOn = new DateTime(2023, 6, 7, 22, 56, 39, 800, DateTimeKind.Local).AddTicks(255)
                        },
                        new
                        {
                            StudentID = 2,
                            Birthday = new DateTime(2023, 6, 7, 22, 56, 39, 802, DateTimeKind.Local).AddTicks(7242),
                            Name = "Stepan",
                            PhoneNumber = "+123232456789",
                            RegisteredOn = new DateTime(2023, 6, 7, 22, 56, 39, 802, DateTimeKind.Local).AddTicks(7230)
                        });
                });

            modelBuilder.Entity("StudentSystem.Data.Models.StudentCourse", b =>
                {
                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.HasKey("StudentID", "CourseID");

                    b.HasIndex("CourseID");

                    b.ToTable("StudentCourses");

                    b.HasData(
                        new
                        {
                            StudentID = 1,
                            CourseID = 1
                        },
                        new
                        {
                            StudentID = 2,
                            CourseID = 2
                        });
                });

            modelBuilder.Entity("StudentSystem.Data.Models.Homework", b =>
                {
                    b.HasOne("StudentSystem.Data.Models.Course", "Course")
                        .WithMany("HomeworkSubmissions")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentSystem.Data.Models.Student", "Student")
                        .WithMany("HomeworkSubmissions")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentSystem.Data.Models.Resource", b =>
                {
                    b.HasOne("StudentSystem.Data.Models.Course", "Course")
                        .WithMany("Resources")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("StudentSystem.Data.Models.StudentCourse", b =>
                {
                    b.HasOne("StudentSystem.Data.Models.Course", "Course")
                        .WithMany("StudentsEnrolled")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentSystem.Data.Models.Student", "Student")
                        .WithMany("CourseEnrollments")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentSystem.Data.Models.Course", b =>
                {
                    b.Navigation("HomeworkSubmissions");

                    b.Navigation("Resources");

                    b.Navigation("StudentsEnrolled");
                });

            modelBuilder.Entity("StudentSystem.Data.Models.Student", b =>
                {
                    b.Navigation("CourseEnrollments");

                    b.Navigation("HomeworkSubmissions");
                });
#pragma warning restore 612, 618
        }
    }
}
