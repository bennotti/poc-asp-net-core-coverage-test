using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SampleProject.Domain.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleProject.Infrastructure.Repository.Config
{
    public class TaskEntityConfig : IEntityTypeConfiguration<TaskEntity>
    {
        public void Configure(EntityTypeBuilder<TaskEntity> builder)
        {
            builder.ToTable("tb_tasks");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Title).IsRequired();
        }
    }
}
