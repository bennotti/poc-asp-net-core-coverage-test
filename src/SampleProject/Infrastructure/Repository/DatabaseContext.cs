using Microsoft.EntityFrameworkCore;
using SampleProject.Domain.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleProject.Infrastructure.Repository
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<TaskEntity> Tasks { get; set; }
    }
}
