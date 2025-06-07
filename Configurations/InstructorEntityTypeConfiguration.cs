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
    public class InstructorEntityTypeConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.Property(i => i.FullName)
                .HasMaxLength(100);

            builder.Property(i => i.NationalId)
                .HasMaxLength(14);

            builder.Property(i => i.Email)
                .HasMaxLength(100);

            builder.Property(i => i.AcademicRank)
                .HasMaxLength(50)
                .IsRequired();

        }
    }
}
