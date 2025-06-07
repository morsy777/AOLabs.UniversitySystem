using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using UnivercitySystem.Models;

namespace UniversitySystem.Configurations
{
    public class UniversityEntityTypeConfiguration : IEntityTypeConfiguration<University>
    {
        public void Configure(EntityTypeBuilder<University> builder)
        {
            builder.Property(u => u.Name)
                   .HasMaxLength(100);

            builder.Property(u => u.Location)
                   .HasMaxLength(150);
        }
    }
}
