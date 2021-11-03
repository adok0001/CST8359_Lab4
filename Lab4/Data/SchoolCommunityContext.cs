using Lab4.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Data
{
    public class SchoolCommunityContext : DbContext
    {
        public SchoolCommunityContext()
        {

        }
//      public ICollection<Student> studentCollection { get; set; }
//      public ICollection<Community> communities { get; set; }
        public ICollection<CommunityMembership> communityMemberships { get; set; }
        public DbSet<CommunityMembership> memberships { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Community> Communities { get; set; }
        public DbSet<CommunityMembership> CommunityMemberships { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // make sure the table names are not plural. You can do that by setting the proper names in OnModelCreating method
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Community>().ToTable("Community");
            modelBuilder.Entity<CommunityMembership>().ToTable("CommunityMembership");

//            modelBuilder.Entity<Student>().HasKey(c => new { c.Id });
            // CommunityMembership should have a composite key of StudentId and CommunityId
            modelBuilder.Entity<CommunityMembership>().HasKey(c => new { c.StudentId, c.CommunityId });
        }

        public SchoolCommunityContext(DbContextOptions<SchoolCommunityContext> options) : base(options)
        {

        }

    }
}
