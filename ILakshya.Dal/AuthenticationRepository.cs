﻿using ILakshya.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILakshya.Dal
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        private readonly WebPocHubDbContext _dbContext;
        public AuthenticationRepository(WebPocHubDbContext context)
        { 
            _dbContext = context;
        }
        public User? CheckCredentials(User user)
        {
            var userCredentials = _dbContext.Users.SingleOrDefault(u => u.Email == user.Email);
            return userCredentials;
        }
        
        public string GetUserRole(int roleId)
        {
            return _dbContext.Roles.SingleOrDefault(role => role.RoleId == roleId).RoleName;
        }
        public int RegisterUser(User user)
        {
            _dbContext.Users.Add(user);
            return _dbContext.SaveChanges();
        }
    }
}
