using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanUserRegistrationApplication.Interfaces
{
    internal interface IUserRegisterService
    {
        public void RegisterUser(string first_name, string last_name, string email, string phone);
    
    }
}
