using ClsData.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClsCandidate.IService
{
    public interface IRegister
    {
        Task<bool> ExistsAsync(string email);
        Task<List<Basic_details>> getall();
        Task InsertBasic([FromBody] Basic_details basic);
    }
}
