using CleanUserRegistration.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanUserRegistration.Infra.Data.Context
{
    public class UserContext:DbContext

    {           
        public UserContext(DbContextOptions<UserContext> options):base(options)
        {
            
        }               

        public DbSet<User>? Users { get; set; }
    }
}
