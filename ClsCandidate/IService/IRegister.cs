using ClsData.Models;

namespace ClsCandidate.IService
{
    public interface IRegister
    {
        Task<List<Basic_details>> getall();
    }
}
