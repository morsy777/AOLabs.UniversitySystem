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
    public class SpecializationEntityTypeConfiguration : IEntityTypeConfiguration<Specialization>
    {
        public void Configure(EntityTypeBuilder<Specialization> builder)
        {
            builder.Property(s => s.Name)
                   .HasMaxLength(150);
        }
    }
}
