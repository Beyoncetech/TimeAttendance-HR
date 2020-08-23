using AppModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppDAL.DBRepository;
using AppDAL.DBModels;

namespace AppBAL.Sevices.Login
{
    public interface ILoginService
    {
        Task<CommonResponce> ValidateUser(string UserName, string Password);
    }
    public class LoginService : ILoginService
    {         
        private readonly IAppUserRepository _DBUserRepository;
        public LoginService(IAppUserRepository DBUserRepository)
        {
            _DBUserRepository = DBUserRepository;            
        }
        public async Task<CommonResponce> ValidateUser(string UserName, string Password)
        {
            bool isValid = false;
            var oUser = await _DBUserRepository.GetUserByUserID(UserName).ConfigureAwait(false);

            if (oUser != null)
            {
                if (oUser.Password.Equals(Password))
                    isValid = true;
            }
            CommonResponce result = new CommonResponce
            {
                Stat = isValid,
                StatusMsg = "",
                StatusObj = oUser
            };
            return result;
        }
    }
}
