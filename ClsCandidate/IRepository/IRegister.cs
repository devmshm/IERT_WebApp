namespace ClsCandidate.IService
{
    public interface IRegister<T> where T : class
    {
        Task<bool> ExistsAsync(Func<T, bool> predicate);
        Task<List<T>> GetAll();
        Task InsertBasic(T basic);
        Task InsertAddress(T address);
    }
}
