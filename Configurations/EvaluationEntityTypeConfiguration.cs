using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySystem.Models;

namespace UniversitySystem.Configurations
{
    public class EvaluationEntityTypeConfiguration : IEntityTypeConfiguration<Evaluation>
    {
        public void Configure(EntityTypeBuilder<Evaluation> builder)
        {
            builder.Property(e => e.Comment)
                .HasMaxLength(500)
                .IsRequired(false);
        }
    }
}
