﻿using Moshavere.Data.Models;
using System.Threading.Tasks;

namespace Moshavere.Services.Site.Admin.Interface
{
    public interface IAuthService
    {
        Task<User> Register(User user, string password);
        Task<User> Login(string username, string password);
    }
}
