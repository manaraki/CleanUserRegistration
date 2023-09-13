using CleanUserRegistration.Domain.Interfaces;
using CleanUserRegistration.Domain.Models;
using CleanUserRegistrationApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanUserRegistrationApplication.Services
{
    public class UserRegisterService:IUserRegisterService
    {
        private readonly IUserRepository _userRepository;

        public UserRegisterService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void RegisterUser(string first_name, string last_name, string email, string phone)
        {
            User user = new User
            {
                first_name = first_name,
                last_name = last_name,
                email = email,
                phone = phone
            };

            _userRepository.Insert(user);
        }
    }
}

