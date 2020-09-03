using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingSofka.Web.Data;
using TrainingSofka.Web.Data.Entities;
using TrainingSofka.Web.Enums;
using TrainingSofka.Web.Models;

namespace TrainingSofka.Web.Helpers
{
    public class UserHelper : IUserHelper

    {

        private readonly UserManager<UserEntity> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<UserEntity> _signInManager;
        private readonly DataContext _context;

        public UserHelper(
           UserManager<UserEntity> userManager,
           RoleManager<IdentityRole> roleManager,
            SignInManager<UserEntity> signInManager,
          DataContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _context = context;
        }
        public Task<IdentityResult> AddUserAsync(UserEntity user, string password)
        {
            throw new NotImplementedException();
        }

        public Task AddUserToRoleAsync(UserEntity user, string roleName)
        {
            throw new NotImplementedException();
        }

        public Task CheckRoleAsync(string roleName)
        {
            throw new NotImplementedException();
        }

        public Task<UserEntity> GetUserAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<UserEntity> GetUserAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsUserInRoleAsync(UserEntity user, string roleName)
        {
            throw new NotImplementedException();
        }
    }
}

