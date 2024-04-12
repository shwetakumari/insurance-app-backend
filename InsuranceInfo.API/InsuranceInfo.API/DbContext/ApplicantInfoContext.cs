using InsuranceInfo.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace InsuranceInfo.API.DbContexts
{
    public class ApplicantInfoContext:DbContext
    {
        public DbSet<Applicant> Applicant { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ApplicantInfo.db");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Applicant>().HasData(
                 new Applicant()
                 {
                     Id = 1,
                     FirstName = "Shweta",
                     LastName = "Kumari",
                     DateOfBirth = DateTime.Now,
                     AnnualIncome = 1000,
                     ifTobaccoUser = 0
                 },
                 new Applicant()
                 {
                     Id = 2,
                     FirstName = "Kunal",
                     LastName = "Kumar",
                     DateOfBirth = DateTime.Now,
                     AnnualIncome = 3000,
                     ifTobaccoUser = 1
                 },
                  new Applicant()
                  {
                      Id = 3,
                      FirstName = "Shivani",
                      LastName = "Kumari",
                      DateOfBirth = DateTime.Now,
                      AnnualIncome = 4000,
                      ifTobaccoUser = 0
                  },
                  new Applicant()
                  {
                      Id = 4,
                      FirstName = "Shivani",
                      LastName = "Kumari",
                      DateOfBirth = DateTime.Now,
                      AnnualIncome = 4000,
                      ifTobaccoUser = 1
                  }

                ) ;
        }

    }
}
