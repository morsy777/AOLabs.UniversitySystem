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
    public class StudentEntityTypeConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(s => s.FullName)
                .HasMaxLength(100);

            builder.Property(s => s.NationalId)
                .HasMaxLength(14);

            builder.Property(s => s.Email)
                .HasMaxLength(100);
        }
    }
}
