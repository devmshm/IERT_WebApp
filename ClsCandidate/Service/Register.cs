using ClsCandidate.IService;
using clsCommon;
using ClsData.Models;

namespace ClsCandidate.Service
{
    public class Register
    {
        protected readonly IRegister<Basic_details> _register;
        protected readonly IRegister<Address> _address;
        protected readonly IRegister<Personal_details> _personal;
        public Register(IRegister<Basic_details> register, IRegister<Address> address,
            IRegister<Personal_details> personal)
        {
            _register = register;
            _address = address;
            _personal = personal;
        }

        public async Task<List<Basic_details>> getall(string appid)
        {
            var user = await _register.GetAll(appid);
            return user;
        }
        public async Task<List<Personal_details>> Get_Personal(string appid)
        {
            var user = await _personal.GetAll(appid);
            return user;
        }
        public async Task<List<Address>> getadd(string appid)
        {
            var user = await _address.GetAll(appid);
            return user;
        }
        public async Task<Response> InsertBasic(Basic_details basic)
        {
            if (string.IsNullOrWhiteSpace(basic.email))
            {
                return new Response { Message = "Email cannot be null or empty.", Status = 400 };
            }
            bool exists = await _register.ExistsAsync(p => p.email == basic.email);

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
