using ClsCandidate.IService;
using clsCommon;
using ClsData.Models;

namespace ClsCandidate.Service
{
    public class Register
    {
        protected readonly IRegister _register;
        public Register(IRegister register)
        {
            _register = register;
        }
        public async Task<List<Basic_details>> getall()
        {
            var user = await _register.getall();
            return user;
        }
        public async Task<Response> InsertBasic(Basic_details basic)
        {
            if (string.IsNullOrWhiteSpace(basic.email))
            {
                return new Response { Message = "Email cannot be null or empty.", Status = 400 };
            }
            bool exists = await _register.ExistsAsync(basic.email);
            if (exists)
            {
                return new Response { Message = "Already Exists", Status = 200 };
            }
            var user = new Basic_details
            {
                First_Name = basic.First_Name,
                email = basic.email,
                course = basic.course,
                phone_number = basic.phone_number,
                password = basic.password,
                course_code = basic.course_code,
                DOB = basic.DOB,
                Id = basic.Id,
                Last_Name = basic.Last_Name,
                Middle_Name = basic.Middle_Name,
            };
            await _register.InsertBasic(user);

            return new Response { Message = "Registration Successful", Status = 200 };
        }
    }
}
