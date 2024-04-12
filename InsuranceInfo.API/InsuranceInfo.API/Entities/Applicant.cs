using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InsuranceInfo.API.Entities
{
    public class Applicant
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required string FirstName { get; set; }

        public required string LastName { get; set; }
        
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public decimal AnnualIncome { get; set; }
        [Required]
        public int ifTobaccoUser { get; set; }
    }
}
