using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentSystem.Data.Models;
using StudentSystem.Interfaces;
using System;
using System.Collections.Generic;

namespace StudentSystem.Seeding
{
    public class ResourceSeeder : ISeeder<Resource>
    {
        private static readonly List<Resource> resources = new()
        {
            new Resource
            {
                ResourceID = 1,
                Name = "Metanit",
                Url = "www.link.com",
                ResourceType = ResourceType.video,
                CourseID = 1
            },

            new Resource
            {
                ResourceID = 2,
                Name = "Entity Framework Core",
                Url = "www.linkk.com",
                ResourceType = ResourceType.video,
                CourseID = 2
            }
        };

        public void Seed(EntityTypeBuilder<Resource> builder)
        {
            builder.HasData(resources);
        }
    }
}
