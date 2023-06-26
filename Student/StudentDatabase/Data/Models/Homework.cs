using StudentSystem.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentSystem.Data.Models
{
    public enum ContentType
    {
        application,
        pdf,
        zip
    }

    [Table("HomeworkSubmissions")]
    public class Homework
    {

        public Homework()
        {

        }

        public Homework(int homeworkId, string content, ContentType contentType, DateTime submissionTime, Student student, Course course)
        {
            this.HomeworkID = homeworkId;
            this.Content = content;
            this.ContentType = contentType;
            this.SubmissionTime = submissionTime;
            this.Student = student;
            this.Course = course;
        }

        [Key]
        public int HomeworkID { get; set; }

        [Required]
        [Column("Content", TypeName = "text")]
        public string Content { get; set; }

        [Required]
        public ContentType ContentType { get; set; }

        [Required]
        [Column("SubmissionTime", TypeName = "date")]
        public DateTime SubmissionTime { get; set; }

        [Required]
        [Column("StudentId", TypeName = "int")]
        public int StudentID { get; set; }

        [ForeignKey(nameof(StudentID))]
        public Student Student { get; set; }

        [Required]
        [Column("CourseId", TypeName = "int")]
        public int CourseID { get; set; }

        [ForeignKey(nameof(CourseID))]
        public Course Course { get; set; }
    }
}
