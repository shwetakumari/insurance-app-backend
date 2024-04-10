using InsuranceInfo.API.DbContexts;
using InsuranceInfo.API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InsuranceInfo.API.Controllers
{
    [ApiController]
    [Route("api/Applicant")]
    public class ApplicantController : ControllerBase
    {
        private readonly ApplicantInfoContext _dbContext;

        public ApplicantController(ApplicantInfoContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public async Task<IActionResult> GetApplicantByUserDetails([FromBody] Applicant applicant)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _dbContext.Applicant.Add(applicant);
                    await _dbContext.SaveChangesAsync();
                    return Ok("Applicant created successfully");
                }
                catch (Exception ex)
                {
                    return StatusCode(500, $"Internal server error: {ex.Message}");
                }
            }
            else
            {
                return BadRequest("Invalid model state");
            }
        }

        [HttpGet]
        public IActionResult GetApplicantById(int id)
        {
            try
            {
                // Retrieve applicant from database by ID
                var applicant = _dbContext.Applicant.ToList();

                if (applicant == null)
                {
                    return NotFound(new { message = "Applicant not found." });
                }

                return Ok(applicant);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while processing the request.", error = ex.Message });
            }
        }

        [HttpGet("{firstName}/{lastName}/{dateOfBirth}/{annualIncome}/{isTobaccoUser}")]
        public IActionResult GetApplicantByUserDetails(string firstName, string lastName, DateTime dateOfBirth, decimal annualIncome, bool isTobaccoUser)
        {
            try
            {
                // Retrieve applicant from database by ID
                //var applicant = _dbContext.Applicant.ToList();
                var applicant = _dbContext.Applicant.ToList().FirstOrDefault(a =>
                a.FirstName.ToLower() == firstName.ToLower() &&
                a.LastName.ToLower() == lastName.ToLower() &&
                a.DateOfBirth.Date == dateOfBirth.Date &&
                a.AnnualIncome == annualIncome && a.IsTobaccoUser == isTobaccoUser);

                if (applicant == null)
                {
                    return NotFound(new { message = "Applicant not found." });
                }

                return Ok(applicant);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while processing the request.", error = ex.Message });
            }
        }
    }
}
