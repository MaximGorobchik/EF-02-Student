using StudentSystem.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentSystem.Data.Models
{
    public enum ResourceType
    {
        video,
        presentation,
        document,
        other
    }

    [Table("Resources")]
    public class Resource
    {
        public Resource()
        {

        }

        public Resource(int resourceId, string name, string url, ResourceType resourceType, Course course)
        {
            this.ResourceID = resourceId;
            this.Name = name;
            this.Url = url;
            this.ResourceType = resourceType;
            this.Course = course;
        }

        [Key]
        public int ResourceID { get; set; }

        [Required]
        [StringLength(50)]
        [Column("Name", TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        [Required]
        [Column("Url", TypeName = "text")]
        public string Url { get; set; }

        [Required]
        [StringLength(12)]
        [Column("ResourseType", TypeName = "varchar(12)")]
        public ResourceType ResourceType { get; set; }

        [Required]
        public int CourseID { get; set; }

        [ForeignKey(nameof(CourseID))]
        public Course Course { get; set; }
    }
}
