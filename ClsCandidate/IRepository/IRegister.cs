namespace ClsCandidate.IService
{
    public interface IRegister<T> where T : class
    {
        Task<bool> ExistsAsync(Func<T, bool> predicate);
        Task<List<T>> GetAll(string appid);
        Task InsertBasic(T basic);
        Task InsertAddress(T address);
    }
}
