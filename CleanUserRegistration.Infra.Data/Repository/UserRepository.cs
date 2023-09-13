using CleanUserRegistration.Domain.Interfaces;
using CleanUserRegistration.Domain.Models;
using CleanUserRegistration.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanUserRegistration.Infra.Data.Repository
{
    public class UserRepository:IUserRepository
    {
        private readonly UserContext _userContext;

        public UserRepository(UserContext userContext)
        {
            _userContext = userContext;
        }

        public void Delete(User user)
        {
            _userContext.Entry(user).State = EntityState.Deleted;
        }

        public List<User> GetAll()
        {
            return _userContext.Users.ToList();
        }

        public User GetById(int id)
        {
            return _userContext.Users.Find(id);
        }

        public void Insert(User user)
        {
            _userContext.Users.Add(user);
        }

        public void Save()
        {
            _userContext.SaveChanges();
        }

        public void Update(User user)
        {
            _userContext.Entry(user).State = EntityState.Modified;
        }
    }
}
