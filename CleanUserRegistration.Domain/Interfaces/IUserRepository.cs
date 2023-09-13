using CleanUserRegistration.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanUserRegistration.Domain.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetAll();
        User GetById(int id);
        void Update(User user);
        void Delete(User user);
        void Insert(User user);
        void Save();
    }
}
