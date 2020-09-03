using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingSofka.Web.Data.Entities;
using TrainingSofka.Web.Enums;
using TrainingSofka.Web.Models;

namespace TrainingSofka.Web.Helpers
{
    public interface IUserHelper
    {
        Task<UserEntity> GetUserAsync(string email);
        Task<UserEntity> GetUserAsync(Guid userId);

        Task<IdentityResult> AddUserAsync(UserEntity user, string password);

        Task CheckRoleAsync(string roleName);

        Task AddUserToRoleAsync(UserEntity user, string roleName);

        Task<bool> IsUserInRoleAsync(UserEntity user, string roleName);

       
    }
}
