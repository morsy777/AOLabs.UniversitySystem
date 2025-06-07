using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnivercitySystem.Models;

namespace UniversitySystem.Configurations
{
    public class CourseInstructorEntityTypeConfiguration : IEntityTypeConfiguration<CourseInstructor>
    {
        public void Configure(EntityTypeBuilder<CourseInstructor> builder)
        {
            builder.HasKey(bridge => new { bridge.CourseId, bridge.InstructorId });
        }
    }
}
