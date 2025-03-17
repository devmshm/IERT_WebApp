using ClsCandidate.IService;
using ClsData.AppDbContext;
using ClsData.Models;
using Microsoft.EntityFrameworkCore;

namespace ClsCandidate.Repository
{
    public class Candidate_repo : IRegister
    {
        protected readonly Iert_DbContext _dbContext;
        public Candidate_repo(Iert_DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Basic_details>> getall()
        {
            var user = await _dbContext.basic_Details.ToListAsync();
            return user;
        }
        public async Task<bool> ExistsAsync(string email)
        {
            return await _dbContext.basic_Details.AnyAsync(p => p.email == email);
        }

        public async Task InsertBasic(Basic_details basic)
        {
            _dbContext.basic_Details.Add(basic);
            await _dbContext.SaveChangesAsync();
        }

    }
}
