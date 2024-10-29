using System.Data.Entity;
using UniversityMVCProject.Models;

namespace UniversityMVCProject.Data
{
    public class UniversityContext : DbContext
    {
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public UniversityContext() : base("name=UniversityContext")
        {
        }

        public System.Data.Entity.DbSet<UniversityMVCProject.Models.UniversityCampus> UniversityCampus { get; set; }
        public System.Data.Entity.DbSet<UniversityMVCProject.Models.Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configure the one-to-many relationship
            modelBuilder.Entity<Student>()
                .HasRequired(s => s.Campus)
                .WithMany(c => c.Students)
                .HasForeignKey(s => s.CampusID);
        }
    }
}
