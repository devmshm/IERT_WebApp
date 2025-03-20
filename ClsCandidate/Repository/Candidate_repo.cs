using ClsCandidate.IService;
using ClsData.AppDbContext;
using Microsoft.EntityFrameworkCore;

namespace ClsCandidate.Repository
{
    public class Candidate_repo<T> : IRegister<T> where T : class
    {
        protected readonly Iert_DbContext _dbContext;
        private readonly DbSet<T> _dbSet;
        public Candidate_repo(Iert_DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }
        public async Task<List<T>> GetAll(string appid)
        {
            return await _dbSet.Where(
                x => EF.Property<string>(x, "Id") == appid).
                ToListAsync();
        }
        public async Task<bool> ExistsAsync(Func<T, bool> predicate)
        {
            return await _dbSet.AnyAsync(e => predicate(e));
        }
        public async Task InsertBasic(T basic)
        {
            _dbSet.Add(basic);
            await _dbContext.SaveChangesAsync();
        }
        public async Task InsertAddress(T address)
        {
            _dbSet.Add(address);
            await _dbContext.SaveChangesAsync();
        }


    }
}
