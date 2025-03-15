using ClsCandidate.IService;
using ClsData.AppDbContext;

using ClsData.Models;
using Microsoft.EntityFrameworkCore;


namespace ClsCandidate.Service
{
    public class Register : IRegister
    {
        protected readonly Iert_DbContext _dbContext;
        public Register(Iert_DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Basic_details>> getall()
        {
            var user = await _dbContext.basic_Details.ToListAsync();
            return user;
        }
    }
}
