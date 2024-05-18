using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ApplicationForm.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<BasicDetails> BasicDetails { get; set; }
        public DbSet<EducationDetails> EducationDetails { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }
    }
}
